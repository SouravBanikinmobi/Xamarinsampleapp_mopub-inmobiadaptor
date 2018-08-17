using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.mopub.common {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.common']/interface[@name='MediationSettings']"
	[Register ("com/mopub/common/MediationSettings", "", "com.mopub.common.IMediationSettingsInvoker")]
	public partial interface IMediationSettings : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/mopub/common/MediationSettings", DoNotGenerateAcw=true)]
	internal class IMediationSettingsInvoker : global::Java.Lang.Object, IMediationSettings {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/common/MediationSettings");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMediationSettingsInvoker); }
		}

		IntPtr class_ref;

		public static IMediationSettings GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediationSettings> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mopub.common.MediationSettings"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediationSettingsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
