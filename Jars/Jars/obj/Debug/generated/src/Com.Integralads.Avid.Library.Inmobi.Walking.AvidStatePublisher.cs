using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Integralads.Avid.Library.Inmobi.Walking {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.integralads.avid.library.inmobi.walking']/class[@name='AvidStatePublisher']"
	[global::Android.Runtime.Register ("com/integralads/avid/library/inmobi/walking/AvidStatePublisher", DoNotGenerateAcw=true)]
	public partial class AvidStatePublisher : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/integralads/avid/library/inmobi/walking/AvidStatePublisher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AvidStatePublisher); }
		}

		protected AvidStatePublisher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getPreviousState;
#pragma warning disable 0169
		static Delegate GetGetPreviousStateHandler ()
		{
			if (cb_getPreviousState == null)
				cb_getPreviousState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPreviousState);
			return cb_getPreviousState;
		}

		static IntPtr n_GetPreviousState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Walking.AvidStatePublisher __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Walking.AvidStatePublisher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PreviousState);
		}
#pragma warning restore 0169

		static Delegate cb_setPreviousState_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSetPreviousState_Lorg_json_JSONObject_Handler ()
		{
			if (cb_setPreviousState_Lorg_json_JSONObject_ == null)
				cb_setPreviousState_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPreviousState_Lorg_json_JSONObject_);
			return cb_setPreviousState_Lorg_json_JSONObject_;
		}

		static void n_SetPreviousState_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Walking.AvidStatePublisher __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Walking.AvidStatePublisher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PreviousState = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPreviousState;
		static IntPtr id_setPreviousState_Lorg_json_JSONObject_;
		public virtual unsafe global::Org.Json.JSONObject PreviousState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.walking']/class[@name='AvidStatePublisher']/method[@name='getPreviousState' and count(parameter)=0]"
			[Register ("getPreviousState", "()Lorg/json/JSONObject;", "GetGetPreviousStateHandler")]
			get {
				if (id_getPreviousState == IntPtr.Zero)
					id_getPreviousState = JNIEnv.GetMethodID (class_ref, "getPreviousState", "()Lorg/json/JSONObject;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPreviousState), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreviousState", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.walking']/class[@name='AvidStatePublisher']/method[@name='setPreviousState' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("setPreviousState", "(Lorg/json/JSONObject;)V", "GetSetPreviousState_Lorg_json_JSONObject_Handler")]
			set {
				if (id_setPreviousState_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_setPreviousState_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setPreviousState", "(Lorg/json/JSONObject;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPreviousState_Lorg_json_JSONObject_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPreviousState", "(Lorg/json/JSONObject;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_cleanupCache;
#pragma warning disable 0169
		static Delegate GetCleanupCacheHandler ()
		{
			if (cb_cleanupCache == null)
				cb_cleanupCache = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CleanupCache);
			return cb_cleanupCache;
		}

		static void n_CleanupCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Walking.AvidStatePublisher __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Walking.AvidStatePublisher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CleanupCache ();
		}
#pragma warning restore 0169

		static IntPtr id_cleanupCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.walking']/class[@name='AvidStatePublisher']/method[@name='cleanupCache' and count(parameter)=0]"
		[Register ("cleanupCache", "()V", "GetCleanupCacheHandler")]
		public virtual unsafe void CleanupCache ()
		{
			if (id_cleanupCache == IntPtr.Zero)
				id_cleanupCache = JNIEnv.GetMethodID (class_ref, "cleanupCache", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cleanupCache);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cleanupCache", "()V"));
			} finally {
			}
		}

		static Delegate cb_publishEmptyState_Lorg_json_JSONObject_Ljava_util_HashSet_D;
#pragma warning disable 0169
		static Delegate GetPublishEmptyState_Lorg_json_JSONObject_Ljava_util_HashSet_DHandler ()
		{
			if (cb_publishEmptyState_Lorg_json_JSONObject_Ljava_util_HashSet_D == null)
				cb_publishEmptyState_Lorg_json_JSONObject_Ljava_util_HashSet_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, double>) n_PublishEmptyState_Lorg_json_JSONObject_Ljava_util_HashSet_D);
			return cb_publishEmptyState_Lorg_json_JSONObject_Ljava_util_HashSet_D;
		}

		static void n_PublishEmptyState_Lorg_json_JSONObject_Ljava_util_HashSet_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, double p2)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Walking.AvidStatePublisher __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Walking.AvidStatePublisher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.HashSet p1 = global::Java.Lang.Object.GetObject<global::Java.Util.HashSet> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PublishEmptyState (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_publishEmptyState_Lorg_json_JSONObject_Ljava_util_HashSet_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.walking']/class[@name='AvidStatePublisher']/method[@name='publishEmptyState' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.util.HashSet&lt;java.lang.String&gt;'] and parameter[3][@type='double']]"
		[Register ("publishEmptyState", "(Lorg/json/JSONObject;Ljava/util/HashSet;D)V", "GetPublishEmptyState_Lorg_json_JSONObject_Ljava_util_HashSet_DHandler")]
		public virtual unsafe void PublishEmptyState (global::Org.Json.JSONObject p0, global::Java.Util.HashSet p1, double p2)
		{
			if (id_publishEmptyState_Lorg_json_JSONObject_Ljava_util_HashSet_D == IntPtr.Zero)
				id_publishEmptyState_Lorg_json_JSONObject_Ljava_util_HashSet_D = JNIEnv.GetMethodID (class_ref, "publishEmptyState", "(Lorg/json/JSONObject;Ljava/util/HashSet;D)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_publishEmptyState_Lorg_json_JSONObject_Ljava_util_HashSet_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "publishEmptyState", "(Lorg/json/JSONObject;Ljava/util/HashSet;D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_publishState_Lorg_json_JSONObject_Ljava_util_HashSet_D;
#pragma warning disable 0169
		static Delegate GetPublishState_Lorg_json_JSONObject_Ljava_util_HashSet_DHandler ()
		{
			if (cb_publishState_Lorg_json_JSONObject_Ljava_util_HashSet_D == null)
				cb_publishState_Lorg_json_JSONObject_Ljava_util_HashSet_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, double>) n_PublishState_Lorg_json_JSONObject_Ljava_util_HashSet_D);
			return cb_publishState_Lorg_json_JSONObject_Ljava_util_HashSet_D;
		}

		static void n_PublishState_Lorg_json_JSONObject_Ljava_util_HashSet_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, double p2)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Walking.AvidStatePublisher __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Walking.AvidStatePublisher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.HashSet p1 = global::Java.Lang.Object.GetObject<global::Java.Util.HashSet> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PublishState (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_publishState_Lorg_json_JSONObject_Ljava_util_HashSet_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.walking']/class[@name='AvidStatePublisher']/method[@name='publishState' and count(parameter)=3 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.util.HashSet&lt;java.lang.String&gt;'] and parameter[3][@type='double']]"
		[Register ("publishState", "(Lorg/json/JSONObject;Ljava/util/HashSet;D)V", "GetPublishState_Lorg_json_JSONObject_Ljava_util_HashSet_DHandler")]
		public virtual unsafe void PublishState (global::Org.Json.JSONObject p0, global::Java.Util.HashSet p1, double p2)
		{
			if (id_publishState_Lorg_json_JSONObject_Ljava_util_HashSet_D == IntPtr.Zero)
				id_publishState_Lorg_json_JSONObject_Ljava_util_HashSet_D = JNIEnv.GetMethodID (class_ref, "publishState", "(Lorg/json/JSONObject;Ljava/util/HashSet;D)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_publishState_Lorg_json_JSONObject_Ljava_util_HashSet_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "publishState", "(Lorg/json/JSONObject;Ljava/util/HashSet;D)V"), __args);
			} finally {
			}
		}

	}
}
