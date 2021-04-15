package com.fissoft.app;

public class Beacon {
    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    public String getMac() {
        return Mac;
    }

    public void setMac(String mac) {
        Mac = mac;
    }

    public Double getDistance() {
        return Distance;
    }

    public void setDistance(Double distance) {
        Distance = distance;
    }

    public Double getRssi() {
        return Rssi;
    }

    public void setRssi(Double rssi) {
        Rssi = rssi;
    }

    /**
     * 设备名称
     */
    private String Name;
    /**
     * MAC地址
     */
    private String Mac;
    /**
     * 距离
     */
    private Double Distance;
    /**
     * 信号强度
     */
    private Double Rssi;
}
