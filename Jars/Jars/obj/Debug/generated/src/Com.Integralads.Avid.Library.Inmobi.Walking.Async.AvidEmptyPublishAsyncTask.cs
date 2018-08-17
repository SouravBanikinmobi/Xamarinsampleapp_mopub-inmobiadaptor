using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Integralads.Avid.Library.Inmobi.Walking.Async {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.integralads.avid.library.inmobi.walking.async']/class[@name='AvidEmptyPublishAsyncTask']"
	[global::Android.Runtime.Register ("com/integralads/avid/library/inmobi/walking/async/AvidEmptyPublishAsyncTask", DoNotGenerateAcw=true)]
	public partial class AvidEmptyPublishAsyncTask : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/integralads/avid/library/inmobi/walking/async/AvidEmptyPublishAsyncTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AvidEmptyPublishAsyncTask); }
		}

		protected AvidEmptyPublishAsyncTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
