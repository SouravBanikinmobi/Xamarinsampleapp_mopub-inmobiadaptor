using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Integralads.Avid.Library.Inmobi.Walking.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.integralads.avid.library.inmobi.walking.async']/class[@name='AvidPublishAsyncTask']"
	[global::Android.Runtime.Register ("com/integralads/avid/library/inmobi/walking/async/AvidPublishAsyncTask", DoNotGenerateAcw=true)]
	public partial class AvidPublishAsyncTask : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/integralads/avid/library/inmobi/walking/async/AvidPublishAsyncTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AvidPublishAsyncTask); }
		}

		protected AvidPublishAsyncTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
