using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Integralads.Avid.Library.Inmobi.Session.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal']/class[@name='MediaType']"
	[global::Android.Runtime.Register ("com/integralads/avid/library/inmobi/session/internal/MediaType", DoNotGenerateAcw=true)]
	public sealed partial class MediaType : global::Java.Lang.Enum {


		static IntPtr DISPLAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal']/class[@name='MediaType']/field[@name='DISPLAY']"
		[Register ("DISPLAY")]
		public static global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.MediaType Display {
			get {
				if (DISPLAY_jfieldId == IntPtr.Zero)
					DISPLAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISPLAY", "Lcom/integralads/avid/library/inmobi/session/internal/MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISPLAY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDEO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal']/class[@name='MediaType']/field[@name='VIDEO']"
		[Register ("VIDEO")]
		public static global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.MediaType Video {
			get {
				if (VIDEO_jfieldId == IntPtr.Zero)
					VIDEO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO", "Lcom/integralads/avid/library/inmobi/session/internal/MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/integralads/avid/library/inmobi/session/internal/MediaType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaType); }
		}

		internal MediaType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal']/class[@name='MediaType']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal']/class[@name='MediaType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/integralads/avid/library/inmobi/session/internal/MediaType;", "")]
		public static unsafe global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.MediaType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/integralads/avid/library/inmobi/session/internal/MediaType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.MediaType __ret = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.MediaType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal']/class[@name='MediaType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/integralads/avid/library/inmobi/session/internal/MediaType;", "")]
		public static unsafe global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.MediaType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/integralads/avid/library/inmobi/session/internal/MediaType;");
			try {
				return (global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.MediaType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.MediaType));
			} finally {
			}
		}

	}
}
