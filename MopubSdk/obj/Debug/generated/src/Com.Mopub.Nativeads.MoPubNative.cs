using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubNative']"
	[global::Android.Runtime.Register ("com/mopub/nativeads/MoPubNative", DoNotGenerateAcw=true)]
	public partial class MoPubNative : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='MoPubNative.MoPubNativeNetworkListener']"
		[Register ("com/mopub/nativeads/MoPubNative$MoPubNativeNetworkListener", "", "Com.Mopub.Nativeads.MoPubNative/IMoPubNativeNetworkListenerInvoker")]
		public partial interface IMoPubNativeNetworkListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='MoPubNative.MoPubNativeNetworkListener']/method[@name='onNativeFail' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.NativeErrorCode']]"
			[Register ("onNativeFail", "(Lcom/mopub/nativeads/NativeErrorCode;)V", "GetOnNativeFail_Lcom_mopub_nativeads_NativeErrorCode_Handler:Com.Mopub.Nativeads.MoPubNative/IMoPubNativeNetworkListenerInvoker, MopubSdk")]
			void OnNativeFail (global::Com.Mopub.Nativeads.NativeErrorCode p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='MoPubNative.MoPubNativeNetworkListener']/method[@name='onNativeLoad' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.NativeAd']]"
			[Register ("onNativeLoad", "(Lcom/mopub/nativeads/NativeAd;)V", "GetOnNativeLoad_Lcom_mopub_nativeads_NativeAd_Handler:Com.Mopub.Nativeads.MoPubNative/IMoPubNativeNetworkListenerInvoker, MopubSdk")]
			void OnNativeLoad (global::Com.Mopub.Nativeads.NativeAd p0);

		}

		[global::Android.Runtime.Register ("com/mopub/nativeads/MoPubNative$MoPubNativeNetworkListener", DoNotGenerateAcw=true)]
		internal class IMoPubNativeNetworkListenerInvoker : global::Java.Lang.Object, IMoPubNativeNetworkListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/nativeads/MoPubNative$MoPubNativeNetworkListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IMoPubNativeNetworkListenerInvoker); }
			}

			IntPtr class_ref;

			public static IMoPubNativeNetworkListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMoPubNativeNetworkListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.nativeads.MoPubNative.MoPubNativeNetworkListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMoPubNativeNetworkListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onNativeFail_Lcom_mopub_nativeads_NativeErrorCode_;
#pragma warning disable 0169
			static Delegate GetOnNativeFail_Lcom_mopub_nativeads_NativeErrorCode_Handler ()
			{
				if (cb_onNativeFail_Lcom_mopub_nativeads_NativeErrorCode_ == null)
					cb_onNativeFail_Lcom_mopub_nativeads_NativeErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNativeFail_Lcom_mopub_nativeads_NativeErrorCode_);
				return cb_onNativeFail_Lcom_mopub_nativeads_NativeErrorCode_;
			}

			static void n_OnNativeFail_Lcom_mopub_nativeads_NativeErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Nativeads.MoPubNative.IMoPubNativeNetworkListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubNative.IMoPubNativeNetworkListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Nativeads.NativeErrorCode p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnNativeFail (p0);
			}
#pragma warning restore 0169

			IntPtr id_onNativeFail_Lcom_mopub_nativeads_NativeErrorCode_;
			public unsafe void OnNativeFail (global::Com.Mopub.Nativeads.NativeErrorCode p0)
			{
				if (id_onNativeFail_Lcom_mopub_nativeads_NativeErrorCode_ == IntPtr.Zero)
					id_onNativeFail_Lcom_mopub_nativeads_NativeErrorCode_ = JNIEnv.GetMethodID (class_ref, "onNativeFail", "(Lcom/mopub/nativeads/NativeErrorCode;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeFail_Lcom_mopub_nativeads_NativeErrorCode_, __args);
			}

			static Delegate cb_onNativeLoad_Lcom_mopub_nativeads_NativeAd_;
#pragma warning disable 0169
			static Delegate GetOnNativeLoad_Lcom_mopub_nativeads_NativeAd_Handler ()
			{
				if (cb_onNativeLoad_Lcom_mopub_nativeads_NativeAd_ == null)
					cb_onNativeLoad_Lcom_mopub_nativeads_NativeAd_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNativeLoad_Lcom_mopub_nativeads_NativeAd_);
				return cb_onNativeLoad_Lcom_mopub_nativeads_NativeAd_;
			}

			static void n_OnNativeLoad_Lcom_mopub_nativeads_NativeAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Nativeads.MoPubNative.IMoPubNativeNetworkListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubNative.IMoPubNativeNetworkListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Nativeads.NativeAd p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeAd> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnNativeLoad (p0);
			}
