using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Integralads.Avid.Library.Inmobi.Session.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal']/class[@name='SessionType']"
	[global::Android.Runtime.Register ("com/integralads/avid/library/inmobi/session/internal/SessionType", DoNotGenerateAcw=true)]
	public sealed partial class SessionType : global::Java.Lang.Enum {


		static IntPtr DISPLAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal']/class[@name='SessionType']/field[@name='DISPLAY']"
		[Register ("DISPLAY")]
		public static global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.SessionType Display {
			get {
				if (DISPLAY_jfieldId == IntPtr.Zero)
					DISPLAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISPLAY", "Lcom/integralads/avid/library/inmobi/session/internal/SessionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISPLAY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.SessionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MANAGED_DISPLAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal']/class[@name='SessionType']/field[@name='MANAGED_DISPLAY']"
		[Register ("MANAGED_DISPLAY")]
		public static global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.SessionType ManagedDisplay {
			get {
				if (MANAGED_DISPLAY_jfieldId == IntPtr.Zero)
					MANAGED_DISPLAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MANAGED_DISPLAY", "Lcom/integralads/avid/library/inmobi/session/internal/SessionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MANAGED_DISPLAY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.SessionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MANAGED_VIDEO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal']/class[@name='SessionType']/field[@name='MANAGED_VIDEO']"
		[Register ("MANAGED_VIDEO")]
		public static global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.SessionType ManagedVideo {
			get {
				if (MANAGED_VIDEO_jfieldId == IntPtr.Zero)
					MANAGED_VIDEO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MANAGED_VIDEO", "Lcom/integralads/avid/library/inmobi/session/internal/SessionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MANAGED_VIDEO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.SessionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDEO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal']/class[@name='SessionType']/field[@name='VIDEO']"
		[Register ("VIDEO")]
		public static global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.SessionType Video {
			get {
				if (VIDEO_jfieldId == IntPtr.Zero)
					VIDEO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO", "Lcom/integralads/avid/library/inmobi/session/internal/SessionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.SessionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/integralads/avid/library/inmobi/session/internal/SessionType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SessionType); }
		}

		internal SessionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal']/class[@name='SessionType']/method[@name='toString' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal']/class[@name='SessionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/integralads/avid/library/inmobi/session/internal/SessionType;", "")]
		public static unsafe global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.SessionType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/integralads/avid/library/inmobi/session/internal/SessionType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.SessionType __ret = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.SessionType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal']/class[@name='SessionType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/integralads/avid/library/inmobi/session/internal/SessionType;", "")]
		public static unsafe global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.SessionType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/integralads/avid/library/inmobi/session/internal/SessionType;");
			try {
				return (global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.SessionType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.SessionType));
			} finally {
			}
		}

	}
}
