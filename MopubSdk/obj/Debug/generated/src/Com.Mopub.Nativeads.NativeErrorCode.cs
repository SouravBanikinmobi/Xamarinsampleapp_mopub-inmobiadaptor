using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeErrorCode']"
	[global::Android.Runtime.Register ("com/mopub/nativeads/NativeErrorCode", DoNotGenerateAcw=true)]
	public sealed partial class NativeErrorCode : global::Java.Lang.Enum {


		static IntPtr CONNECTION_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeErrorCode']/field[@name='CONNECTION_ERROR']"
		[Register ("CONNECTION_ERROR")]
		public static global::Com.Mopub.Nativeads.NativeErrorCode ConnectionError {
			get {
				if (CONNECTION_ERROR_jfieldId == IntPtr.Zero)
					CONNECTION_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTION_ERROR", "Lcom/mopub/nativeads/NativeErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECTION_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EMPTY_AD_RESPONSE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeErrorCode']/field[@name='EMPTY_AD_RESPONSE']"
		[Register ("EMPTY_AD_RESPONSE")]
		public static global::Com.Mopub.Nativeads.NativeErrorCode EmptyAdResponse {
			get {
				if (EMPTY_AD_RESPONSE_jfieldId == IntPtr.Zero)
					EMPTY_AD_RESPONSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_AD_RESPONSE", "Lcom/mopub/nativeads/NativeErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMPTY_AD_RESPONSE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IMAGE_DOWNLOAD_FAILURE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeErrorCode']/field[@name='IMAGE_DOWNLOAD_FAILURE']"
		[Register ("IMAGE_DOWNLOAD_FAILURE")]
		public static global::Com.Mopub.Nativeads.NativeErrorCode ImageDownloadFailure {
			get {
				if (IMAGE_DOWNLOAD_FAILURE_jfieldId == IntPtr.Zero)
					IMAGE_DOWNLOAD_FAILURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IMAGE_DOWNLOAD_FAILURE", "Lcom/mopub/nativeads/NativeErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IMAGE_DOWNLOAD_FAILURE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INVALID_REQUEST_URL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeErrorCode']/field[@name='INVALID_REQUEST_URL']"
		[Register ("INVALID_REQUEST_URL")]
		public static global::Com.Mopub.Nativeads.NativeErrorCode InvalidRequestUrl {
			get {
				if (INVALID_REQUEST_URL_jfieldId == IntPtr.Zero)
					INVALID_REQUEST_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_REQUEST_URL", "Lcom/mopub/nativeads/NativeErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_REQUEST_URL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INVALID_RESPONSE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeErrorCode']/field[@name='INVALID_RESPONSE']"
		[Register ("INVALID_RESPONSE")]
		public static global::Com.Mopub.Nativeads.NativeErrorCode InvalidResponse {
			get {
				if (INVALID_RESPONSE_jfieldId == IntPtr.Zero)
					INVALID_RESPONSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_RESPONSE", "Lcom/mopub/nativeads/NativeErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_RESPONSE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NATIVE_ADAPTER_CONFIGURATION_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeErrorCode']/field[@name='NATIVE_ADAPTER_CONFIGURATION_ERROR']"
		[Register ("NATIVE_ADAPTER_CONFIGURATION_ERROR")]
		public static global::Com.Mopub.Nativeads.NativeErrorCode NativeAdapterConfigurationError {
			get {
				if (NATIVE_ADAPTER_CONFIGURATION_ERROR_jfieldId == IntPtr.Zero)
					NATIVE_ADAPTER_CONFIGURATION_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NATIVE_ADAPTER_CONFIGURATION_ERROR", "Lcom/mopub/nativeads/NativeErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NATIVE_ADAPTER_CONFIGURATION_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NATIVE_ADAPTER_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeErrorCode']/field[@name='NATIVE_ADAPTER_NOT_FOUND']"
		[Register ("NATIVE_ADAPTER_NOT_FOUND")]
		public static global::Com.Mopub.Nativeads.NativeErrorCode NativeAdapterNotFound {
			get {
				if (NATIVE_ADAPTER_NOT_FOUND_jfieldId == IntPtr.Zero)
					NATIVE_ADAPTER_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NATIVE_ADAPTER_NOT_FOUND", "Lcom/mopub/nativeads/NativeErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NATIVE_ADAPTER_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NATIVE_RENDERER_CONFIGURATION_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeErrorCode']/field[@name='NATIVE_RENDERER_CONFIGURATION_ERROR']"
		[Register ("NATIVE_RENDERER_CONFIGURATION_ERROR")]
		public static global::Com.Mopub.Nativeads.NativeErrorCode NativeRendererConfigurationError {
			get {
				if (NATIVE_RENDERER_CONFIGURATION_ERROR_jfieldId == IntPtr.Zero)
					NATIVE_RENDERER_CONFIGURATION_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NATIVE_RENDERER_CONFIGURATION_ERROR", "Lcom/mopub/nativeads/NativeErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NATIVE_RENDERER_CONFIGURATION_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NETWORK_INVALID_REQUEST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeErrorCode']/field[@name='NETWORK_INVALID_REQUEST']"
		[Register ("NETWORK_INVALID_REQUEST")]
		public static global::Com.Mopub.Nativeads.NativeErrorCode NetworkInvalidRequest {
			get {
				if (NETWORK_INVALID_REQUEST_jfieldId == IntPtr.Zero)
					NETWORK_INVALID_REQUEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_INVALID_REQUEST", "Lcom/mopub/nativeads/NativeErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_INVALID_REQUEST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NETWORK_INVALID_STATE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeErrorCode']/field[@name='NETWORK_INVALID_STATE']"
		[Register ("NETWORK_INVALID_STATE")]
		public static global::Com.Mopub.Nativeads.NativeErrorCode NetworkInvalidState {
			get {
				if (NETWORK_INVALID_STATE_jfieldId == IntPtr.Zero)
					NETWORK_INVALID_STATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_INVALID_STATE", "Lcom/mopub/nativeads/NativeErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_INVALID_STATE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NETWORK_NO_FILL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeErrorCode']/field[@name='NETWORK_NO_FILL']"
		[Register ("NETWORK_NO_FILL")]
		public static global::Com.Mopub.Nativeads.NativeErrorCode NetworkNoFill {
			get {
				if (NETWORK_NO_FILL_jfieldId == IntPtr.Zero)
					NETWORK_NO_FILL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_NO_FILL", "Lcom/mopub/nativeads/NativeErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_NO_FILL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NETWORK_TIMEOUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeErrorCode']/field[@name='NETWORK_TIMEOUT']"
		[Register ("NETWORK_TIMEOUT")]
		public static global::Com.Mopub.Nativeads.NativeErrorCode NetworkTimeout {
			get {
				if (NETWORK_TIMEOUT_jfieldId == IntPtr.Zero)
					NETWORK_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NETWORK_TIMEOUT", "Lcom/mopub/nativeads/NativeErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NETWORK_TIMEOUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SERVER_ERROR_RESPONSE_CODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeErrorCode']/field[@name='SERVER_ERROR_RESPONSE_CODE']"
		[Register ("SERVER_ERROR_RESPONSE_CODE")]
		public static global::Com.Mopub.Nativeads.NativeErrorCode ServerErrorResponseCode {
			get {
				if (SERVER_ERROR_RESPONSE_CODE_jfieldId == IntPtr.Zero)
					SERVER_ERROR_RESPONSE_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVER_ERROR_RESPONSE_CODE", "Lcom/mopub/nativeads/NativeErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERVER_ERROR_RESPONSE_CODE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNEXPECTED_RESPONSE_CODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeErrorCode']/field[@name='UNEXPECTED_RESPONSE_CODE']"
		[Register ("UNEXPECTED_RESPONSE_CODE")]
		public static global::Com.Mopub.Nativeads.NativeErrorCode UnexpectedResponseCode {
			get {
				if (UNEXPECTED_RESPONSE_CODE_jfieldId == IntPtr.Zero)
					UNEXPECTED_RESPONSE_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNEXPECTED_RESPONSE_CODE", "Lcom/mopub/nativeads/NativeErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNEXPECTED_RESPONSE_CODE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNSPECIFIED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeErrorCode']/field[@name='UNSPECIFIED']"
		[Register ("UNSPECIFIED")]
		public static global::Com.Mopub.Nativeads.NativeErrorCode Unspecified {
			get {
				if (UNSPECIFIED_jfieldId == IntPtr.Zero)
					UNSPECIFIED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSPECIFIED", "Lcom/mopub/nativeads/NativeErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNSPECIFIED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/nativeads/NativeErrorCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeErrorCode); }
		}

		internal NativeErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeErrorCode']/method[@name='toString' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeErrorCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/nativeads/NativeErrorCode;", "")]
		public static unsafe global::Com.Mopub.Nativeads.NativeErrorCode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/nativeads/NativeErrorCode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Mopub.Nativeads.NativeErrorCode __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeErrorCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeErrorCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/mopub/nativeads/NativeErrorCode;", "")]
		public static unsafe global::Com.Mopub.Nativeads.NativeErrorCode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/nativeads/NativeErrorCode;");
			try {
				return (global::Com.Mopub.Nativeads.NativeErrorCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Nativeads.NativeErrorCode));
			} finally {
			}
		}

	}
}
