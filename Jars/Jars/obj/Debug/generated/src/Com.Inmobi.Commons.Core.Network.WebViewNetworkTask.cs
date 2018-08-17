using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Inmobi.Commons.Core.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.inmobi.commons.core.network']/class[@name='WebViewNetworkTask']"
	[global::Android.Runtime.Register ("com/inmobi/commons/core/network/WebViewNetworkTask", DoNotGenerateAcw=true)]
	public partial class WebViewNetworkTask : global::Java.Lang.Object {


		static IntPtr b_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.inmobi.commons.core.network']/class[@name='WebViewNetworkTask']/field[@name='b']"
		[Register ("b")]
		public global::Android.Webkit.WebViewClient B {
			get {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Landroid/webkit/WebViewClient;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, b_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Webkit.WebViewClient> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (b_jfieldId == IntPtr.Zero)
					b_jfieldId = JNIEnv.GetFieldID (class_ref, "b", "Landroid/webkit/WebViewClient;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, b_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr c_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.inmobi.commons.core.network']/class[@name='WebViewNetworkTask']/field[@name='c']"
		[Register ("c")]
		public global::Com.Inmobi.Commons.Core.Network.WebViewNetworkTask.NetworkTaskWebView C {
			get {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "Lcom/inmobi/commons/core/network/WebViewNetworkTask$NetworkTaskWebView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, c_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Inmobi.Commons.Core.Network.WebViewNetworkTask.NetworkTaskWebView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "Lcom/inmobi/commons/core/network/WebViewNetworkTask$NetworkTaskWebView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, c_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.inmobi.commons.core.network']/class[@name='WebViewNetworkTask.NetworkTaskWebView']"
		[global::Android.Runtime.Register ("com/inmobi/commons/core/network/WebViewNetworkTask$NetworkTaskWebView", DoNotGenerateAcw=true)]
		public partial class NetworkTaskWebView : global::Android.Webkit.WebView {


			static IntPtr a_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.inmobi.commons.core.network']/class[@name='WebViewNetworkTask.NetworkTaskWebView']/field[@name='a']"
			[Register ("a")]
			public bool A {
				get {
					if (a_jfieldId == IntPtr.Zero)
						a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, a_jfieldId);
				}
				set {
					if (a_jfieldId == IntPtr.Zero)
						a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, a_jfieldId, value);
					} finally {
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/inmobi/commons/core/network/WebViewNetworkTask$NetworkTaskWebView", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NetworkTaskWebView); }
			}

			protected NetworkTaskWebView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_inmobi_commons_core_network_WebViewNetworkTask_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.inmobi.commons.core.network']/class[@name='WebViewNetworkTask.NetworkTaskWebView']/constructor[@name='WebViewNetworkTask.NetworkTaskWebView' and count(parameter)=2 and parameter[1][@type='com.inmobi.commons.core.network.WebViewNetworkTask'] and parameter[2][@type='android.content.Context']]"
			[Register (".ctor", "(Lcom/inmobi/commons/core/network/WebViewNetworkTask;Landroid/content/Context;)V", "")]
			public unsafe NetworkTaskWebView (global::Com.Inmobi.Commons.Core.Network.WebViewNetworkTask __self, global::Android.Content.Context p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (NetworkTaskWebView)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", __args);
						return;
					}

					if (id_ctor_Lcom_inmobi_commons_core_network_WebViewNetworkTask_Landroid_content_Context_ == IntPtr.Zero)
						id_ctor_Lcom_inmobi_commons_core_network_WebViewNetworkTask_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/inmobi/commons/core/network/WebViewNetworkTask;Landroid/content/Context;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_inmobi_commons_core_network_WebViewNetworkTask_Landroid_content_Context_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_inmobi_commons_core_network_WebViewNetworkTask_Landroid_content_Context_, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/inmobi/commons/core/network/WebViewNetworkTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WebViewNetworkTask); }
		}

		protected WebViewNetworkTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
