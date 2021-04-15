package com.fissoft.app;

import android.app.Service;
import android.bluetooth.BluetoothAdapter;
import android.bluetooth.BluetoothDevice;
import android.content.Intent;
import android.content.IntentFilter;
import android.os.Binder;
import android.os.IBinder;
import android.util.Log;

import com.fissoft.beacon.BeaconReceiver;

import java.util.Timer;
import java.util.TimerTask;

public class MyService extends Service {

    private static final String TAG = "MyService";
    private BluetoothAdapter bluetoothAdapter = BluetoothAdapter.getDefaultAdapter();
    private Timer timer;
    private BeaconReceiver beaconReceiver;

    public MyService() {
    }

    @Override
    public IBinder onBind(Intent intent) {
        return new Binder();
    }


    @Override
    public void onCreate() {
        super.onCreate();
        Log.i(TAG, "服务启动");
        beaconReceiver = new BeaconReceiver(beacon -> Log.i(TAG, String.format("name: %s , mac:%s , rssi: %f , distance：%f", beacon.getName(), beacon.getMac(), beacon.getRssi(), beacon.getDistance())));
        IntentFilter intentFilter = new IntentFilter(BluetoothDevice.ACTION_FOUND);
        intentFilter.addAction(BluetoothAdapter.ACTION_DISCOVERY_STARTED);
        intentFilter.addAction(BluetoothAdapter.ACTION_DISCOVERY_FINISHED);
        intentFilter.addAction(BluetoothAdapter.ACTION_STATE_CHANGED);
        registerReceiver(beaconReceiver, intentFilter);
        timer = new Timer();
        timer.schedule(new TimerTask() {
            @Override
            public void run() {
                if (!bluetoothAdapter.isDiscovering()) {
                    bluetoothAdapter.startDiscovery();
                }
            }
        }, 0, 2000);
    }

    @Override
    public void onDestroy() {
        super.onDestroy();
        unregisterReceiver(beaconReceiver);
        timer.cancel();
    }
}