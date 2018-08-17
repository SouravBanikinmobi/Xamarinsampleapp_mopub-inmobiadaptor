using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.mopub.mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/CustomEventRewardedVideo", DoNotGenerateAcw=true)]
	public abstract partial class CustomEventRewardedVideo : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/CustomEventRewardedVideo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomEventRewardedVideo); }
		}

		protected CustomEventRewardedVideo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/constructor[@name='CustomEventRewardedVideo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CustomEventRewardedVideo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CustomEventRewardedVideo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getAdNetworkId;
#pragma warning disable 0169
		static Delegate GetGetAdNetworkIdHandler ()
		{
			if (cb_getAdNetworkId == null)
				cb_getAdNetworkId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdNetworkId);
			return cb_getAdNetworkId;
		}

		static IntPtr n_GetAdNetworkId (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.CustomEventRewardedVideo __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.CustomEventRewardedVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdNetworkId);
		}
#pragma warning restore 0169

		protected abstract string AdNetworkId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='getAdNetworkId' and count(parameter)=0]"
			[Register ("getAdNetworkId", "()Ljava/lang/String;", "GetGetAdNetworkIdHandler")] get;
		}

		static Delegate cb_hasVideoAvailable;
#pragma warning disable 0169
		static Delegate GetHasVideoAvailableHandler ()
		{
			if (cb_hasVideoAvailable == null)
				cb_hasVideoAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasVideoAvailable);
			return cb_hasVideoAvailable;
		}

		static bool n_HasVideoAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.CustomEventRewardedVideo __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.CustomEventRewardedVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasVideoAvailable;
		}
#pragma warning restore 0169

		protected abstract bool HasVideoAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='hasVideoAvailable' and count(parameter)=0]"
			[Register ("hasVideoAvailable", "()Z", "GetHasVideoAvailableHandler")] get;
		}

		static Delegate cb_getLifecycleListener;
#pragma warning disable 0169
		static Delegate GetGetLifecycleListenerHandler ()
		{
			if (cb_getLifecycleListener == null)
				cb_getLifecycleListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLifecycleListener);
			return cb_getLifecycleListener;
		}

		static IntPtr n_GetLifecycleListener (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.CustomEventRewardedVideo __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.CustomEventRewardedVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LifecycleListener);
		}
#pragma warning restore 0169

		protected abstract global::com.mopub.common.ILifecycleListener LifecycleListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='getLifecycleListener' and count(parameter)=0]"
			[Register ("getLifecycleListener", "()Lcom/mopub/common/LifecycleListener;", "GetGetLifecycleListenerHandler")] get;
		}

		static Delegate cb_checkAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetCheckAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_Handler ()
		{
			if (cb_checkAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_ == null)
				cb_checkAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_CheckAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_);
			return cb_checkAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_;
		}

		static bool n_CheckAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::com.mopub.mobileads.CustomEventRewardedVideo __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.CustomEventRewardedVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CheckAndInitializeSdk (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='checkAndInitializeSdk' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("checkAndInitializeSdk", "(Landroid/app/Activity;Ljava/util/Map;Ljava/util/Map;)Z", "GetCheckAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_Handler")]
		protected abstract bool CheckAndInitializeSdk (global::Android.App.Activity p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1, global::System.Collections.Generic.IDictionary<string, string> p2);

		static Delegate cb_loadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetLoadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_Handler ()
		{
			if (cb_loadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_ == null)
				cb_loadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_);
			return cb_loadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_;
		}

		static void n_LoadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::com.mopub.mobileads.CustomEventRewardedVideo __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.CustomEventRewardedVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.LoadWithSdkInitialized (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='loadWithSdkInitialized' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("loadWithSdkInitialized", "(Landroid/app/Activity;Ljava/util/Map;Ljava/util/Map;)V", "GetLoadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_Handler")]
		protected abstract void LoadWithSdkInitialized (global::Android.App.Activity p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1, global::System.Collections.Generic.IDictionary<string, string> p2);

		static Delegate cb_onInvalidate;
#pragma warning disable 0169
		static Delegate GetOnInvalidateHandler ()
		{
			if (cb_onInvalidate == null)
				cb_onInvalidate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInvalidate);
			return cb_onInvalidate;
		}

		static void n_OnInvalidate (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.CustomEventRewardedVideo __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.CustomEventRewardedVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInvalidate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='onInvalidate' and count(parameter)=0]"
		[Register ("onInvalidate", "()V", "GetOnInvalidateHandler")]
		protected abstract void OnInvalidate ();

		static Delegate cb_showVideo;
