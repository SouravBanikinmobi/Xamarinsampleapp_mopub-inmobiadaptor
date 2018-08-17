using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal.jsbridge']/class[@name='AvidJavascriptInterface']"
	[global::Android.Runtime.Register ("com/integralads/avid/library/inmobi/session/internal/jsbridge/AvidJavascriptInterface", DoNotGenerateAcw=true)]
	public partial class AvidJavascriptInterface : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal.jsbridge']/class[@name='AvidJavascriptInterface']/field[@name='AVID_OBJECT']"
		[Register ("AVID_OBJECT")]
		public const string AvidObject = (string) "avid";
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal.jsbridge']/interface[@name='AvidJavascriptInterface.AvidJavascriptInterfaceCallback']"
		[Register ("com/integralads/avid/library/inmobi/session/internal/jsbridge/AvidJavascriptInterface$AvidJavascriptInterfaceCallback", "", "Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidJavascriptInterface/IAvidJavascriptInterfaceCallbackInvoker")]
		public partial interface IAvidJavascriptInterfaceCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal.jsbridge']/interface[@name='AvidJavascriptInterface.AvidJavascriptInterfaceCallback']/method[@name='onAvidAdSessionContextInvoked' and count(parameter)=0]"
			[Register ("onAvidAdSessionContextInvoked", "()V", "GetOnAvidAdSessionContextInvokedHandler:Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidJavascriptInterface/IAvidJavascriptInterfaceCallbackInvoker, Jars")]
			void OnAvidAdSessionContextInvoked ();

		}

		[global::Android.Runtime.Register ("com/integralads/avid/library/inmobi/session/internal/jsbridge/AvidJavascriptInterface$AvidJavascriptInterfaceCallback", DoNotGenerateAcw=true)]
		internal class IAvidJavascriptInterfaceCallbackInvoker : global::Java.Lang.Object, IAvidJavascriptInterfaceCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/integralads/avid/library/inmobi/session/internal/jsbridge/AvidJavascriptInterface$AvidJavascriptInterfaceCallback");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAvidJavascriptInterfaceCallbackInvoker); }
			}

			IntPtr class_ref;

			public static IAvidJavascriptInterfaceCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAvidJavascriptInterfaceCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.integralads.avid.library.inmobi.session.internal.jsbridge.AvidJavascriptInterface.AvidJavascriptInterfaceCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAvidJavascriptInterfaceCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onAvidAdSessionContextInvoked;
#pragma warning disable 0169
			static Delegate GetOnAvidAdSessionContextInvokedHandler ()
			{
				if (cb_onAvidAdSessionContextInvoked == null)
					cb_onAvidAdSessionContextInvoked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAvidAdSessionContextInvoked);
				return cb_onAvidAdSessionContextInvoked;
			}

			static void n_OnAvidAdSessionContextInvoked (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidJavascriptInterface.IAvidJavascriptInterfaceCallback __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidJavascriptInterface.IAvidJavascriptInterfaceCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnAvidAdSessionContextInvoked ();
			}
#pragma warning restore 0169

			IntPtr id_onAvidAdSessionContextInvoked;
			public unsafe void OnAvidAdSessionContextInvoked ()
			{
				if (id_onAvidAdSessionContextInvoked == IntPtr.Zero)
					id_onAvidAdSessionContextInvoked = JNIEnv.GetMethodID (class_ref, "onAvidAdSessionContextInvoked", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAvidAdSessionContextInvoked);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/integralads/avid/library/inmobi/session/internal/jsbridge/AvidJavascriptInterface", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AvidJavascriptInterface); }
		}

		protected AvidJavascriptInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAvidAdSessionContext;
#pragma warning disable 0169
		static Delegate GetGetAvidAdSessionContextHandler ()
		{
			if (cb_getAvidAdSessionContext == null)
				cb_getAvidAdSessionContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAvidAdSessionContext);
			return cb_getAvidAdSessionContext;
		}

		static IntPtr n_GetAvidAdSessionContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidJavascriptInterface __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidJavascriptInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AvidAdSessionContext);
		}
#pragma warning restore 0169

		static IntPtr id_getAvidAdSessionContext;
		public virtual unsafe string AvidAdSessionContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal.jsbridge']/class[@name='AvidJavascriptInterface']/method[@name='getAvidAdSessionContext' and count(parameter)=0]"
			[Register ("getAvidAdSessionContext", "()Ljava/lang/String;", "GetGetAvidAdSessionContextHandler")]
			get {
				if (id_getAvidAdSessionContext == IntPtr.Zero)
					id_getAvidAdSessionContext = JNIEnv.GetMethodID (class_ref, "getAvidAdSessionContext", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAvidAdSessionContext), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAvidAdSessionContext", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCallback;
#pragma warning disable 0169
		static Delegate GetGetCallbackHandler ()
		{
			if (cb_getCallback == null)
				cb_getCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallback);
			return cb_getCallback;
		}

		static IntPtr n_GetCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidJavascriptInterface __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidJavascriptInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Callback);
		}
