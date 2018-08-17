using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.mopub.common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='DiskLruCacheUtil']"
	[global::Android.Runtime.Register ("com/mopub/common/DiskLruCacheUtil", DoNotGenerateAcw=true)]
	public sealed partial class DiskLruCacheUtil : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/DiskLruCacheUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DiskLruCacheUtil); }
		}

		internal DiskLruCacheUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
