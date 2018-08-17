using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.mopub.common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='HttpResponses']"
	[global::Android.Runtime.Register ("com/mopub/common/HttpResponses", DoNotGenerateAcw=true)]
	public sealed partial class HttpResponses : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/HttpResponses", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpResponses); }
		}

		internal HttpResponses (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
