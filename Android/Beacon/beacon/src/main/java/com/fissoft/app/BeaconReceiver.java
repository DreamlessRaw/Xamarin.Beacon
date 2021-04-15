package com.fissoft.app;

import android.bluetooth.BluetoothAdapter;
import android.bluetooth.BluetoothDevice;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.util.Log;

import static java.lang.Math.abs;

public class BeaconReceiver extends BroadcastReceiver {
    private String TAG = "BeaconReceiver";
    private IBeacon mBeacon;

    public BeaconReceiver(IBeacon iBeacon) {
        mBeacon = iBeacon;
    }

    @Override
    public void onReceive(Context context, Intent intent) {
        switch (intent.getAction()) {
            case BluetoothAdapter.ACTION_STATE_CHANGED: // 监听蓝牙状态变化
                switch (intent.getIntExtra(BluetoothAdapter.EXTRA_STATE, 0)) {
                    case BluetoothAdapter.STATE_TURNING_ON:
                        Log.i(TAG, "蓝牙正在打开");
                        break;
                    case BluetoothAdapter.STATE_ON:
                        Log.i(TAG, "蓝牙已经打开");
                        break;
                    case BluetoothAdapter.STATE_TURNING_OFF:
                        Log.i(TAG, "蓝牙正在关闭");
                        break;
                    case BluetoothAdapter.STATE_OFF:
                        Log.i(TAG, "蓝牙已经关闭");
                        break;
                }
                break;
            case BluetoothDevice.ACTION_FOUND: // 搜索到蓝牙
                BluetoothDevice bluetoothDevice = intent.getParcelableExtra(BluetoothDevice.EXTRA_DEVICE);
                short rssi = intent.getShortExtra(BluetoothDevice.EXTRA_RSSI, (short) 0);
                Beacon beacon = new Beacon();
                beacon.setName(bluetoothDevice.getName());
                beacon.setMac(bluetoothDevice.getAddress());
                beacon.setRssi(Double.parseDouble(String.valueOf(rssi)));
                beacon.setDistance(Math.pow(10.0, ((abs(beacon.getRssi()) - 59) / (10 * 2.0))));
                mBeacon.device(beacon);
                break;
            case BluetoothAdapter.ACTION_DISCOVERY_STARTED:
                Log.i(TAG, "搜索开始");
                break;
            case BluetoothAdapter.ACTION_DISCOVERY_FINISHED:
                Log.i(TAG, "搜索完成");
                break;
        }
    }


}