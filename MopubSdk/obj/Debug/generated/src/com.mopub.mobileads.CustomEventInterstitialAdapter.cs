using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.mopub.mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitialAdapter']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/CustomEventInterstitialAdapter", DoNotGenerateAcw=true)]
	public partial class CustomEventInterstitialAdapter : global::Java.Lang.Object, global::com.mopub.mobileads.CustomEventInterstitial.ICustomEventInterstitialListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitialAdapter']/field[@name='DEFAULT_INTERSTITIAL_TIMEOUT_DELAY']"
		[Register ("DEFAULT_INTERSTITIAL_TIMEOUT_DELAY")]
		public const int DefaultInterstitialTimeoutDelay = (int) 30000;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/CustomEventInterstitialAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomEventInterstitialAdapter); }
		}

		protected CustomEventInterstitialAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitialAdapter']/constructor[@name='CustomEventInterstitialAdapter' and count(parameter)=5 and parameter[1][@type='com.mopub.mobileads.MoPubInterstitial'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[4][@type='long'] and parameter[5][@type='com.mopub.common.AdReport']]"
		[Register (".ctor", "(Lcom/mopub/mobileads/MoPubInterstitial;Ljava/lang/String;Ljava/util/Map;JLcom/mopub/common/AdReport;)V", "")]
		public unsafe CustomEventInterstitialAdapter (global::com.mopub.mobileads.MoPubInterstitial p0, string p1, global::System.Collections.Generic.IDictionary<string, string> p2, long p3, global::com.mopub.common.AdReport p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (CustomEventInterstitialAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/mopub/mobileads/MoPubInterstitial;Ljava/lang/String;Ljava/util/Map;JLcom/mopub/common/AdReport;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/mopub/mobileads/MoPubInterstitial;Ljava/lang/String;Ljava/util/Map;JLcom/mopub/common/AdReport;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/mobileads/MoPubInterstitial;Ljava/lang/String;Ljava/util/Map;JLcom/mopub/common/AdReport;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mopub_mobileads_MoPubInterstitial_Ljava_lang_String_Ljava_util_Map_JLcom_mopub_common_AdReport_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_onInterstitialClicked;
#pragma warning disable 0169
		static Delegate GetOnInterstitialClickedHandler ()
		{
			if (cb_onInterstitialClicked == null)
				cb_onInterstitialClicked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialClicked);
			return cb_onInterstitialClicked;
		}

		static void n_OnInterstitialClicked (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.CustomEventInterstitialAdapter __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.CustomEventInterstitialAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialClicked ();
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialClicked;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitialAdapter']/method[@name='onInterstitialClicked' and count(parameter)=0]"
		[Register ("onInterstitialClicked", "()V", "GetOnInterstitialClickedHandler")]
		public virtual unsafe void OnInterstitialClicked ()
		{
			if (id_onInterstitialClicked == IntPtr.Zero)
				id_onInterstitialClicked = JNIEnv.GetMethodID (class_ref, "onInterstitialClicked", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialClicked);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialClicked", "()V"));
			} finally {
			}
		}

		static Delegate cb_onInterstitialDismissed;
#pragma warning disable 0169
		static Delegate GetOnInterstitialDismissedHandler ()
		{
			if (cb_onInterstitialDismissed == null)
				cb_onInterstitialDismissed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialDismissed);
			return cb_onInterstitialDismissed;
		}

		static void n_OnInterstitialDismissed (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.CustomEventInterstitialAdapter __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.CustomEventInterstitialAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialDismissed ();
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialDismissed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitialAdapter']/method[@name='onInterstitialDismissed' and count(parameter)=0]"
		[Register ("onInterstitialDismissed", "()V", "GetOnInterstitialDismissedHandler")]
		public virtual unsafe void OnInterstitialDismissed ()
		{
			if (id_onInterstitialDismissed == IntPtr.Zero)
				id_onInterstitialDismissed = JNIEnv.GetMethodID (class_ref, "onInterstitialDismissed", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialDismissed);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialDismissed", "()V"));
			} finally {
			}
		}

		static Delegate cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
