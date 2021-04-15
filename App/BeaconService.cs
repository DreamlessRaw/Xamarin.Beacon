using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.Fissoft.Beacon;
using Android.Bluetooth;
using System.Threading;

namespace App
{
    [Service]
    public class BeaconService : Service, IBeacon
    {
        private BluetoothAdapter bluetoothAdapter = BluetoothAdapter.DefaultAdapter;
        private BeaconReceiver BeaconReceiver;
        private Timer timer;

        public void Device(Beacon beacon)
        {
            Android.Util.Log.Info("BeaconService", $"{beacon.Mac}-{beacon.Distance}");
        }

        public override IBinder OnBind(Intent intent)
        {
            return new Binder();
        }

        public override void OnCreate()
        {
            base.OnCreate();
            BeaconReceiver = new BeaconReceiver(this);
            IntentFilter intentFilter = new IntentFilter(BluetoothDevice.ActionFound);
            intentFilter.AddAction(BluetoothAdapter.ActionDiscoveryStarted);
            intentFilter.AddAction(BluetoothAdapter.ActionDiscoveryFinished);
            intentFilter.AddAction(BluetoothAdapter.ActionStateChanged);
            RegisterReceiver(BeaconReceiver, intentFilter);
            timer = new Timer(Scanner, null, 1000, 5000);
        }

        public override void OnDestroy()
        {
            base.OnDestroy();
            // 停止蓝牙扫描、卸载广播、释放定时器
            if (bluetoothAdapter != null)
            {
                bluetoothAdapter.CancelDiscovery();
            }
            UnregisterReceiver(BeaconReceiver);
            timer.Dispose();
        }

        private void Scanner(object o)
        {
            if (bluetoothAdapter != null && !bluetoothAdapter.IsDiscovering)
            {
                bluetoothAdapter.StartDiscovery();
            }
        }
    }
}