using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Integralads.Avid.Library.Inmobi.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.integralads.avid.library.inmobi.utils']/class[@name='AvidCommand']"
	[global::Android.Runtime.Register ("com/integralads/avid/library/inmobi/utils/AvidCommand", DoNotGenerateAcw=true)]
	public partial class AvidCommand : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/integralads/avid/library/inmobi/utils/AvidCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AvidCommand); }
		}

		protected AvidCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.integralads.avid.library.inmobi.utils']/class[@name='AvidCommand']/constructor[@name='AvidCommand' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AvidCommand ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AvidCommand)) {
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

		static IntPtr id_callAvidbridge_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.utils']/class[@name='AvidCommand']/method[@name='callAvidbridge' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("callAvidbridge", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string CallAvidbridge (string p0)
		{
			if (id_callAvidbridge_Ljava_lang_String_ == IntPtr.Zero)
				id_callAvidbridge_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "callAvidbridge", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_callAvidbridge_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_formatJavaScript_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.utils']/class[@name='AvidCommand']/method[@name='formatJavaScript' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("formatJavaScript", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string FormatJavaScript (string p0)
		{
			if (id_formatJavaScript_Ljava_lang_String_ == IntPtr.Zero)
				id_formatJavaScript_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "formatJavaScript", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formatJavaScript_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_publishReadyEventForDeferredAdSession;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.utils']/class[@name='AvidCommand']/method[@name='publishReadyEventForDeferredAdSession' and count(parameter)=0]"
		[Register ("publishReadyEventForDeferredAdSession", "()Ljava/lang/String;", "")]
		public static unsafe string PublishReadyEventForDeferredAdSession ()
		{
			if (id_publishReadyEventForDeferredAdSession == IntPtr.Zero)
				id_publishReadyEventForDeferredAdSession = JNIEnv.GetStaticMethodID (class_ref, "publishReadyEventForDeferredAdSession", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_publishReadyEventForDeferredAdSession), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_publishVideoEvent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.utils']/class[@name='AvidCommand']/method[@name='publishVideoEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("publishVideoEvent", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string PublishVideoEvent (string p0)
		{
			if (id_publishVideoEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_publishVideoEvent_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "publishVideoEvent", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_publishVideoEvent_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_publishVideoEvent_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.utils']/class[@name='AvidCommand']/method[@name='publishVideoEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("publishVideoEvent", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string PublishVideoEvent (string p0, string p1)
		{
			if (id_publishVideoEvent_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_publishVideoEvent_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "publishVideoEvent", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_publishVideoEvent_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setAppState_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.utils']/class[@name='AvidCommand']/method[@name='setAppState' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAppState", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string SetAppState (string p0)
		{
			if (id_setAppState_Ljava_lang_String_ == IntPtr.Zero)
				id_setAppState_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setAppState", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_setAppState_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setAvidAdSessionContext_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.utils']/class[@name='AvidCommand']/method[@name='setAvidAdSessionContext' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAvidAdSessionContext", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string SetAvidAdSessionContext (string p0)
		{
			if (id_setAvidAdSessionContext_Ljava_lang_String_ == IntPtr.Zero)
				id_setAvidAdSessionContext_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setAvidAdSessionContext", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_setAvidAdSessionContext_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setNativeViewState_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.utils']/class[@name='AvidCommand']/method[@name='setNativeViewState' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setNativeViewState", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string SetNativeViewState (string p0)
		{
			if (id_setNativeViewState_Ljava_lang_String_ == IntPtr.Zero)
				id_setNativeViewState_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setNativeViewState", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_setNativeViewState_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
