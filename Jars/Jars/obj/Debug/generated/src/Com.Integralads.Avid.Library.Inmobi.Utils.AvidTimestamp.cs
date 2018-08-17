using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Integralads.Avid.Library.Inmobi.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.integralads.avid.library.inmobi.utils']/class[@name='AvidTimestamp']"
	[global::Android.Runtime.Register ("com/integralads/avid/library/inmobi/utils/AvidTimestamp", DoNotGenerateAcw=true)]
	public partial class AvidTimestamp : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/integralads/avid/library/inmobi/utils/AvidTimestamp", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AvidTimestamp); }
		}

		protected AvidTimestamp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.integralads.avid.library.inmobi.utils']/class[@name='AvidTimestamp']/constructor[@name='AvidTimestamp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AvidTimestamp ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AvidTimestamp)) {
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

		static IntPtr id_getCurrentTime;
		public static unsafe double CurrentTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.utils']/class[@name='AvidTimestamp']/method[@name='getCurrentTime' and count(parameter)=0]"
			[Register ("getCurrentTime", "()D", "GetGetCurrentTimeHandler")]
			get {
				if (id_getCurrentTime == IntPtr.Zero)
					id_getCurrentTime = JNIEnv.GetStaticMethodID (class_ref, "getCurrentTime", "()D");
				try {
					return JNIEnv.CallStaticDoubleMethod  (class_ref, id_getCurrentTime);
				} finally {
				}
			}
		}

	}
}
