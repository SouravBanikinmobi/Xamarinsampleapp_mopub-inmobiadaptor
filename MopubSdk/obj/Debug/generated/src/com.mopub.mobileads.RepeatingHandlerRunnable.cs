using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.mopub.mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='RepeatingHandlerRunnable']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/RepeatingHandlerRunnable", DoNotGenerateAcw=true)]
	public abstract partial class RepeatingHandlerRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {


		static IntPtr mHandler_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='RepeatingHandlerRunnable']/field[@name='mHandler']"
		[Register ("mHandler")]
		protected global::Android.OS.Handler MHandler {
			get {
				if (mHandler_jfieldId == IntPtr.Zero)
					mHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mHandler", "Landroid/os/Handler;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mHandler_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mHandler_jfieldId == IntPtr.Zero)
					mHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mHandler", "Landroid/os/Handler;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mHandler_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mUpdateIntervalMillis_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='RepeatingHandlerRunnable']/field[@name='mUpdateIntervalMillis']"
		[Register ("mUpdateIntervalMillis")]
		protected long MUpdateIntervalMillis {
			get {
				if (mUpdateIntervalMillis_jfieldId == IntPtr.Zero)
					mUpdateIntervalMillis_jfieldId = JNIEnv.GetFieldID (class_ref, "mUpdateIntervalMillis", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, mUpdateIntervalMillis_jfieldId);
			}
			set {
				if (mUpdateIntervalMillis_jfieldId == IntPtr.Zero)
					mUpdateIntervalMillis_jfieldId = JNIEnv.GetFieldID (class_ref, "mUpdateIntervalMillis", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mUpdateIntervalMillis_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/RepeatingHandlerRunnable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RepeatingHandlerRunnable); }
		}

		protected RepeatingHandlerRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Handler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='RepeatingHandlerRunnable']/constructor[@name='RepeatingHandlerRunnable' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
		[Register (".ctor", "(Landroid/os/Handler;)V", "")]
		public unsafe RepeatingHandlerRunnable (global::Android.OS.Handler p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (RepeatingHandlerRunnable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Handler;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Handler;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Handler_ == IntPtr.Zero)
					id_ctor_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Handler;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Handler_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Handler_, __args);
			} finally {
			}
		}

		static Delegate cb_doWork;
#pragma warning disable 0169
		static Delegate GetDoWorkHandler ()
		{
			if (cb_doWork == null)
				cb_doWork = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DoWork);
			return cb_doWork;
		}

		static void n_DoWork (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.RepeatingHandlerRunnable __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.RepeatingHandlerRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoWork ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='RepeatingHandlerRunnable']/method[@name='doWork' and count(parameter)=0]"
		[Register ("doWork", "()V", "GetDoWorkHandler")]
		public abstract void DoWork ();

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.RepeatingHandlerRunnable __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.RepeatingHandlerRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='RepeatingHandlerRunnable']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			} finally {
			}
		}

		static Delegate cb_startRepeating_J;
#pragma warning disable 0169
		static Delegate GetStartRepeating_JHandler ()
		{
			if (cb_startRepeating_J == null)
				cb_startRepeating_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_StartRepeating_J);
			return cb_startRepeating_J;
		}

		static void n_StartRepeating_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::com.mopub.mobileads.RepeatingHandlerRunnable __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.RepeatingHandlerRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartRepeating (p0);
		}
#pragma warning restore 0169

		static IntPtr id_startRepeating_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='RepeatingHandlerRunnable']/method[@name='startRepeating' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("startRepeating", "(J)V", "GetStartRepeating_JHandler")]
		public virtual unsafe void StartRepeating (long p0)
		{
			if (id_startRepeating_J == IntPtr.Zero)
				id_startRepeating_J = JNIEnv.GetMethodID (class_ref, "startRepeating", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startRepeating_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startRepeating", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.RepeatingHandlerRunnable __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.RepeatingHandlerRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='RepeatingHandlerRunnable']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mopub/mobileads/RepeatingHandlerRunnable", DoNotGenerateAcw=true)]
	internal partial class RepeatingHandlerRunnableInvoker : RepeatingHandlerRunnable {

		public RepeatingHandlerRunnableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RepeatingHandlerRunnableInvoker); }
		}

		static IntPtr id_doWork;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='RepeatingHandlerRunnable']/method[@name='doWork' and count(parameter)=0]"
		[Register ("doWork", "()V", "GetDoWorkHandler")]
		public override unsafe void DoWork ()
		{
			if (id_doWork == IntPtr.Zero)
				id_doWork = JNIEnv.GetMethodID (class_ref, "doWork", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doWork);
			} finally {
			}
		}

	}

}
