using System;
using System.Collections.Generic;
using Android.Runtime;

namespace MoPub.Volley {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley']/class[@name='TimeoutError']"
	[global::Android.Runtime.Register ("com/mopub/volley/TimeoutError", DoNotGenerateAcw=true)]
	public partial class TimeoutError : global::MoPub.Volley.VolleyError {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/TimeoutError", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TimeoutError); }
		}

		protected TimeoutError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='TimeoutError']/constructor[@name='TimeoutError' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TimeoutError ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TimeoutError)) {
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