#pragma warning disable 0169
		static Delegate GetOnInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler ()
		{
			if (cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == null)
				cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_);
			return cb_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
		}

		static void n_OnInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::com.mopub.mobileads.CustomEventInterstitialAdapter __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.CustomEventInterstitialAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::com.mopub.mobileads.MoPubErrorCode p0 = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialFailed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitialAdapter']/method[@name='onInterstitialFailed' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubErrorCode']]"
		[Register ("onInterstitialFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetOnInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler")]
		public virtual unsafe void OnInterstitialFailed (global::com.mopub.mobileads.MoPubErrorCode p0)
		{
			if (id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
				id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "onInterstitialFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onInterstitialLoaded;
#pragma warning disable 0169
		static Delegate GetOnInterstitialLoadedHandler ()
		{
			if (cb_onInterstitialLoaded == null)
				cb_onInterstitialLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialLoaded);
			return cb_onInterstitialLoaded;
		}

		static void n_OnInterstitialLoaded (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.CustomEventInterstitialAdapter __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.CustomEventInterstitialAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialLoaded ();
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialLoaded;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitialAdapter']/method[@name='onInterstitialLoaded' and count(parameter)=0]"
		[Register ("onInterstitialLoaded", "()V", "GetOnInterstitialLoadedHandler")]
		public virtual unsafe void OnInterstitialLoaded ()
		{
			if (id_onInterstitialLoaded == IntPtr.Zero)
				id_onInterstitialLoaded = JNIEnv.GetMethodID (class_ref, "onInterstitialLoaded", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialLoaded);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialLoaded", "()V"));
			} finally {
			}
		}

		static Delegate cb_onInterstitialShown;
#pragma warning disable 0169
		static Delegate GetOnInterstitialShownHandler ()
		{
			if (cb_onInterstitialShown == null)
				cb_onInterstitialShown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInterstitialShown);
			return cb_onInterstitialShown;
		}

		static void n_OnInterstitialShown (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.CustomEventInterstitialAdapter __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.CustomEventInterstitialAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInterstitialShown ();
		}
#pragma warning restore 0169

		static IntPtr id_onInterstitialShown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitialAdapter']/method[@name='onInterstitialShown' and count(parameter)=0]"
		[Register ("onInterstitialShown", "()V", "GetOnInterstitialShownHandler")]
		public virtual unsafe void OnInterstitialShown ()
		{
			if (id_onInterstitialShown == IntPtr.Zero)
				id_onInterstitialShown = JNIEnv.GetMethodID (class_ref, "onInterstitialShown", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInterstitialShown);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInterstitialShown", "()V"));
			} finally {
			}
		}

		static Delegate cb_onLeaveApplication;
#pragma warning disable 0169
		static Delegate GetOnLeaveApplicationHandler ()
		{
			if (cb_onLeaveApplication == null)
				cb_onLeaveApplication = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLeaveApplication);
			return cb_onLeaveApplication;
		}

		static void n_OnLeaveApplication (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.CustomEventInterstitialAdapter __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.CustomEventInterstitialAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLeaveApplication ();
		}
#pragma warning restore 0169

		static IntPtr id_onLeaveApplication;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='CustomEventInterstitialAdapter']/method[@name='onLeaveApplication' and count(parameter)=0]"
		[Register ("onLeaveApplication", "()V", "GetOnLeaveApplicationHandler")]
		public virtual unsafe void OnLeaveApplication ()
		{
			if (id_onLeaveApplication == IntPtr.Zero)
				id_onLeaveApplication = JNIEnv.GetMethodID (class_ref, "onLeaveApplication", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLeaveApplication);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLeaveApplication", "()V"));
			} finally {
			}
		}

	}
}
