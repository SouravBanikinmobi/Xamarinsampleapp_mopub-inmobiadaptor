using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.mopub.common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='AdReport']"
	[global::Android.Runtime.Register ("com/mopub/common/AdReport", DoNotGenerateAcw=true)]
	public partial class AdReport : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/AdReport", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdReport); }
		}

		protected AdReport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getResponseString;
#pragma warning disable 0169
		static Delegate GetGetResponseStringHandler ()
		{
			if (cb_getResponseString == null)
				cb_getResponseString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseString);
			return cb_getResponseString;
		}

		static IntPtr n_GetResponseString (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.common.AdReport __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.AdReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResponseString);
		}
#pragma warning restore 0169

		static IntPtr id_getResponseString;
		public virtual unsafe string ResponseString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='AdReport']/method[@name='getResponseString' and count(parameter)=0]"
			[Register ("getResponseString", "()Ljava/lang/String;", "GetGetResponseStringHandler")]
			get {
				if (id_getResponseString == IntPtr.Zero)
					id_getResponseString = JNIEnv.GetMethodID (class_ref, "getResponseString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
