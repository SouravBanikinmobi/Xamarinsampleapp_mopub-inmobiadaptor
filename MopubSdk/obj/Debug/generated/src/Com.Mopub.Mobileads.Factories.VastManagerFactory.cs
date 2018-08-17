using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Factories {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='VastManagerFactory']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/factories/VastManagerFactory", DoNotGenerateAcw=true)]
	public partial class VastManagerFactory : global::Java.Lang.Object {


		static IntPtr instance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='VastManagerFactory']/field[@name='instance']"
		[Register ("instance")]
		protected static global::Com.Mopub.Mobileads.Factories.VastManagerFactory Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/factories/VastManagerFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.VastManagerFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/mopub/mobileads/factories/VastManagerFactory;");
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
				return JNIEnv.FindClass ("com/mopub/mobileads/factories/VastManagerFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VastManagerFactory); }
		}

		protected VastManagerFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='VastManagerFactory']/constructor[@name='VastManagerFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VastManagerFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VastManagerFactory)) {
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

		static IntPtr id_setInstance_Lcom_mopub_mobileads_factories_VastManagerFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='VastManagerFactory']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.factories.VastManagerFactory']]"
		[Obsolete (@"deprecated")]
		[Register ("setInstance", "(Lcom/mopub/mobileads/factories/VastManagerFactory;)V", "")]
		public static unsafe void SetInstance (global::Com.Mopub.Mobileads.Factories.VastManagerFactory p0)
		{
			if (id_setInstance_Lcom_mopub_mobileads_factories_VastManagerFactory_ == IntPtr.Zero)
				id_setInstance_Lcom_mopub_mobileads_factories_VastManagerFactory_ = JNIEnv.GetStaticMethodID (class_ref, "setInstance", "(Lcom/mopub/mobileads/factories/VastManagerFactory;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setInstance_Lcom_mopub_mobileads_factories_VastManagerFactory_, __args);
			} finally {
			}
		}

	}
}
