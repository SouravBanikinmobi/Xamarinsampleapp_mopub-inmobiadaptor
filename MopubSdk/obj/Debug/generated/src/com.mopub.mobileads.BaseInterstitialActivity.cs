using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.mopub.mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/BaseInterstitialActivity", DoNotGenerateAcw=true)]
	public abstract partial class BaseInterstitialActivity : global::Android.App.Activity {


		static IntPtr mAdReport_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity']/field[@name='mAdReport']"
		[Register ("mAdReport")]
		protected global::com.mopub.common.AdReport MAdReport {
			get {
				if (mAdReport_jfieldId == IntPtr.Zero)
					mAdReport_jfieldId = JNIEnv.GetFieldID (class_ref, "mAdReport", "Lcom/mopub/common/AdReport;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAdReport_jfieldId);
				return global::Java.Lang.Object.GetObject<global::com.mopub.common.AdReport> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAdReport_jfieldId == IntPtr.Zero)
					mAdReport_jfieldId = JNIEnv.GetFieldID (class_ref, "mAdReport", "Lcom/mopub/common/AdReport;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAdReport_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity.JavaScriptWebViewCallbacks']"
		[global::Android.Runtime.Register ("com/mopub/mobileads/BaseInterstitialActivity$JavaScriptWebViewCallbacks", DoNotGenerateAcw=true)]
		public sealed partial class JavaScriptWebViewCallbacks : global::Java.Lang.Enum {


			static IntPtr WEB_VIEW_DID_APPEAR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity.JavaScriptWebViewCallbacks']/field[@name='WEB_VIEW_DID_APPEAR']"
			[Register ("WEB_VIEW_DID_APPEAR")]
			public static global::com.mopub.mobileads.BaseInterstitialActivity.JavaScriptWebViewCallbacks WebViewDidAppear {
				get {
					if (WEB_VIEW_DID_APPEAR_jfieldId == IntPtr.Zero)
						WEB_VIEW_DID_APPEAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEB_VIEW_DID_APPEAR", "Lcom/mopub/mobileads/BaseInterstitialActivity$JavaScriptWebViewCallbacks;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WEB_VIEW_DID_APPEAR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.BaseInterstitialActivity.JavaScriptWebViewCallbacks> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WEB_VIEW_DID_CLOSE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity.JavaScriptWebViewCallbacks']/field[@name='WEB_VIEW_DID_CLOSE']"
			[Register ("WEB_VIEW_DID_CLOSE")]
			public static global::com.mopub.mobileads.BaseInterstitialActivity.JavaScriptWebViewCallbacks WebViewDidClose {
				get {
					if (WEB_VIEW_DID_CLOSE_jfieldId == IntPtr.Zero)
						WEB_VIEW_DID_CLOSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEB_VIEW_DID_CLOSE", "Lcom/mopub/mobileads/BaseInterstitialActivity$JavaScriptWebViewCallbacks;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WEB_VIEW_DID_CLOSE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.BaseInterstitialActivity.JavaScriptWebViewCallbacks> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/mobileads/BaseInterstitialActivity$JavaScriptWebViewCallbacks", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (JavaScriptWebViewCallbacks); }
			}

			internal JavaScriptWebViewCallbacks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getJavascript;
			protected unsafe string Javascript {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity.JavaScriptWebViewCallbacks']/method[@name='getJavascript' and count(parameter)=0]"
				[Register ("getJavascript", "()Ljava/lang/String;", "GetGetJavascriptHandler")]
				get {
					if (id_getJavascript == IntPtr.Zero)
						id_getJavascript = JNIEnv.GetMethodID (class_ref, "getJavascript", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getJavascript), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_getUrl;
			protected unsafe string Url {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity.JavaScriptWebViewCallbacks']/method[@name='getUrl' and count(parameter)=0]"
				[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
				get {
					if (id_getUrl == IntPtr.Zero)
						id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/BaseInterstitialActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseInterstitialActivity); }
		}

		protected BaseInterstitialActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAdView;
#pragma warning disable 0169
		static Delegate GetGetAdViewHandler ()
		{
			if (cb_getAdView == null)
				cb_getAdView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdView);
			return cb_getAdView;
		}

		static IntPtr n_GetAdView (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.BaseInterstitialActivity __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.BaseInterstitialActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdView);
		}
#pragma warning restore 0169

		public abstract global::Android.Views.View AdView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity']/method[@name='getAdView' and count(parameter)=0]"
			[Register ("getAdView", "()Landroid/view/View;", "GetGetAdViewHandler")] get;
		}

		static IntPtr id_getAdReportFromIntent_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity']/method[@name='getAdReportFromIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("getAdReportFromIntent", "(Landroid/content/Intent;)Lcom/mopub/common/AdReport;", "")]
		protected static unsafe global::com.mopub.common.AdReport GetAdReportFromIntent (global::Android.Content.Intent p0)
		{
			if (id_getAdReportFromIntent_Landroid_content_Intent_ == IntPtr.Zero)
				id_getAdReportFromIntent_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getAdReportFromIntent", "(Landroid/content/Intent;)Lcom/mopub/common/AdReport;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::com.mopub.common.AdReport __ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.AdReport> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAdReportFromIntent_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getBroadcastIdentifierFromIntent_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity']/method[@name='getBroadcastIdentifierFromIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("getBroadcastIdentifierFromIntent", "(Landroid/content/Intent;)Ljava/lang/Long;", "")]
		protected static unsafe global::Java.Lang.Long GetBroadcastIdentifierFromIntent (global::Android.Content.Intent p0)
		{
			if (id_getBroadcastIdentifierFromIntent_Landroid_content_Intent_ == IntPtr.Zero)
				id_getBroadcastIdentifierFromIntent_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "getBroadcastIdentifierFromIntent", "(Landroid/content/Intent;)Ljava/lang/Long;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Long __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBroadcastIdentifierFromIntent_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_hideInterstitialCloseButton;
#pragma warning disable 0169
		static Delegate GetHideInterstitialCloseButtonHandler ()
		{
			if (cb_hideInterstitialCloseButton == null)
				cb_hideInterstitialCloseButton = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideInterstitialCloseButton);
			return cb_hideInterstitialCloseButton;
		}

		static void n_HideInterstitialCloseButton (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.BaseInterstitialActivity __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.BaseInterstitialActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideInterstitialCloseButton ();
		}
#pragma warning restore 0169

		static IntPtr id_hideInterstitialCloseButton;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity']/method[@name='hideInterstitialCloseButton' and count(parameter)=0]"
		[Register ("hideInterstitialCloseButton", "()V", "GetHideInterstitialCloseButtonHandler")]
		protected virtual unsafe void HideInterstitialCloseButton ()
		{
			if (id_hideInterstitialCloseButton == IntPtr.Zero)
				id_hideInterstitialCloseButton = JNIEnv.GetMethodID (class_ref, "hideInterstitialCloseButton", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hideInterstitialCloseButton);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideInterstitialCloseButton", "()V"));
			} finally {
			}
		}

		static Delegate cb_showInterstitialCloseButton;
#pragma warning disable 0169
		static Delegate GetShowInterstitialCloseButtonHandler ()
		{
			if (cb_showInterstitialCloseButton == null)
				cb_showInterstitialCloseButton = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowInterstitialCloseButton);
			return cb_showInterstitialCloseButton;
		}

		static void n_ShowInterstitialCloseButton (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.BaseInterstitialActivity __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.BaseInterstitialActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowInterstitialCloseButton ();
		}
#pragma warning restore 0169

		static IntPtr id_showInterstitialCloseButton;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity']/method[@name='showInterstitialCloseButton' and count(parameter)=0]"
		[Register ("showInterstitialCloseButton", "()V", "GetShowInterstitialCloseButtonHandler")]
		protected virtual unsafe void ShowInterstitialCloseButton ()
		{
			if (id_showInterstitialCloseButton == IntPtr.Zero)
				id_showInterstitialCloseButton = JNIEnv.GetMethodID (class_ref, "showInterstitialCloseButton", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showInterstitialCloseButton);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showInterstitialCloseButton", "()V"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mopub/mobileads/BaseInterstitialActivity", DoNotGenerateAcw=true)]
	internal partial class BaseInterstitialActivityInvoker : BaseInterstitialActivity {

		public BaseInterstitialActivityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseInterstitialActivityInvoker); }
		}

		static IntPtr id_getAdView;
		public override unsafe global::Android.Views.View AdView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseInterstitialActivity']/method[@name='getAdView' and count(parameter)=0]"
			[Register ("getAdView", "()Landroid/view/View;", "GetGetAdViewHandler")]
			get {
				if (id_getAdView == IntPtr.Zero)
					id_getAdView = JNIEnv.GetMethodID (class_ref, "getAdView", "()Landroid/view/View;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdView), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

}
