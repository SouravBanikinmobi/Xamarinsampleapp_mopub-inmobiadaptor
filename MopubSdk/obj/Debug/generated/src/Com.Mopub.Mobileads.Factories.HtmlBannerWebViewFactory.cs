using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Factories {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HtmlBannerWebViewFactory']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/factories/HtmlBannerWebViewFactory", DoNotGenerateAcw=true)]
	public partial class HtmlBannerWebViewFactory : global::Java.Lang.Object {


		static IntPtr instance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HtmlBannerWebViewFactory']/field[@name='instance']"
		[Register ("instance")]
		protected static global::Com.Mopub.Mobileads.Factories.HtmlBannerWebViewFactory Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/factories/HtmlBannerWebViewFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.HtmlBannerWebViewFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/factories/HtmlBannerWebViewFactory;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, instance_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/factories/HtmlBannerWebViewFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HtmlBannerWebViewFactory); }
		}

		protected HtmlBannerWebViewFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HtmlBannerWebViewFactory']/constructor[@name='HtmlBannerWebViewFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HtmlBannerWebViewFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HtmlBannerWebViewFactory)) {
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

		static IntPtr id_create_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HtmlBannerWebViewFactory']/method[@name='create' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.common.AdReport'] and parameter[3][@type='com.mopub.mobileads.CustomEventBanner.CustomEventBannerListener'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("create", "(Landroid/content/Context;Lcom/mopub/common/AdReport;Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;ZLjava/lang/String;Ljava/lang/String;)Lcom/mopub/mobileads/HtmlBannerWebView;", "")]
		public static unsafe global::com.mopub.mobileads.HtmlBannerWebView Create (global::Android.Content.Context p0, global::com.mopub.common.AdReport p1, global::com.mopub.mobileads.CustomEventBanner.ICustomEventBannerListener p2, bool p3, string p4, string p5)
		{
			if (id_create_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_create_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Landroid/content/Context;Lcom/mopub/common/AdReport;Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;ZLjava/lang/String;Ljava/lang/String;)Lcom/mopub/mobileads/HtmlBannerWebView;");
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				global::com.mopub.mobileads.HtmlBannerWebView __ret = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.HtmlBannerWebView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_internalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInternalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_internalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_ == null)
				cb_internalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr, IntPtr, IntPtr>) n_InternalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_);
			return cb_internalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_InternalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Mopub.Mobileads.Factories.HtmlBannerWebViewFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.HtmlBannerWebViewFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::com.mopub.common.AdReport p1 = global::Java.Lang.Object.GetObject<global::com.mopub.common.AdReport> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::com.mopub.mobileads.CustomEventBanner.ICustomEventBannerListener p2 = (global::com.mopub.mobileads.CustomEventBanner.ICustomEventBannerListener)global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.CustomEventBanner.ICustomEventBannerListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InternalCreate (p0, p1, p2, p3, p4, p5));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_internalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HtmlBannerWebViewFactory']/method[@name='internalCreate' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.mopub.common.AdReport'] and parameter[3][@type='com.mopub.mobileads.CustomEventBanner.CustomEventBannerListener'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("internalCreate", "(Landroid/content/Context;Lcom/mopub/common/AdReport;Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;ZLjava/lang/String;Ljava/lang/String;)Lcom/mopub/mobileads/HtmlBannerWebView;", "GetInternalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::com.mopub.mobileads.HtmlBannerWebView InternalCreate (global::Android.Content.Context p0, global::com.mopub.common.AdReport p1, global::com.mopub.mobileads.CustomEventBanner.ICustomEventBannerListener p2, bool p3, string p4, string p5)
		{
			if (id_internalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_internalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "internalCreate", "(Landroid/content/Context;Lcom/mopub/common/AdReport;Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;ZLjava/lang/String;Ljava/lang/String;)Lcom/mopub/mobileads/HtmlBannerWebView;");
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);

				global::com.mopub.mobileads.HtmlBannerWebView __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.HtmlBannerWebView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_internalCreate_Landroid_content_Context_Lcom_mopub_common_AdReport_Lcom_mopub_mobileads_CustomEventBanner_CustomEventBannerListener_ZLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.HtmlBannerWebView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "internalCreate", "(Landroid/content/Context;Lcom/mopub/common/AdReport;Lcom/mopub/mobileads/CustomEventBanner$CustomEventBannerListener;ZLjava/lang/String;Ljava/lang/String;)Lcom/mopub/mobileads/HtmlBannerWebView;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_setInstance_Lcom_mopub_mobileads_factories_HtmlBannerWebViewFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HtmlBannerWebViewFactory']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.factories.HtmlBannerWebViewFactory']]"
		[Obsolete (@"deprecated")]
		[Register ("setInstance", "(Lcom/mopub/mobileads/factories/HtmlBannerWebViewFactory;)V", "")]
		public static unsafe void SetInstance (global::Com.Mopub.Mobileads.Factories.HtmlBannerWebViewFactory p0)
		{
			if (id_setInstance_Lcom_mopub_mobileads_factories_HtmlBannerWebViewFactory_ == IntPtr.Zero)
				id_setInstance_Lcom_mopub_mobileads_factories_HtmlBannerWebViewFactory_ = JNIEnv.GetStaticMethodID (class_ref, "setInstance", "(Lcom/mopub/mobileads/factories/HtmlBannerWebViewFactory;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setInstance_Lcom_mopub_mobileads_factories_HtmlBannerWebViewFactory_, __args);
			} finally {
			}
		}

	}
}
