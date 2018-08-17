using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.mopub.common.events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.event']/class[@name='MoPubEvents']"
	[global::Android.Runtime.Register ("com/mopub/common/event/MoPubEvents", DoNotGenerateAcw=true)]
	public partial class MoPubEvents : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/event/MoPubEvents", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubEvents); }
		}

		protected MoPubEvents (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.event']/class[@name='MoPubEvents']/constructor[@name='MoPubEvents' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MoPubEvents ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MoPubEvents)) {
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

		static IntPtr id_log_Lcom_mopub_common_event_BaseEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='MoPubEvents']/method[@name='log' and count(parameter)=1 and parameter[1][@type='com.mopub.common.event.BaseEvent']]"
		[Register ("log", "(Lcom/mopub/common/event/BaseEvent;)V", "")]
		public static unsafe void Log (global::com.mopub.common.events.BaseEvent p0)
		{
			if (id_log_Lcom_mopub_common_event_BaseEvent_ == IntPtr.Zero)
				id_log_Lcom_mopub_common_event_BaseEvent_ = JNIEnv.GetStaticMethodID (class_ref, "log", "(Lcom/mopub/common/event/BaseEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_log_Lcom_mopub_common_event_BaseEvent_, __args);
			} finally {
			}
		}

		static IntPtr id_setEventDispatcher_Lcom_mopub_common_event_EventDispatcher_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='MoPubEvents']/method[@name='setEventDispatcher' and count(parameter)=1 and parameter[1][@type='com.mopub.common.event.EventDispatcher']]"
		[Register ("setEventDispatcher", "(Lcom/mopub/common/event/EventDispatcher;)V", "")]
		public static unsafe void SetEventDispatcher (global::com.mopub.common.events.EventDispatcher p0)
		{
			if (id_setEventDispatcher_Lcom_mopub_common_event_EventDispatcher_ == IntPtr.Zero)
				id_setEventDispatcher_Lcom_mopub_common_event_EventDispatcher_ = JNIEnv.GetStaticMethodID (class_ref, "setEventDispatcher", "(Lcom/mopub/common/event/EventDispatcher;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setEventDispatcher_Lcom_mopub_common_event_EventDispatcher_, __args);
			} finally {
			}
		}

	}
}
