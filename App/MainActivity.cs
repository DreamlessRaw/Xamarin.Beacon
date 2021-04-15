using Android;
using Android.App;
using Android.Bluetooth;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.Core.App;
using System;

namespace App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, BluetoothAdapter.ILeScanCallback
    {

        private BluetoothAdapter bluetoothAdapter = BluetoothAdapter.DefaultAdapter;
        private readonly BeaconServiceConnection beaconServiceConnection = new BeaconServiceConnection();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var btnScan = this.FindViewById<Button>(Resource.Id.btn_scan);
            btnScan.Click += (s, e) =>
            {
                bluetoothAdapter.StartLeScan(this);
            };

            if (ActivityCompat.CheckSelfPermission(this, Manifest.Permission.AccessFineLocation)
                != Android.Content.PM.Permission.Granted
            )
            {
                ActivityCompat.RequestPermissions(
                    this,
                   new string[] { Manifest.Permission.AccessFineLocation, Manifest.Permission.AccessCoarseLocation },
                    233
                );
            }
            else
            {
                BindService(
                   new Intent(this, typeof(BeaconService)),
                beaconServiceConnection,
               Bind.AutoCreate
            );
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            if (requestCode == 233 && grantResults[0] == Android.Content.PM.Permission.Granted)
            {
                BindService(
                   new Intent(this, typeof(BeaconService)),
                beaconServiceConnection,
               Bind.AutoCreate
            );
            }
            else
            {
                Toast.MakeText(this, "用户拒绝了权限,无法定位", ToastLength.Long).Show();
            }
        }

        public void OnLeScan(BluetoothDevice device, int rssi, byte[] scanRecord)
        {
            double d = Math.Pow(10.0, (Math.Abs(rssi) - 59) / (10 * 2.0));
            Android.Util.Log.Info("OnLeScan", $"onCreate: {device.Address} 信号强度：{rssi}  距离：{d}");
            if (device.Address == "D8:96:E0:8B:8B:72")
            {
                bluetoothAdapter.StopLeScan(this);
            }
        }
    }
}