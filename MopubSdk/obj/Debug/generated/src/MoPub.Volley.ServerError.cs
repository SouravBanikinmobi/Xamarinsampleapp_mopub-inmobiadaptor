using System;
using System.Collections.Generic;
using Android.Runtime;

namespace MoPub.Volley {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley']/class[@name='ServerError']"
	[global::Android.Runtime.Register ("com/mopub/volley/ServerError", DoNotGenerateAcw=true)]
	public partial class ServerError : global::MoPub.Volley.VolleyError {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/ServerError", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ServerError); }
		}

		protected ServerError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mopub_volley_NetworkResponse_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='ServerError']/constructor[@name='ServerError' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.NetworkResponse']]"
		[Register (".ctor", "(Lcom/mopub/volley/NetworkResponse;)V", "")]
		public unsafe ServerError (global::MoPub.Volley.NetworkResponse p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ServerError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/mopub/volley/NetworkResponse;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Lcom/mopub/volley/NetworkResponse;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_volley_NetworkResponse_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_volley_NetworkResponse_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/volley/NetworkResponse;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_volley_NetworkResponse_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Lcom_mopub_volley_NetworkResponse_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='ServerError']/constructor[@name='ServerError' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ServerError ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ServerError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
