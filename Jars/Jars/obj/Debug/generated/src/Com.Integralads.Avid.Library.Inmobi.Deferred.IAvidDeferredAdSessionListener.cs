using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Integralads.Avid.Library.Inmobi.Deferred {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.integralads.avid.library.inmobi.deferred']/interface[@name='AvidDeferredAdSessionListener']"
	[Register ("com/integralads/avid/library/inmobi/deferred/AvidDeferredAdSessionListener", "", "Com.Integralads.Avid.Library.Inmobi.Deferred.IAvidDeferredAdSessionListenerInvoker")]
	public partial interface IAvidDeferredAdSessionListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.deferred']/interface[@name='AvidDeferredAdSessionListener']/method[@name='recordReadyEvent' and count(parameter)=0]"
		[Register ("recordReadyEvent", "()V", "GetRecordReadyEventHandler:Com.Integralads.Avid.Library.Inmobi.Deferred.IAvidDeferredAdSessionListenerInvoker, Jars")]
		void RecordReadyEvent ();

	}

	[global::Android.Runtime.Register ("com/integralads/avid/library/inmobi/deferred/AvidDeferredAdSessionListener", DoNotGenerateAcw=true)]
	internal class IAvidDeferredAdSessionListenerInvoker : global::Java.Lang.Object, IAvidDeferredAdSessionListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/integralads/avid/library/inmobi/deferred/AvidDeferredAdSessionListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAvidDeferredAdSessionListenerInvoker); }
		}

		IntPtr class_ref;

		public static IAvidDeferredAdSessionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAvidDeferredAdSessionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.integralads.avid.library.inmobi.deferred.AvidDeferredAdSessionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAvidDeferredAdSessionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_recordReadyEvent;
#pragma warning disable 0169
		static Delegate GetRecordReadyEventHandler ()
		{
			if (cb_recordReadyEvent == null)
				cb_recordReadyEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordReadyEvent);
			return cb_recordReadyEvent;
		}

		static void n_RecordReadyEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Deferred.IAvidDeferredAdSessionListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Deferred.IAvidDeferredAdSessionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordReadyEvent ();
		}
#pragma warning restore 0169

		IntPtr id_recordReadyEvent;
		public unsafe void RecordReadyEvent ()
		{
			if (id_recordReadyEvent == IntPtr.Zero)
				id_recordReadyEvent = JNIEnv.GetMethodID (class_ref, "recordReadyEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordReadyEvent);
		}

	}

	[global::Android.Runtime.Register ("mono/com/integralads/avid/library/inmobi/deferred/AvidDeferredAdSessionListenerImplementor")]
	internal sealed partial class IAvidDeferredAdSessionListenerImplementor : global::Java.Lang.Object, IAvidDeferredAdSessionListener {

		object sender;

		public IAvidDeferredAdSessionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/integralads/avid/library/inmobi/deferred/AvidDeferredAdSessionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void RecordReadyEvent ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IAvidDeferredAdSessionListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
