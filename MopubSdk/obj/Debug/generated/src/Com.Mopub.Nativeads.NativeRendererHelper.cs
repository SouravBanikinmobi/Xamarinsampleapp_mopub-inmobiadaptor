using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeRendererHelper']"
	[global::Android.Runtime.Register ("com/mopub/nativeads/NativeRendererHelper", DoNotGenerateAcw=true)]
	public partial class NativeRendererHelper : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/nativeads/NativeRendererHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeRendererHelper); }
		}

		protected NativeRendererHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeRendererHelper']/constructor[@name='NativeRendererHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NativeRendererHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (NativeRendererHelper)) {
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

		static IntPtr id_addCtaButton_Landroid_widget_TextView_Landroid_view_View_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeRendererHelper']/method[@name='addCtaButton' and count(parameter)=3 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='android.view.View'] and parameter[3][@type='java.lang.String']]"
		[Register ("addCtaButton", "(Landroid/widget/TextView;Landroid/view/View;Ljava/lang/String;)V", "")]
		public static unsafe void AddCtaButton (global::Android.Widget.TextView p0, global::Android.Views.View p1, string p2)
		{
			if (id_addCtaButton_Landroid_widget_TextView_Landroid_view_View_Ljava_lang_String_ == IntPtr.Zero)
				id_addCtaButton_Landroid_widget_TextView_Landroid_view_View_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "addCtaButton", "(Landroid/widget/TextView;Landroid/view/View;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addCtaButton_Landroid_widget_TextView_Landroid_view_View_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_addPrivacyInformationIcon_Landroid_widget_ImageView_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeRendererHelper']/method[@name='addPrivacyInformationIcon' and count(parameter)=3 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("addPrivacyInformationIcon", "(Landroid/widget/ImageView;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void AddPrivacyInformationIcon (global::Android.Widget.ImageView p0, string p1, string p2)
		{
			if (id_addPrivacyInformationIcon_Landroid_widget_ImageView_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addPrivacyInformationIcon_Landroid_widget_ImageView_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "addPrivacyInformationIcon", "(Landroid/widget/ImageView;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addPrivacyInformationIcon_Landroid_widget_ImageView_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_addTextView_Landroid_widget_TextView_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeRendererHelper']/method[@name='addTextView' and count(parameter)=2 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='java.lang.String']]"
		[Register ("addTextView", "(Landroid/widget/TextView;Ljava/lang/String;)V", "")]
		public static unsafe void AddTextView (global::Android.Widget.TextView p0, string p1)
		{
			if (id_addTextView_Landroid_widget_TextView_Ljava_lang_String_ == IntPtr.Zero)
				id_addTextView_Landroid_widget_TextView_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "addTextView", "(Landroid/widget/TextView;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addTextView_Landroid_widget_TextView_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_updateExtras_Landroid_view_View_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeRendererHelper']/method[@name='updateExtras' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Integer&gt;'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("updateExtras", "(Landroid/view/View;Ljava/util/Map;Ljava/util/Map;)V", "")]
		public static unsafe void UpdateExtras (global::Android.Views.View p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer> p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2)
		{
			if (id_updateExtras_Landroid_view_View_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
				id_updateExtras_Landroid_view_View_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "updateExtras", "(Landroid/view/View;Ljava/util/Map;Ljava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_updateExtras_Landroid_view_View_Ljava_util_Map_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
