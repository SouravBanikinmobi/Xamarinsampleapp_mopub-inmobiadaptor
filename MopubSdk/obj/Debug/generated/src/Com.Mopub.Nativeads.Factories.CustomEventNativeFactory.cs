using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads.Factories {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads.factories']/class[@name='CustomEventNativeFactory']"
	[global::Android.Runtime.Register ("com/mopub/nativeads/factories/CustomEventNativeFactory", DoNotGenerateAcw=true)]
	public partial class CustomEventNativeFactory : global::Java.Lang.Object {


		static IntPtr instance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads.factories']/class[@name='CustomEventNativeFactory']/field[@name='instance']"
		[Register ("instance")]
		protected static global::Com.Mopub.Nativeads.Factories.CustomEventNativeFactory Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/nativeads/factories/CustomEventNativeFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.Factories.CustomEventNativeFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/nativeads/factories/CustomEventNativeFactory;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, instance_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/nativeads/factories/CustomEventNativeFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomEventNativeFactory); }
		}

		protected CustomEventNativeFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads.factories']/class[@name='CustomEventNativeFactory']/constructor[@name='CustomEventNativeFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CustomEventNativeFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CustomEventNativeFactory)) {
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

		static IntPtr id_create_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads.factories']/class[@name='CustomEventNativeFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("create", "(Ljava/lang/String;)Lcom/mopub/nativeads/CustomEventNative;", "")]
		public static unsafe global::Com.Mopub.Nativeads.CustomEventNative Create (string p0)
		{
			if (id_create_Ljava_lang_String_ == IntPtr.Zero)
				id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lcom/mopub/nativeads/CustomEventNative;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Mopub.Nativeads.CustomEventNative __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.CustomEventNative> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_internalCreate_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetInternalCreate_Ljava_lang_Class_Handler ()
		{
			if (cb_internalCreate_Ljava_lang_Class_ == null)
				cb_internalCreate_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InternalCreate_Ljava_lang_Class_);
			return cb_internalCreate_Ljava_lang_Class_;
		}

		static IntPtr n_InternalCreate_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.Factories.CustomEventNativeFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.Factories.CustomEventNativeFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InternalCreate (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_internalCreate_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads.factories']/class[@name='CustomEventNativeFactory']/method[@name='internalCreate' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends com.mopub.nativeads.CustomEventNative&gt;']]"
		[Register ("internalCreate", "(Ljava/lang/Class;)Lcom/mopub/nativeads/CustomEventNative;", "GetInternalCreate_Ljava_lang_Class_Handler")]
		protected virtual unsafe global::Com.Mopub.Nativeads.CustomEventNative InternalCreate (global::Java.Lang.Class p0)
		{
			if (id_internalCreate_Ljava_lang_Class_ == IntPtr.Zero)
				id_internalCreate_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "internalCreate", "(Ljava/lang/Class;)Lcom/mopub/nativeads/CustomEventNative;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mopub.Nativeads.CustomEventNative __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.CustomEventNative> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_internalCreate_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.CustomEventNative> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "internalCreate", "(Ljava/lang/Class;)Lcom/mopub/nativeads/CustomEventNative;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setInstance_Lcom_mopub_nativeads_factories_CustomEventNativeFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads.factories']/class[@name='CustomEventNativeFactory']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.factories.CustomEventNativeFactory']]"
		[Obsolete (@"deprecated")]
		[Register ("setInstance", "(Lcom/mopub/nativeads/factories/CustomEventNativeFactory;)V", "")]
		public static unsafe void SetInstance (global::Com.Mopub.Nativeads.Factories.CustomEventNativeFactory p0)
		{
			if (id_setInstance_Lcom_mopub_nativeads_factories_CustomEventNativeFactory_ == IntPtr.Zero)
				id_setInstance_Lcom_mopub_nativeads_factories_CustomEventNativeFactory_ = JNIEnv.GetStaticMethodID (class_ref, "setInstance", "(Lcom/mopub/nativeads/factories/CustomEventNativeFactory;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setInstance_Lcom_mopub_nativeads_factories_CustomEventNativeFactory_, __args);
			} finally {
			}
		}

	}
}