#pragma warning restore 0169

			IntPtr id_onNativeLoad_Lcom_mopub_nativeads_NativeAd_;
			public unsafe void OnNativeLoad (global::Com.Mopub.Nativeads.NativeAd p0)
			{
				if (id_onNativeLoad_Lcom_mopub_nativeads_NativeAd_ == IntPtr.Zero)
					id_onNativeLoad_Lcom_mopub_nativeads_NativeAd_ = JNIEnv.GetMethodID (class_ref, "onNativeLoad", "(Lcom/mopub/nativeads/NativeAd;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNativeLoad_Lcom_mopub_nativeads_NativeAd_, __args);
			}

		}

		// event args for com.mopub.nativeads.MoPubNative.MoPubNativeNetworkListener.onNativeFail
		public partial class NativeFailEventArgs : global::System.EventArgs {

			public NativeFailEventArgs (global::Com.Mopub.Nativeads.NativeErrorCode p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Nativeads.NativeErrorCode p0;
			public global::Com.Mopub.Nativeads.NativeErrorCode P0 {
				get { return p0; }
			}
		}

		// event args for com.mopub.nativeads.MoPubNative.MoPubNativeNetworkListener.onNativeLoad
		public partial class NativeLoadEventArgs : global::System.EventArgs {

			public NativeLoadEventArgs (global::Com.Mopub.Nativeads.NativeAd p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Nativeads.NativeAd p0;
			public global::Com.Mopub.Nativeads.NativeAd P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/nativeads/MoPubNative_MoPubNativeNetworkListenerImplementor")]
		internal sealed partial class IMoPubNativeNetworkListenerImplementor : global::Java.Lang.Object, IMoPubNativeNetworkListener {

			object sender;

			public IMoPubNativeNetworkListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/nativeads/MoPubNative_MoPubNativeNetworkListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<NativeFailEventArgs> OnNativeFailHandler;
#pragma warning restore 0649

			public void OnNativeFail (global::Com.Mopub.Nativeads.NativeErrorCode p0)
			{
				var __h = OnNativeFailHandler;
				if (__h != null)
					__h (sender, new NativeFailEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<NativeLoadEventArgs> OnNativeLoadHandler;
#pragma warning restore 0649

			public void OnNativeLoad (global::Com.Mopub.Nativeads.NativeAd p0)
			{
				var __h = OnNativeLoadHandler;
				if (__h != null)
					__h (sender, new NativeLoadEventArgs (p0));
			}

			internal static bool __IsEmpty (IMoPubNativeNetworkListenerImplementor value)
			{
				return value.OnNativeFailHandler == null && value.OnNativeLoadHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/nativeads/MoPubNative", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubNative); }
		}

		protected MoPubNative (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_Ljava_lang_String_Lcom_mopub_nativeads_MoPubNative_MoPubNativeNetworkListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubNative']/constructor[@name='MoPubNative' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.mopub.nativeads.MoPubNative.MoPubNativeNetworkListener']]"
		[Register (".ctor", "(Landroid/app/Activity;Ljava/lang/String;Lcom/mopub/nativeads/MoPubNative$MoPubNativeNetworkListener;)V", "")]
		public unsafe MoPubNative (global::Android.App.Activity p0, string p1, global::Com.Mopub.Nativeads.MoPubNative.IMoPubNativeNetworkListener p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (MoPubNative)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/app/Activity;Ljava/lang/String;Lcom/mopub/nativeads/MoPubNative$MoPubNativeNetworkListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;Ljava/lang/String;Lcom/mopub/nativeads/MoPubNative$MoPubNativeNetworkListener;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_Ljava_lang_String_Lcom_mopub_nativeads_MoPubNative_MoPubNativeNetworkListener_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_Ljava_lang_String_Lcom_mopub_nativeads_MoPubNative_MoPubNativeNetworkListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Ljava/lang/String;Lcom/mopub/nativeads/MoPubNative$MoPubNativeNetworkListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_Ljava_lang_String_Lcom_mopub_nativeads_MoPubNative_MoPubNativeNetworkListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_Ljava_lang_String_Lcom_mopub_nativeads_MoPubNative_MoPubNativeNetworkListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Landroid_app_Activity_Ljava_lang_String_Lcom_mopub_nativeads_AdRendererRegistry_Lcom_mopub_nativeads_MoPubNative_MoPubNativeNetworkListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubNative']/constructor[@name='MoPubNative' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.mopub.nativeads.AdRendererRegistry'] and parameter[4][@type='com.mopub.nativeads.MoPubNative.MoPubNativeNetworkListener']]"
		[Register (".ctor", "(Landroid/app/Activity;Ljava/lang/String;Lcom/mopub/nativeads/AdRendererRegistry;Lcom/mopub/nativeads/MoPubNative$MoPubNativeNetworkListener;)V", "")]
		public unsafe MoPubNative (global::Android.App.Activity p0, string p1, global::Com.Mopub.Nativeads.AdRendererRegistry p2, global::Com.Mopub.Nativeads.MoPubNative.IMoPubNativeNetworkListener p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (MoPubNative)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/app/Activity;Ljava/lang/String;Lcom/mopub/nativeads/AdRendererRegistry;Lcom/mopub/nativeads/MoPubNative$MoPubNativeNetworkListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;Ljava/lang/String;Lcom/mopub/nativeads/AdRendererRegistry;Lcom/mopub/nativeads/MoPubNative$MoPubNativeNetworkListener;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_Ljava_lang_String_Lcom_mopub_nativeads_AdRendererRegistry_Lcom_mopub_nativeads_MoPubNative_MoPubNativeNetworkListener_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_Ljava_lang_String_Lcom_mopub_nativeads_AdRendererRegistry_Lcom_mopub_nativeads_MoPubNative_MoPubNativeNetworkListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Ljava/lang/String;Lcom/mopub/nativeads/AdRendererRegistry;Lcom/mopub/nativeads/MoPubNative$MoPubNativeNetworkListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_Ljava_lang_String_Lcom_mopub_nativeads_AdRendererRegistry_Lcom_mopub_nativeads_MoPubNative_MoPubNativeNetworkListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_Ljava_lang_String_Lcom_mopub_nativeads_AdRendererRegistry_Lcom_mopub_nativeads_MoPubNative_MoPubNativeNetworkListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.MoPubNative __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubNative']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroy", "()V"));
			} finally {
			}
		}

		static Delegate cb_makeRequest;
#pragma warning disable 0169
		static Delegate GetMakeRequestHandler ()
		{
			if (cb_makeRequest == null)
				cb_makeRequest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_MakeRequest);
			return cb_makeRequest;
		}

		static void n_MakeRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.MoPubNative __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MakeRequest ();
		}
#pragma warning restore 0169

		static IntPtr id_makeRequest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubNative']/method[@name='makeRequest' and count(parameter)=0]"
		[Register ("makeRequest", "()V", "GetMakeRequestHandler")]
		public virtual unsafe void MakeRequest ()
		{
			if (id_makeRequest == IntPtr.Zero)
				id_makeRequest = JNIEnv.GetMethodID (class_ref, "makeRequest", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_makeRequest);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "makeRequest", "()V"));
			} finally {
			}
		}

		static Delegate cb_makeRequest_Lcom_mopub_nativeads_RequestParameters_;
