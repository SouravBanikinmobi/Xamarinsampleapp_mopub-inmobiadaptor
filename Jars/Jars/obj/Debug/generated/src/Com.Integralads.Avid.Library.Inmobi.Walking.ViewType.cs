using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Integralads.Avid.Library.Inmobi.Walking {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.integralads.avid.library.inmobi.walking']/class[@name='ViewType']"
	[global::Android.Runtime.Register ("com/integralads/avid/library/inmobi/walking/ViewType", DoNotGenerateAcw=true)]
	public sealed partial class ViewType : global::Java.Lang.Enum {


		static IntPtr OBSTRUCTION_VIEW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.integralads.avid.library.inmobi.walking']/class[@name='ViewType']/field[@name='OBSTRUCTION_VIEW']"
		[Register ("OBSTRUCTION_VIEW")]
		public static global::Com.Integralads.Avid.Library.Inmobi.Walking.ViewType ObstructionView {
			get {
				if (OBSTRUCTION_VIEW_jfieldId == IntPtr.Zero)
					OBSTRUCTION_VIEW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OBSTRUCTION_VIEW", "Lcom/integralads/avid/library/inmobi/walking/ViewType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OBSTRUCTION_VIEW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Walking.ViewType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ROOT_VIEW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.integralads.avid.library.inmobi.walking']/class[@name='ViewType']/field[@name='ROOT_VIEW']"
		[Register ("ROOT_VIEW")]
		public static global::Com.Integralads.Avid.Library.Inmobi.Walking.ViewType RootView {
			get {
				if (ROOT_VIEW_jfieldId == IntPtr.Zero)
					ROOT_VIEW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ROOT_VIEW", "Lcom/integralads/avid/library/inmobi/walking/ViewType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ROOT_VIEW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Walking.ViewType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNDERLYING_VIEW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.integralads.avid.library.inmobi.walking']/class[@name='ViewType']/field[@name='UNDERLYING_VIEW']"
		[Register ("UNDERLYING_VIEW")]
		public static global::Com.Integralads.Avid.Library.Inmobi.Walking.ViewType UnderlyingView {
			get {
				if (UNDERLYING_VIEW_jfieldId == IntPtr.Zero)
					UNDERLYING_VIEW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNDERLYING_VIEW", "Lcom/integralads/avid/library/inmobi/walking/ViewType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNDERLYING_VIEW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Walking.ViewType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/integralads/avid/library/inmobi/walking/ViewType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewType); }
		}

		internal ViewType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.walking']/class[@name='ViewType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/integralads/avid/library/inmobi/walking/ViewType;", "")]
		public static unsafe global::Com.Integralads.Avid.Library.Inmobi.Walking.ViewType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/integralads/avid/library/inmobi/walking/ViewType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Integralads.Avid.Library.Inmobi.Walking.ViewType __ret = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Walking.ViewType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.walking']/class[@name='ViewType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/integralads/avid/library/inmobi/walking/ViewType;", "")]
		public static unsafe global::Com.Integralads.Avid.Library.Inmobi.Walking.ViewType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/integralads/avid/library/inmobi/walking/ViewType;");
			try {
				return (global::Com.Integralads.Avid.Library.Inmobi.Walking.ViewType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Integralads.Avid.Library.Inmobi.Walking.ViewType));
			} finally {
			}
		}

	}
}
