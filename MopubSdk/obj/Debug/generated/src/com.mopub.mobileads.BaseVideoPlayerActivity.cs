using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.mopub.mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoPlayerActivity']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/BaseVideoPlayerActivity", DoNotGenerateAcw=true)]
	public partial class BaseVideoPlayerActivity : global::Android.App.Activity {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoPlayerActivity']/field[@name='VIDEO_CLASS_EXTRAS_KEY']"
		[Register ("VIDEO_CLASS_EXTRAS_KEY")]
		public const string VideoClassExtrasKey = (string) "video_view_class_name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoPlayerActivity']/field[@name='VIDEO_URL']"
		[Register ("VIDEO_URL")]
		public const string VideoUrl = (string) "video_url";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/BaseVideoPlayerActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseVideoPlayerActivity); }
		}

		protected BaseVideoPlayerActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoPlayerActivity']/constructor[@name='BaseVideoPlayerActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseVideoPlayerActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BaseVideoPlayerActivity)) {
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

		static IntPtr id_startMraid_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='BaseVideoPlayerActivity']/method[@name='startMraid' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("startMraid", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void StartMraid (global::Android.Content.Context p0, string p1)
		{
			if (id_startMraid_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_startMraid_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "startMraid", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_startMraid_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
