using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.mopub.common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='AdType']"
	[global::Android.Runtime.Register ("com/mopub/common/AdType", DoNotGenerateAcw=true)]
	public partial class AdType : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='AdType']/field[@name='CLEAR']"
		[Register ("CLEAR")]
		public const string Clear = (string) "clear";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='AdType']/field[@name='CUSTOM']"
		[Register ("CUSTOM")]
		public const string Custom = (string) "custom";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='AdType']/field[@name='HTML']"
		[Register ("HTML")]
		public const string Html = (string) "html";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='AdType']/field[@name='INTERSTITIAL']"
		[Register ("INTERSTITIAL")]
		public const string Interstitial = (string) "interstitial";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='AdType']/field[@name='MRAID']"
		[Register ("MRAID")]
		public const string Mraid = (string) "mraid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='AdType']/field[@name='STATIC_NATIVE']"
		[Register ("STATIC_NATIVE")]
		public const string StaticNative = (string) "json";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.common']/class[@name='AdType']/field[@name='VIDEO_NATIVE']"
		[Register ("VIDEO_NATIVE")]
		public const string VideoNative = (string) "json_video";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/AdType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdType); }
		}

		protected AdType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common']/class[@name='AdType']/constructor[@name='AdType' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AdType ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AdType)) {
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
