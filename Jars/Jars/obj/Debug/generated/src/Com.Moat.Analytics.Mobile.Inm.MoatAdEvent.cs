using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Moat.Analytics.Mobile.Inm {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/class[@name='MoatAdEvent']"
	[global::Android.Runtime.Register ("com/moat/analytics/mobile/inm/MoatAdEvent", DoNotGenerateAcw=true)]
	public partial class MoatAdEvent : global::Java.Lang.Object {


		static IntPtr VOLUME_MUTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/class[@name='MoatAdEvent']/field[@name='VOLUME_MUTED']"
		[Register ("VOLUME_MUTED")]
		public static global::Java.Lang.Double VolumeMuted {
			get {
				if (VOLUME_MUTED_jfieldId == IntPtr.Zero)
					VOLUME_MUTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VOLUME_MUTED", "Ljava/lang/Double;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VOLUME_MUTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VOLUME_UNMUTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/class[@name='MoatAdEvent']/field[@name='VOLUME_UNMUTED']"
		[Register ("VOLUME_UNMUTED")]
		public static global::Java.Lang.Double VolumeUnmuted {
			get {
				if (VOLUME_UNMUTED_jfieldId == IntPtr.Zero)
					VOLUME_UNMUTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VOLUME_UNMUTED", "Ljava/lang/Double;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VOLUME_UNMUTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/moat/analytics/mobile/inm/MoatAdEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoatAdEvent); }
		}

		protected MoatAdEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
