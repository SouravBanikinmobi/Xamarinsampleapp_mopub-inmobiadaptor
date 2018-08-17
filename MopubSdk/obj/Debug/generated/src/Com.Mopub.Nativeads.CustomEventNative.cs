using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='CustomEventNative']"
	[global::Android.Runtime.Register ("com/mopub/nativeads/CustomEventNative", DoNotGenerateAcw=true)]
	public abstract partial class CustomEventNative : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='CustomEventNative.CustomEventNativeListener']"
		[Register ("com/mopub/nativeads/CustomEventNative$CustomEventNativeListener", "", "Com.Mopub.Nativeads.CustomEventNative/ICustomEventNativeListenerInvoker")]
		public partial interface ICustomEventNativeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='CustomEventNative.CustomEventNativeListener']/method[@name='onNativeAdFailed' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.NativeErrorCode']]"
			[Register ("onNativeAdFailed", "(Lcom/mopub/nativeads/NativeErrorCode;)V", "GetOnNativeAdFailed_Lcom_mopub_nativeads_NativeErrorCode_Handler:Com.Mopub.Nativeads.CustomEventNative/ICustomEventNativeListenerInvoker, MopubSdk")]
			void OnNativeAdFailed (global::Com.Mopub.Nativeads.NativeErrorCode p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='CustomEventNative.CustomEventNativeListener']/method[@name='onNativeAdLoaded' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.BaseNativeAd']]"
			[Register ("onNativeAdLoaded", "(Lcom/mopub/nativeads/BaseNativeAd;)V", "GetOnNativeAdLoaded_Lcom_mopub_nativeads_BaseNativeAd_Handler:Com.Mopub.Nativeads.CustomEventNative/ICustomEventNativeListenerInvoker, MopubSdk")]
			void OnNativeAdLoaded (global::Com.Mopub.Nativeads.BaseNativeAd p0);

		}

		[global::Android.Runtime.Register ("com/mopub/nativeads/CustomEventNative$CustomEventNativeListener", DoNotGenerateAcw=true)]
		internal class ICustomEventNativeListenerInvoker : global::Java.Lang.Object, ICustomEventNativeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/nativeads/CustomEventNative$CustomEventNativeListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICustomEventNativeListenerInvoker); }
			}

			IntPtr class_ref;

			public static ICustomEventNativeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICustomEventNativeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.nativeads.CustomEventNative.CustomEventNativeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICustomEventNativeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onNativeAdFailed_Lcom_mopub_nativeads_NativeErrorCode_;
#pragma warning disable 0169
			static Delegate GetOnNativeAdFailed_Lcom_mopub_nativeads_NativeErrorCode_Handler ()
			{
				if (cb_onNativeAdFailed_Lcom_mopub_nativeads_NativeErrorCode_ == null)
					cb_onNativeAdFailed_Lcom_mopub_nativeads_NativeErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNativeAdFailed_Lcom_mopub_nativeads_NativeErrorCode_);
				return cb_onNativeAdFailed_Lcom_mopub_nativeads_NativeErrorCode_;
			}

			static void n_OnNativeAdFailed_Lcom_mopub_nativeads_NativeErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Nativeads.CustomEventNative.ICustomEventNativeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.CustomEventNative.ICustomEventNativeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Nativeads.NativeErrorCode p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnNativeAdFailed (p0);
			}
