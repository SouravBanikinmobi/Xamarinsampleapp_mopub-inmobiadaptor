using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Integralads.Avid.Library.Inmobi.Processing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.integralads.avid.library.inmobi.processing']/class[@name='AvidProcessorFactory']"
	[global::Android.Runtime.Register ("com/integralads/avid/library/inmobi/processing/AvidProcessorFactory", DoNotGenerateAcw=true)]
	public partial class AvidProcessorFactory : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/integralads/avid/library/inmobi/processing/AvidProcessorFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AvidProcessorFactory); }
		}

		protected AvidProcessorFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.integralads.avid.library.inmobi.processing']/class[@name='AvidProcessorFactory']/constructor[@name='AvidProcessorFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AvidProcessorFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AvidProcessorFactory)) {
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

		static Delegate cb_getRootProcessor;
#pragma warning disable 0169
		static Delegate GetGetRootProcessorHandler ()
		{
			if (cb_getRootProcessor == null)
				cb_getRootProcessor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRootProcessor);
			return cb_getRootProcessor;
		}

		static IntPtr n_GetRootProcessor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Processing.AvidProcessorFactory __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Processing.AvidProcessorFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RootProcessor);
		}
#pragma warning restore 0169

		static IntPtr id_getRootProcessor;
		public virtual unsafe global::Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessor RootProcessor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.processing']/class[@name='AvidProcessorFactory']/method[@name='getRootProcessor' and count(parameter)=0]"
			[Register ("getRootProcessor", "()Lcom/integralads/avid/library/inmobi/processing/IAvidNodeProcessor;", "GetGetRootProcessorHandler")]
			get {
				if (id_getRootProcessor == IntPtr.Zero)
					id_getRootProcessor = JNIEnv.GetMethodID (class_ref, "getRootProcessor", "()Lcom/integralads/avid/library/inmobi/processing/IAvidNodeProcessor;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRootProcessor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRootProcessor", "()Lcom/integralads/avid/library/inmobi/processing/IAvidNodeProcessor;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
