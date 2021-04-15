package crc64a27fdd34899c7945;


public class BeaconService
	extends android.app.Service
	implements
		mono.android.IGCUserPeer,
		com.fissoft.beacon.IBeacon
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBind:(Landroid/content/Intent;)Landroid/os/IBinder;:GetOnBind_Landroid_content_Intent_Handler\n" +
			"n_onCreate:()V:GetOnCreateHandler\n" +
			"n_onDestroy:()V:GetOnDestroyHandler\n" +
			"n_device:(Lcom/fissoft/beacon/Beacon;)V:GetDevice_Lcom_fissoft_beacon_Beacon_Handler:Com.Fissoft.Beacon.IBeaconInvoker, Beacon\n" +
			"";
		mono.android.Runtime.register ("App.BeaconService, App", BeaconService.class, __md_methods);
	}


	public BeaconService ()
	{
		super ();
		if (getClass () == BeaconService.class)
			mono.android.TypeManager.Activate ("App.BeaconService, App", "", this, new java.lang.Object[] {  });
	}


	public android.os.IBinder onBind (android.content.Intent p0)
	{
		return n_onBind (p0);
	}

	private native android.os.IBinder n_onBind (android.content.Intent p0);


	public void onCreate ()
	{
		n_onCreate ();
	}

	private native void n_onCreate ();


	public void onDestroy ()
	{
		n_onDestroy ();
	}

	private native void n_onDestroy ();


	public void device (com.fissoft.beacon.Beacon p0)
	{
		n_device (p0);
	}

	private native void n_device (com.fissoft.beacon.Beacon p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