#pragma warning restore 0169

			IntPtr id_onNativeAdFailed_Lcom_mopub_nativeads_NativeErrorCode_;
			public unsafe void OnNativeAdFailed (global::Com.Mopub.Nativeads.NativeErrorCode p0)
			{
				if (id_onNativeAdFailed_Lcom_mopub_nativeads_NativeErrorCode_ == IntPtr.Zero)
					id_onNativeAdFailed_Lcom_mopub_nativeads_NativeErrorCode_ = JNIEnv.GetMethodID (class_ref, "onNativeAdFailed", "(Lcom/mopub/nativeads/NativeErrorCode;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeAdFailed_Lcom_mopub_nativeads_NativeErrorCode_, __args);
			}

			static Delegate cb_onNativeAdLoaded_Lcom_mopub_nativeads_BaseNativeAd_;
#pragma warning disable 0169
			static Delegate GetOnNativeAdLoaded_Lcom_mopub_nativeads_BaseNativeAd_Handler ()
			{
				if (cb_onNativeAdLoaded_Lcom_mopub_nativeads_BaseNativeAd_ == null)
					cb_onNativeAdLoaded_Lcom_mopub_nativeads_BaseNativeAd_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNativeAdLoaded_Lcom_mopub_nativeads_BaseNativeAd_);
				return cb_onNativeAdLoaded_Lcom_mopub_nativeads_BaseNativeAd_;
			}

			static void n_OnNativeAdLoaded_Lcom_mopub_nativeads_BaseNativeAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Nativeads.CustomEventNative.ICustomEventNativeListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.CustomEventNative.ICustomEventNativeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Nativeads.BaseNativeAd p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.BaseNativeAd> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnNativeAdLoaded (p0);
			}
