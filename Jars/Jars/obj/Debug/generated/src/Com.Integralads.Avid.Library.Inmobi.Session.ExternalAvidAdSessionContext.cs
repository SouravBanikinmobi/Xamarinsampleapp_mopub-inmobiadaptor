using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Integralads.Avid.Library.Inmobi.Session {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session']/class[@name='ExternalAvidAdSessionContext']"
	[global::Android.Runtime.Register ("com/integralads/avid/library/inmobi/session/ExternalAvidAdSessionContext", DoNotGenerateAcw=true)]
	public partial class ExternalAvidAdSessionContext : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/integralads/avid/library/inmobi/session/ExternalAvidAdSessionContext", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExternalAvidAdSessionContext); }
		}

		protected ExternalAvidAdSessionContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session']/class[@name='ExternalAvidAdSessionContext']/constructor[@name='ExternalAvidAdSessionContext' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ExternalAvidAdSessionContext (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (ExternalAvidAdSessionContext)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session']/class[@name='ExternalAvidAdSessionContext']/constructor[@name='ExternalAvidAdSessionContext' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Z)V", "")]
		public unsafe ExternalAvidAdSessionContext (string p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ExternalAvidAdSessionContext)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Z)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Z == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isDeferred;
#pragma warning disable 0169
		static Delegate GetIsDeferredHandler ()
		{
			if (cb_isDeferred == null)
				cb_isDeferred = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDeferred);
			return cb_isDeferred;
		}

		static bool n_IsDeferred (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Session.ExternalAvidAdSessionContext __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.ExternalAvidAdSessionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDeferred;
		}
#pragma warning restore 0169

		static IntPtr id_isDeferred;
		public virtual unsafe bool IsDeferred {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session']/class[@name='ExternalAvidAdSessionContext']/method[@name='isDeferred' and count(parameter)=0]"
			[Register ("isDeferred", "()Z", "GetIsDeferredHandler")]
			get {
				if (id_isDeferred == IntPtr.Zero)
					id_isDeferred = JNIEnv.GetMethodID (class_ref, "isDeferred", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDeferred);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDeferred", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getPartnerVersion;
#pragma warning disable 0169
		static Delegate GetGetPartnerVersionHandler ()
		{
			if (cb_getPartnerVersion == null)
				cb_getPartnerVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPartnerVersion);
			return cb_getPartnerVersion;
		}

		static IntPtr n_GetPartnerVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Session.ExternalAvidAdSessionContext __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.ExternalAvidAdSessionContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PartnerVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getPartnerVersion;
		public virtual unsafe string PartnerVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session']/class[@name='ExternalAvidAdSessionContext']/method[@name='getPartnerVersion' and count(parameter)=0]"
			[Register ("getPartnerVersion", "()Ljava/lang/String;", "GetGetPartnerVersionHandler")]
			get {
				if (id_getPartnerVersion == IntPtr.Zero)
					id_getPartnerVersion = JNIEnv.GetMethodID (class_ref, "getPartnerVersion", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPartnerVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPartnerVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
