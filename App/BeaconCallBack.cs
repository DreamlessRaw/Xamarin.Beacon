﻿using Android.App;
using Android.Bluetooth;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App
{
    class BeaconCallBack : Java.Lang.Object, BluetoothAdapter.ILeScanCallback
    {
        public void OnLeScan(BluetoothDevice device, int rssi, byte[] scanRecord)
        {
            throw new NotImplementedException();
        }
    }
}