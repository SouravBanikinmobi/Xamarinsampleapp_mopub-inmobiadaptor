using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.mopub.mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VideoViewabilityTrackerXmlManager']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/VideoViewabilityTrackerXmlManager", DoNotGenerateAcw=true)]
	public partial class VideoViewabilityTrackerXmlManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VideoViewabilityTrackerXmlManager']/field[@name='PERCENT_VIEWABLE']"
		[Register ("PERCENT_VIEWABLE")]
		public const string PercentViewable = (string) "percentViewable";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='VideoViewabilityTrackerXmlManager']/field[@name='VIEWABLE_PLAYTIME']"
		[Register ("VIEWABLE_PLAYTIME")]
		public const string ViewablePlaytime = (string) "viewablePlaytime";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/VideoViewabilityTrackerXmlManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoViewabilityTrackerXmlManager); }
		}

		protected VideoViewabilityTrackerXmlManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
