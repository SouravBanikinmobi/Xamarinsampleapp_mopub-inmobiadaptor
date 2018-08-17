using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Moat.Analytics.Mobile.Inm {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/class[@name='MoatOptions']"
	[global::Android.Runtime.Register ("com/moat/analytics/mobile/inm/MoatOptions", DoNotGenerateAcw=true)]
	public partial class MoatOptions : global::Java.Lang.Object {


		static IntPtr autoTrackGMAInterstitials_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/class[@name='MoatOptions']/field[@name='autoTrackGMAInterstitials']"
		[Register ("autoTrackGMAInterstitials")]
		public bool AutoTrackGMAInterstitials {
			get {
				if (autoTrackGMAInterstitials_jfieldId == IntPtr.Zero)
					autoTrackGMAInterstitials_jfieldId = JNIEnv.GetFieldID (class_ref, "autoTrackGMAInterstitials", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, autoTrackGMAInterstitials_jfieldId);
			}
			set {
				if (autoTrackGMAInterstitials_jfieldId == IntPtr.Zero)
					autoTrackGMAInterstitials_jfieldId = JNIEnv.GetFieldID (class_ref, "autoTrackGMAInterstitials", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, autoTrackGMAInterstitials_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr disableAdIdCollection_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/class[@name='MoatOptions']/field[@name='disableAdIdCollection']"
		[Register ("disableAdIdCollection")]
		public bool DisableAdIdCollection {
			get {
				if (disableAdIdCollection_jfieldId == IntPtr.Zero)
					disableAdIdCollection_jfieldId = JNIEnv.GetFieldID (class_ref, "disableAdIdCollection", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, disableAdIdCollection_jfieldId);
			}
			set {
				if (disableAdIdCollection_jfieldId == IntPtr.Zero)
					disableAdIdCollection_jfieldId = JNIEnv.GetFieldID (class_ref, "disableAdIdCollection", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, disableAdIdCollection_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr disableLocationServices_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/class[@name='MoatOptions']/field[@name='disableLocationServices']"
		[Register ("disableLocationServices")]
		public bool DisableLocationServices {
			get {
				if (disableLocationServices_jfieldId == IntPtr.Zero)
					disableLocationServices_jfieldId = JNIEnv.GetFieldID (class_ref, "disableLocationServices", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, disableLocationServices_jfieldId);
			}
			set {
				if (disableLocationServices_jfieldId == IntPtr.Zero)
					disableLocationServices_jfieldId = JNIEnv.GetFieldID (class_ref, "disableLocationServices", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, disableLocationServices_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr loggingEnabled_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/class[@name='MoatOptions']/field[@name='loggingEnabled']"
		[Register ("loggingEnabled")]
		public bool LoggingEnabled {
			get {
				if (loggingEnabled_jfieldId == IntPtr.Zero)
					loggingEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "loggingEnabled", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, loggingEnabled_jfieldId);
			}
			set {
				if (loggingEnabled_jfieldId == IntPtr.Zero)
					loggingEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "loggingEnabled", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, loggingEnabled_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/moat/analytics/mobile/inm/MoatOptions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoatOptions); }
		}

		protected MoatOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/class[@name='MoatOptions']/constructor[@name='MoatOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MoatOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MoatOptions)) {
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

	}
}
