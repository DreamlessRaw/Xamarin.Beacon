using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Fissoft.Beacon {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.fissoft.beacon']/class[@name='Beacon']"
	[global::Android.Runtime.Register ("com/fissoft/beacon/Beacon", DoNotGenerateAcw=true)]
	public partial class Beacon : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/fissoft/beacon/Beacon", typeof (Beacon));

		internal static IntPtr class_ref {
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
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected Beacon (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.fissoft.beacon']/class[@name='Beacon']/constructor[@name='Beacon' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Beacon () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getDistance;
#pragma warning disable 0169
		static Delegate GetGetDistanceHandler ()
		{
			if (cb_getDistance == null)
				cb_getDistance = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDistance);
			return cb_getDistance;
		}

		static IntPtr n_GetDistance (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Fissoft.Beacon.Beacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Distance);
		}
#pragma warning restore 0169

		static Delegate cb_setDistance_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetDistance_Ljava_lang_Double_Handler ()
		{
			if (cb_setDistance_Ljava_lang_Double_ == null)
				cb_setDistance_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDistance_Ljava_lang_Double_);
			return cb_setDistance_Ljava_lang_Double_;
		}

		static void n_SetDistance_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_distance)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Fissoft.Beacon.Beacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var distance = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_distance, JniHandleOwnership.DoNotTransfer);
			__this.Distance = distance;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Double Distance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.fissoft.beacon']/class[@name='Beacon']/method[@name='getDistance' and count(parameter)=0]"
			[Register ("getDistance", "()Ljava/lang/Double;", "GetGetDistanceHandler")]
			get {
				const string __id = "getDistance.()Ljava/lang/Double;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.fissoft.beacon']/class[@name='Beacon']/method[@name='setDistance' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setDistance", "(Ljava/lang/Double;)V", "GetSetDistance_Ljava_lang_Double_Handler")]
			set {
				const string __id = "setDistance.(Ljava/lang/Double;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getMac;
#pragma warning disable 0169
		static Delegate GetGetMacHandler ()
		{
			if (cb_getMac == null)
				cb_getMac = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMac);
			return cb_getMac;
		}

		static IntPtr n_GetMac (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Fissoft.Beacon.Beacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Mac);
		}
#pragma warning restore 0169

		static Delegate cb_setMac_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMac_Ljava_lang_String_Handler ()
		{
			if (cb_setMac_Ljava_lang_String_ == null)
				cb_setMac_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMac_Ljava_lang_String_);
			return cb_setMac_Ljava_lang_String_;
		}

		static void n_SetMac_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mac)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Fissoft.Beacon.Beacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mac = JNIEnv.GetString (native_mac, JniHandleOwnership.DoNotTransfer);
			__this.Mac = mac;
		}
#pragma warning restore 0169

		public virtual unsafe string Mac {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.fissoft.beacon']/class[@name='Beacon']/method[@name='getMac' and count(parameter)=0]"
			[Register ("getMac", "()Ljava/lang/String;", "GetGetMacHandler")]
			get {
				const string __id = "getMac.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.fissoft.beacon']/class[@name='Beacon']/method[@name='setMac' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMac", "(Ljava/lang/String;)V", "GetSetMac_Ljava_lang_String_Handler")]
			set {
				const string __id = "setMac.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Fissoft.Beacon.Beacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Fissoft.Beacon.Beacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.Name = name;
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.fissoft.beacon']/class[@name='Beacon']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.fissoft.beacon']/class[@name='Beacon']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRssi;
#pragma warning disable 0169
		static Delegate GetGetRssiHandler ()
		{
			if (cb_getRssi == null)
				cb_getRssi = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRssi);
			return cb_getRssi;
		}

		static IntPtr n_GetRssi (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Fissoft.Beacon.Beacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Rssi);
		}
#pragma warning restore 0169

		static Delegate cb_setRssi_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetRssi_Ljava_lang_Double_Handler ()
		{
			if (cb_setRssi_Ljava_lang_Double_ == null)
				cb_setRssi_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRssi_Ljava_lang_Double_);
			return cb_setRssi_Ljava_lang_Double_;
		}

		static void n_SetRssi_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rssi)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Fissoft.Beacon.Beacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rssi = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_rssi, JniHandleOwnership.DoNotTransfer);
			__this.Rssi = rssi;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Double Rssi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.fissoft.beacon']/class[@name='Beacon']/method[@name='getRssi' and count(parameter)=0]"
			[Register ("getRssi", "()Ljava/lang/Double;", "GetGetRssiHandler")]
			get {
				const string __id = "getRssi.()Ljava/lang/Double;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.fissoft.beacon']/class[@name='Beacon']/method[@name='setRssi' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setRssi", "(Ljava/lang/Double;)V", "GetSetRssi_Ljava_lang_Double_Handler")]
			set {
				const string __id = "setRssi.(Ljava/lang/Double;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

	}
}
