using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.mopub.common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPubHttpUrlConnection']"
	[global::Android.Runtime.Register ("com/mopub/common/MoPubHttpUrlConnection", DoNotGenerateAcw=true)]
	public abstract partial class MoPubHttpUrlConnection : global::Java.Net.HttpURLConnection {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/MoPubHttpUrlConnection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubHttpUrlConnection); }
		}

		protected MoPubHttpUrlConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getHttpUrlConnection_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPubHttpUrlConnection']/method[@name='getHttpUrlConnection' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getHttpUrlConnection", "(Ljava/lang/String;)Ljava/net/HttpURLConnection;", "")]
		public static unsafe global::Java.Net.HttpURLConnection GetHttpUrlConnection (string p0)
		{
			if (id_getHttpUrlConnection_Ljava_lang_String_ == IntPtr.Zero)
				id_getHttpUrlConnection_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getHttpUrlConnection", "(Ljava/lang/String;)Ljava/net/HttpURLConnection;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Net.HttpURLConnection __ret = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getHttpUrlConnection_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_urlEncode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common']/class[@name='MoPubHttpUrlConnection']/method[@name='urlEncode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("urlEncode", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string UrlEncode (string p0)
		{
			if (id_urlEncode_Ljava_lang_String_ == IntPtr.Zero)
				id_urlEncode_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "urlEncode", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_urlEncode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("com/mopub/common/MoPubHttpUrlConnection", DoNotGenerateAcw=true)]
	internal partial class MoPubHttpUrlConnectionInvoker : MoPubHttpUrlConnection {

		public MoPubHttpUrlConnectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubHttpUrlConnectionInvoker); }
		}

		static IntPtr id_disconnect;
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public override unsafe void Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnect);
			} finally {
			}
		}

		static IntPtr id_usingProxy;
		[Register ("usingProxy", "()Z", "GetUsingProxyHandler")]
		public override unsafe global::System.Boolean UsingProxy ()
		{
			if (id_usingProxy == IntPtr.Zero)
				id_usingProxy = JNIEnv.GetMethodID (class_ref, "usingProxy", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_usingProxy);
			} finally {
			}
		}

		static IntPtr id_connect;
		[Register ("connect", "()V", "GetConnectHandler")]
		public override unsafe void Connect ()
		{
			if (id_connect == IntPtr.Zero)
				id_connect = JNIEnv.GetMethodID (class_ref, "connect", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect);
			} finally {
			}
		}

	}

}