#pragma warning disable 0169
		static Delegate GetShowVideoHandler ()
		{
			if (cb_showVideo == null)
				cb_showVideo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowVideo);
			return cb_showVideo;
		}

		static void n_ShowVideo (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.CustomEventRewardedVideo __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.CustomEventRewardedVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowVideo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='showVideo' and count(parameter)=0]"
		[Register ("showVideo", "()V", "GetShowVideoHandler")]
		protected abstract void ShowVideo ();

	}

	[global::Android.Runtime.Register ("com/mopub/mobileads/CustomEventRewardedVideo", DoNotGenerateAcw=true)]
	internal partial class CustomEventRewardedVideoInvoker : CustomEventRewardedVideo {

		public CustomEventRewardedVideoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomEventRewardedVideoInvoker); }
		}

		static IntPtr id_getAdNetworkId;
		protected override unsafe string AdNetworkId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='getAdNetworkId' and count(parameter)=0]"
			[Register ("getAdNetworkId", "()Ljava/lang/String;", "GetGetAdNetworkIdHandler")]
			get {
				if (id_getAdNetworkId == IntPtr.Zero)
					id_getAdNetworkId = JNIEnv.GetMethodID (class_ref, "getAdNetworkId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdNetworkId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_hasVideoAvailable;
		protected override unsafe bool HasVideoAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='hasVideoAvailable' and count(parameter)=0]"
			[Register ("hasVideoAvailable", "()Z", "GetHasVideoAvailableHandler")]
			get {
				if (id_hasVideoAvailable == IntPtr.Zero)
					id_hasVideoAvailable = JNIEnv.GetMethodID (class_ref, "hasVideoAvailable", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasVideoAvailable);
				} finally {
				}
			}
		}

		static IntPtr id_getLifecycleListener;
		protected override unsafe global::com.mopub.common.ILifecycleListener LifecycleListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='getLifecycleListener' and count(parameter)=0]"
			[Register ("getLifecycleListener", "()Lcom/mopub/common/LifecycleListener;", "GetGetLifecycleListenerHandler")]
			get {
				if (id_getLifecycleListener == IntPtr.Zero)
					id_getLifecycleListener = JNIEnv.GetMethodID (class_ref, "getLifecycleListener", "()Lcom/mopub/common/LifecycleListener;");
				try {
					return global::Java.Lang.Object.GetObject<global::com.mopub.common.ILifecycleListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLifecycleListener), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_checkAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='checkAndInitializeSdk' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("checkAndInitializeSdk", "(Landroid/app/Activity;Ljava/util/Map;Ljava/util/Map;)Z", "GetCheckAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_Handler")]
		protected override unsafe bool CheckAndInitializeSdk (global::Android.App.Activity p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			if (id_checkAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_checkAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "checkAndInitializeSdk", "(Landroid/app/Activity;Ljava/util/Map;Ljava/util/Map;)Z");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_checkAndInitializeSdk_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_loadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='loadWithSdkInitialized' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("loadWithSdkInitialized", "(Landroid/app/Activity;Ljava/util/Map;Ljava/util/Map;)V", "GetLoadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_Handler")]
		protected override unsafe void LoadWithSdkInitialized (global::Android.App.Activity p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			if (id_loadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_loadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "loadWithSdkInitialized", "(Landroid/app/Activity;Ljava/util/Map;Ljava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadWithSdkInitialized_Landroid_app_Activity_Ljava_util_Map_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_onInvalidate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='onInvalidate' and count(parameter)=0]"
		[Register ("onInvalidate", "()V", "GetOnInvalidateHandler")]
		protected override unsafe void OnInvalidate ()
		{
			if (id_onInvalidate == IntPtr.Zero)
				id_onInvalidate = JNIEnv.GetMethodID (class_ref, "onInvalidate", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInvalidate);
			} finally {
			}
		}

		static IntPtr id_showVideo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventRewardedVideo']/method[@name='showVideo' and count(parameter)=0]"
		[Register ("showVideo", "()V", "GetShowVideoHandler")]
		protected override unsafe void ShowVideo ()
		{
			if (id_showVideo == IntPtr.Zero)
				id_showVideo = JNIEnv.GetMethodID (class_ref, "showVideo", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showVideo);
			} finally {
			}
		}

	}

}