#pragma warning restore 0169

			IntPtr id_onNativeAdLoaded_Lcom_mopub_nativeads_BaseNativeAd_;
			public unsafe void OnNativeAdLoaded (global::Com.Mopub.Nativeads.BaseNativeAd p0)
			{
				if (id_onNativeAdLoaded_Lcom_mopub_nativeads_BaseNativeAd_ == IntPtr.Zero)
					id_onNativeAdLoaded_Lcom_mopub_nativeads_BaseNativeAd_ = JNIEnv.GetMethodID (class_ref, "onNativeAdLoaded", "(Lcom/mopub/nativeads/BaseNativeAd;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeAdLoaded_Lcom_mopub_nativeads_BaseNativeAd_, __args);
			}

		}

		// event args for com.mopub.nativeads.CustomEventNative.CustomEventNativeListener.onNativeAdFailed
		public partial class NativeAdFailedEventArgs : global::System.EventArgs {

			public NativeAdFailedEventArgs (global::Com.Mopub.Nativeads.NativeErrorCode p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Nativeads.NativeErrorCode p0;
			public global::Com.Mopub.Nativeads.NativeErrorCode P0 {
				get { return p0; }
			}
		}

		// event args for com.mopub.nativeads.CustomEventNative.CustomEventNativeListener.onNativeAdLoaded
		public partial class NativeAdLoadedEventArgs : global::System.EventArgs {

			public NativeAdLoadedEventArgs (global::Com.Mopub.Nativeads.BaseNativeAd p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Nativeads.BaseNativeAd p0;
			public global::Com.Mopub.Nativeads.BaseNativeAd P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/nativeads/CustomEventNative_CustomEventNativeListenerImplementor")]
		internal sealed partial class ICustomEventNativeListenerImplementor : global::Java.Lang.Object, ICustomEventNativeListener {

			object sender;

			public ICustomEventNativeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/nativeads/CustomEventNative_CustomEventNativeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<NativeAdFailedEventArgs> OnNativeAdFailedHandler;
#pragma warning restore 0649

			public void OnNativeAdFailed (global::Com.Mopub.Nativeads.NativeErrorCode p0)
			{
				var __h = OnNativeAdFailedHandler;
				if (__h != null)
					__h (sender, new NativeAdFailedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<NativeAdLoadedEventArgs> OnNativeAdLoadedHandler;
#pragma warning restore 0649

			public void OnNativeAdLoaded (global::Com.Mopub.Nativeads.BaseNativeAd p0)
			{
				var __h = OnNativeAdLoadedHandler;
				if (__h != null)
					__h (sender, new NativeAdLoadedEventArgs (p0));
			}

			internal static bool __IsEmpty (ICustomEventNativeListenerImplementor value)
			{
				return value.OnNativeAdFailedHandler == null && value.OnNativeAdLoadedHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/nativeads/CustomEventNative", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomEventNative); }
		}

		protected CustomEventNative (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='CustomEventNative']/constructor[@name='CustomEventNative' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CustomEventNative ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CustomEventNative)) {
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

		static Delegate cb_loadNativeAd_Landroid_app_Activity_Lcom_mopub_nativeads_CustomEventNative_CustomEventNativeListener_Ljava_util_Map_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetloadNativeAd_Landroid_app_Activity_Lcom_mopub_nativeads_CustomEventNative_CustomEventNativeListener_Ljava_util_Map_Ljava_util_Map_Handler ()
		{
			if (cb_loadNativeAd_Landroid_app_Activity_Lcom_mopub_nativeads_CustomEventNative_CustomEventNativeListener_Ljava_util_Map_Ljava_util_Map_ == null)
				cb_loadNativeAd_Landroid_app_Activity_Lcom_mopub_nativeads_CustomEventNative_CustomEventNativeListener_Ljava_util_Map_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_loadNativeAd_Landroid_app_Activity_Lcom_mopub_nativeads_CustomEventNative_CustomEventNativeListener_Ljava_util_Map_Ljava_util_Map_);
			return cb_loadNativeAd_Landroid_app_Activity_Lcom_mopub_nativeads_CustomEventNative_CustomEventNativeListener_Ljava_util_Map_Ljava_util_Map_;
		}

		static void n_loadNativeAd_Landroid_app_Activity_Lcom_mopub_nativeads_CustomEventNative_CustomEventNativeListener_Ljava_util_Map_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Mopub.Nativeads.CustomEventNative __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.CustomEventNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.CustomEventNative.ICustomEventNativeListener p1 = (global::Com.Mopub.Nativeads.CustomEventNative.ICustomEventNativeListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.CustomEventNative.ICustomEventNativeListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.loadNativeAd (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='CustomEventNative']/method[@name='loadNativeAd' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.mopub.nativeads.CustomEventNative.CustomEventNativeListener'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("loadNativeAd", "(Landroid/app/Activity;Lcom/mopub/nativeads/CustomEventNative$CustomEventNativeListener;Ljava/util/Map;Ljava/util/Map;)V", "GetloadNativeAd_Landroid_app_Activity_Lcom_mopub_nativeads_CustomEventNative_CustomEventNativeListener_Ljava_util_Map_Ljava_util_Map_Handler")]
		protected abstract void loadNativeAd (global::Android.App.Activity p0, global::Com.Mopub.Nativeads.CustomEventNative.ICustomEventNativeListener p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2, global::System.Collections.Generic.IDictionary<string, string> p3);

	}

	[global::Android.Runtime.Register ("com/mopub/nativeads/CustomEventNative", DoNotGenerateAcw=true)]
	internal partial class CustomEventNativeInvoker : CustomEventNative {

		public CustomEventNativeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomEventNativeInvoker); }
		}

		static IntPtr id_loadNativeAd_Landroid_app_Activity_Lcom_mopub_nativeads_CustomEventNative_CustomEventNativeListener_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='CustomEventNative']/method[@name='loadNativeAd' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.mopub.nativeads.CustomEventNative.CustomEventNativeListener'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("loadNativeAd", "(Landroid/app/Activity;Lcom/mopub/nativeads/CustomEventNative$CustomEventNativeListener;Ljava/util/Map;Ljava/util/Map;)V", "GetloadNativeAd_Landroid_app_Activity_Lcom_mopub_nativeads_CustomEventNative_CustomEventNativeListener_Ljava_util_Map_Ljava_util_Map_Handler")]
		protected override unsafe void loadNativeAd (global::Android.App.Activity p0, global::Com.Mopub.Nativeads.CustomEventNative.ICustomEventNativeListener p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2, global::System.Collections.Generic.IDictionary<string, string> p3)
		{
			if (id_loadNativeAd_Landroid_app_Activity_Lcom_mopub_nativeads_CustomEventNative_CustomEventNativeListener_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_loadNativeAd_Landroid_app_Activity_Lcom_mopub_nativeads_CustomEventNative_CustomEventNativeListener_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "loadNativeAd", "(Landroid/app/Activity;Lcom/mopub/nativeads/CustomEventNative$CustomEventNativeListener;Ljava/util/Map;Ljava/util/Map;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadNativeAd_Landroid_app_Activity_Lcom_mopub_nativeads_CustomEventNative_CustomEventNativeListener_Ljava_util_Map_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}

}
