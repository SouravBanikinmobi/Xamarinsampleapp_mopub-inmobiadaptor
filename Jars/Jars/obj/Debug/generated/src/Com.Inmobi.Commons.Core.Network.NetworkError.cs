using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Inmobi.Commons.Core.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.inmobi.commons.core.network']/class[@name='NetworkError']"
	[global::Android.Runtime.Register ("com/inmobi/commons/core/network/NetworkError", DoNotGenerateAcw=true)]
	public sealed partial class NetworkError : global::Java.Lang.Object {


		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.inmobi.commons.core.network']/class[@name='NetworkError']/field[@name='b']"
		[Register ("b")]
		public string B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, b_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, b_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/inmobi/commons/core/network/NetworkError", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkError); }
		}

		internal NetworkError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