#pragma warning restore 0169

		static Delegate cb_setCallback_Lcom_integralads_avid_library_inmobi_session_internal_jsbridge_AvidJavascriptInterface_AvidJavascriptInterfaceCallback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_integralads_avid_library_inmobi_session_internal_jsbridge_AvidJavascriptInterface_AvidJavascriptInterfaceCallback_Handler ()
		{
			if (cb_setCallback_Lcom_integralads_avid_library_inmobi_session_internal_jsbridge_AvidJavascriptInterface_AvidJavascriptInterfaceCallback_ == null)
				cb_setCallback_Lcom_integralads_avid_library_inmobi_session_internal_jsbridge_AvidJavascriptInterface_AvidJavascriptInterfaceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallback_Lcom_integralads_avid_library_inmobi_session_internal_jsbridge_AvidJavascriptInterface_AvidJavascriptInterfaceCallback_);
			return cb_setCallback_Lcom_integralads_avid_library_inmobi_session_internal_jsbridge_AvidJavascriptInterface_AvidJavascriptInterfaceCallback_;
		}

		static void n_SetCallback_Lcom_integralads_avid_library_inmobi_session_internal_jsbridge_AvidJavascriptInterface_AvidJavascriptInterfaceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidJavascriptInterface __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidJavascriptInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidJavascriptInterface.IAvidJavascriptInterfaceCallback p0 = (global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidJavascriptInterface.IAvidJavascriptInterfaceCallback)global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidJavascriptInterface.IAvidJavascriptInterfaceCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Callback = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCallback;
		static IntPtr id_setCallback_Lcom_integralads_avid_library_inmobi_session_internal_jsbridge_AvidJavascriptInterface_AvidJavascriptInterfaceCallback_;
		public virtual unsafe global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidJavascriptInterface.IAvidJavascriptInterfaceCallback Callback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal.jsbridge']/class[@name='AvidJavascriptInterface']/method[@name='getCallback' and count(parameter)=0]"
			[Register ("getCallback", "()Lcom/integralads/avid/library/inmobi/session/internal/jsbridge/AvidJavascriptInterface$AvidJavascriptInterfaceCallback;", "GetGetCallbackHandler")]
			get {
				if (id_getCallback == IntPtr.Zero)
					id_getCallback = JNIEnv.GetMethodID (class_ref, "getCallback", "()Lcom/integralads/avid/library/inmobi/session/internal/jsbridge/AvidJavascriptInterface$AvidJavascriptInterfaceCallback;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidJavascriptInterface.IAvidJavascriptInterfaceCallback> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidJavascriptInterface.IAvidJavascriptInterfaceCallback> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCallback", "()Lcom/integralads/avid/library/inmobi/session/internal/jsbridge/AvidJavascriptInterface$AvidJavascriptInterfaceCallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal.jsbridge']/class[@name='AvidJavascriptInterface']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.integralads.avid.library.inmobi.session.internal.jsbridge.AvidJavascriptInterface.AvidJavascriptInterfaceCallback']]"
			[Register ("setCallback", "(Lcom/integralads/avid/library/inmobi/session/internal/jsbridge/AvidJavascriptInterface$AvidJavascriptInterfaceCallback;)V", "GetSetCallback_Lcom_integralads_avid_library_inmobi_session_internal_jsbridge_AvidJavascriptInterface_AvidJavascriptInterfaceCallback_Handler")]
			set {
				if (id_setCallback_Lcom_integralads_avid_library_inmobi_session_internal_jsbridge_AvidJavascriptInterface_AvidJavascriptInterfaceCallback_ == IntPtr.Zero)
					id_setCallback_Lcom_integralads_avid_library_inmobi_session_internal_jsbridge_AvidJavascriptInterface_AvidJavascriptInterfaceCallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/integralads/avid/library/inmobi/session/internal/jsbridge/AvidJavascriptInterface$AvidJavascriptInterfaceCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallback_Lcom_integralads_avid_library_inmobi_session_internal_jsbridge_AvidJavascriptInterface_AvidJavascriptInterfaceCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallback", "(Lcom/integralads/avid/library/inmobi/session/internal/jsbridge/AvidJavascriptInterface$AvidJavascriptInterfaceCallback;)V"), __args);
				} finally {
				}
			}
		}

	}
}
