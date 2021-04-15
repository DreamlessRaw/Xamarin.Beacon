package com.fissoft.app

import android.Manifest
import android.bluetooth.BluetoothAdapter
import android.content.ComponentName
import android.content.Context
import android.content.Intent
import android.content.ServiceConnection
import android.content.pm.PackageManager
import android.os.Bundle
import android.os.IBinder
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import androidx.core.app.ActivityCompat

class MainActivity : AppCompatActivity() {
    private val connection = object : ServiceConnection {
        override fun onServiceConnected(name: ComponentName?, service: IBinder?) {
        }

        override fun onServiceDisconnected(name: ComponentName?) {
        }
    }

    private val bluetoothAdapter = BluetoothAdapter.getDefaultAdapter()


    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        if (ActivityCompat.checkSelfPermission(this, Manifest.permission.ACCESS_FINE_LOCATION)
            != PackageManager.PERMISSION_GRANTED
        ) {
            ActivityCompat.requestPermissions(
                this,
                arrayOf(
                    Manifest.permission.ACCESS_COARSE_LOCATION,
                    Manifest.permission.ACCESS_FINE_LOCATION
                ),
                233
            )
        } else {
            bindService(
                Intent(this, MyService::class.java),
                connection,
                Context.BIND_AUTO_CREATE
            )
        }

    }


    override fun onDestroy() {
        super.onDestroy()
        unbindService(connection)
    }

    override fun onRequestPermissionsResult(
        requestCode: Int,
        permissions: Array<String?>,
        grantResults: IntArray
    ) {
        super.onRequestPermissionsResult(requestCode, permissions, grantResults)
        if (requestCode == 233 && grantResults[0] == PackageManager.PERMISSION_GRANTED) {
            bindService(
                Intent(this, MyService::class.java),
                connection,
                Context.BIND_AUTO_CREATE
            )
        } else {
            Toast.makeText(this, "用户拒绝了权限,无法定位", Toast.LENGTH_LONG).show()
        }
    }
}