#pragma warning disable 0169
		static Delegate GetMakeRequest_Lcom_mopub_nativeads_RequestParameters_Handler ()
		{
			if (cb_makeRequest_Lcom_mopub_nativeads_RequestParameters_ == null)
				cb_makeRequest_Lcom_mopub_nativeads_RequestParameters_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MakeRequest_Lcom_mopub_nativeads_RequestParameters_);
			return cb_makeRequest_Lcom_mopub_nativeads_RequestParameters_;
		}

		static void n_MakeRequest_Lcom_mopub_nativeads_RequestParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.MoPubNative __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.RequestParameters p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.RequestParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MakeRequest (p0);
		}
#pragma warning restore 0169

		static IntPtr id_makeRequest_Lcom_mopub_nativeads_RequestParameters_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubNative']/method[@name='makeRequest' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.RequestParameters']]"
		[Register ("makeRequest", "(Lcom/mopub/nativeads/RequestParameters;)V", "GetMakeRequest_Lcom_mopub_nativeads_RequestParameters_Handler")]
		public virtual unsafe void MakeRequest (global::Com.Mopub.Nativeads.RequestParameters p0)
		{
			if (id_makeRequest_Lcom_mopub_nativeads_RequestParameters_ == IntPtr.Zero)
				id_makeRequest_Lcom_mopub_nativeads_RequestParameters_ = JNIEnv.GetMethodID (class_ref, "makeRequest", "(Lcom/mopub/nativeads/RequestParameters;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_makeRequest_Lcom_mopub_nativeads_RequestParameters_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "makeRequest", "(Lcom/mopub/nativeads/RequestParameters;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_makeRequest_Lcom_mopub_nativeads_RequestParameters_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetMakeRequest_Lcom_mopub_nativeads_RequestParameters_Ljava_lang_Integer_Handler ()
		{
			if (cb_makeRequest_Lcom_mopub_nativeads_RequestParameters_Ljava_lang_Integer_ == null)
				cb_makeRequest_Lcom_mopub_nativeads_RequestParameters_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MakeRequest_Lcom_mopub_nativeads_RequestParameters_Ljava_lang_Integer_);
			return cb_makeRequest_Lcom_mopub_nativeads_RequestParameters_Ljava_lang_Integer_;
		}

		static void n_MakeRequest_Lcom_mopub_nativeads_RequestParameters_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Nativeads.MoPubNative __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.RequestParameters p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.RequestParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.MakeRequest (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_makeRequest_Lcom_mopub_nativeads_RequestParameters_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubNative']/method[@name='makeRequest' and count(parameter)=2 and parameter[1][@type='com.mopub.nativeads.RequestParameters'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("makeRequest", "(Lcom/mopub/nativeads/RequestParameters;Ljava/lang/Integer;)V", "GetMakeRequest_Lcom_mopub_nativeads_RequestParameters_Ljava_lang_Integer_Handler")]
		public virtual unsafe void MakeRequest (global::Com.Mopub.Nativeads.RequestParameters p0, global::Java.Lang.Integer p1)
		{
			if (id_makeRequest_Lcom_mopub_nativeads_RequestParameters_Ljava_lang_Integer_ == IntPtr.Zero)
				id_makeRequest_Lcom_mopub_nativeads_RequestParameters_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "makeRequest", "(Lcom/mopub/nativeads/RequestParameters;Ljava/lang/Integer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_makeRequest_Lcom_mopub_nativeads_RequestParameters_Ljava_lang_Integer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "makeRequest", "(Lcom/mopub/nativeads/RequestParameters;Ljava/lang/Integer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_;
#pragma warning disable 0169
		static Delegate GetRegisterAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_Handler ()
		{
			if (cb_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_ == null)
				cb_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_);
			return cb_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_;
		}

		static void n_RegisterAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.MoPubNative __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.IMoPubAdRenderer p0 = (global::Com.Mopub.Nativeads.IMoPubAdRenderer)global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IMoPubAdRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterAdRenderer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubNative']/method[@name='registerAdRenderer' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.MoPubAdRenderer']]"
		[Register ("registerAdRenderer", "(Lcom/mopub/nativeads/MoPubAdRenderer;)V", "GetRegisterAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_Handler")]
		public virtual unsafe void RegisterAdRenderer (global::Com.Mopub.Nativeads.IMoPubAdRenderer p0)
		{
			if (id_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_ == IntPtr.Zero)
				id_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_ = JNIEnv.GetMethodID (class_ref, "registerAdRenderer", "(Lcom/mopub/nativeads/MoPubAdRenderer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerAdRenderer", "(Lcom/mopub/nativeads/MoPubAdRenderer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setLocalExtras_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetLocalExtras_Ljava_util_Map_Handler ()
		{
			if (cb_setLocalExtras_Ljava_util_Map_ == null)
				cb_setLocalExtras_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocalExtras_Ljava_util_Map_);
			return cb_setLocalExtras_Ljava_util_Map_;
		}

		static void n_SetLocalExtras_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.MoPubNative __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLocalExtras (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLocalExtras_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubNative']/method[@name='setLocalExtras' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("setLocalExtras", "(Ljava/util/Map;)V", "GetSetLocalExtras_Ljava_util_Map_Handler")]
		public virtual unsafe void SetLocalExtras (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_setLocalExtras_Ljava_util_Map_ == IntPtr.Zero)
				id_setLocalExtras_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setLocalExtras", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocalExtras_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocalExtras", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
