using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.mopub.mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdAlertReporter']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/AdAlertReporter", DoNotGenerateAcw=true)]
	public partial class AdAlertReporter : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/AdAlertReporter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdAlertReporter); }
		}

		protected AdAlertReporter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_view_View_Lcom_mopub_common_AdReport_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdAlertReporter']/constructor[@name='AdAlertReporter' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.view.View'] and parameter[3][@type='com.mopub.common.AdReport']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/view/View;Lcom/mopub/common/AdReport;)V", "")]
		public unsafe AdAlertReporter (global::Android.Content.Context p0, global::Android.Views.View p1, global::com.mopub.common.AdReport p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (AdAlertReporter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/view/View;Lcom/mopub/common/AdReport;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/view/View;Lcom/mopub/common/AdReport;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_view_View_Lcom_mopub_common_AdReport_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_view_View_Lcom_mopub_common_AdReport_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/view/View;Lcom/mopub/common/AdReport;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_view_View_Lcom_mopub_common_AdReport_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_view_View_Lcom_mopub_common_AdReport_, __args);
			} finally {
			}
		}

		static Delegate cb_send;
#pragma warning disable 0169
		static Delegate GetSendHandler ()
		{
			if (cb_send == null)
				cb_send = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Send);
			return cb_send;
		}

		static void n_Send (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.AdAlertReporter __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.AdAlertReporter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Send ();
		}
#pragma warning restore 0169

		static IntPtr id_send;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='AdAlertReporter']/method[@name='send' and count(parameter)=0]"
		[Register ("send", "()V", "GetSendHandler")]
		public virtual unsafe void Send ()
		{
			if (id_send == IntPtr.Zero)
				id_send = JNIEnv.GetMethodID (class_ref, "send", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_send);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "()V"));
			} finally {
			}
		}

	}
}
