using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Fissoft.Beacon {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.fissoft.beacon']/interface[@name='IBeacon']"
	[Register ("com/fissoft/beacon/IBeacon", "", "Com.Fissoft.Beacon.IBeaconInvoker")]
	public partial interface IBeacon : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.fissoft.beacon']/interface[@name='IBeacon']/method[@name='device' and count(parameter)=1 and parameter[1][@type='com.fissoft.beacon.Beacon']]"
		[Register ("device", "(Lcom/fissoft/beacon/Beacon;)V", "GetDevice_Lcom_fissoft_beacon_Beacon_Handler:Com.Fissoft.Beacon.IBeaconInvoker, Xamarin.Beacon")]
		void Device (global::Com.Fissoft.Beacon.Beacon p0);

	}

	[global::Android.Runtime.Register ("com/fissoft/beacon/IBeacon", DoNotGenerateAcw=true)]
	internal partial class IBeaconInvoker : global::Java.Lang.Object, IBeacon {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/fissoft/beacon/IBeacon", typeof (IBeaconInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IBeacon GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBeacon> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.", JNIEnv.GetClassNameFromInstance (handle), "com.fissoft.beacon.IBeacon"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBeaconInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_device_Lcom_fissoft_beacon_Beacon_;
#pragma warning disable 0169
		static Delegate GetDevice_Lcom_fissoft_beacon_Beacon_Handler ()
		{
			if (cb_device_Lcom_fissoft_beacon_Beacon_ == null)
				cb_device_Lcom_fissoft_beacon_Beacon_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Device_Lcom_fissoft_beacon_Beacon_);
			return cb_device_Lcom_fissoft_beacon_Beacon_;
		}

		static void n_Device_Lcom_fissoft_beacon_Beacon_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Fissoft.Beacon.IBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Fissoft.Beacon.Beacon> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Device (p0);
		}
#pragma warning restore 0169

		IntPtr id_device_Lcom_fissoft_beacon_Beacon_;
		public unsafe void Device (global::Com.Fissoft.Beacon.Beacon p0)
		{
			if (id_device_Lcom_fissoft_beacon_Beacon_ == IntPtr.Zero)
				id_device_Lcom_fissoft_beacon_Beacon_ = JNIEnv.GetMethodID (class_ref, "device", "(Lcom/fissoft/beacon/Beacon;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_device_Lcom_fissoft_beacon_Beacon_, __args);
		}

	}
}
