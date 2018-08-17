using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal.jsbridge']/class[@name='AvidEvent']"
	[global::Android.Runtime.Register ("com/integralads/avid/library/inmobi/session/internal/jsbridge/AvidEvent", DoNotGenerateAcw=true)]
	public partial class AvidEvent : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/integralads/avid/library/inmobi/session/internal/jsbridge/AvidEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AvidEvent); }
		}

		protected AvidEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal.jsbridge']/class[@name='AvidEvent']/constructor[@name='AvidEvent' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe AvidEvent (int p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (AvidEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_ILjava_lang_String_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal.jsbridge']/class[@name='AvidEvent']/constructor[@name='AvidEvent' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.json.JSONObject']]"
		[Register (".ctor", "(ILjava/lang/String;Lorg/json/JSONObject;)V", "")]
		public unsafe AvidEvent (int p0, string p1, global::Org.Json.JSONObject p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (AvidEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(ILjava/lang/String;Lorg/json/JSONObject;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(ILjava/lang/String;Lorg/json/JSONObject;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;Lorg/json/JSONObject;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_Lorg_json_JSONObject_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_ILjava_lang_String_Lorg_json_JSONObject_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal.jsbridge']/class[@name='AvidEvent']/constructor[@name='AvidEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AvidEvent ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AvidEvent)) {
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

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidEvent __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		static Delegate cb_setData_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetSetData_Lorg_json_JSONObject_Handler ()
		{
			if (cb_setData_Lorg_json_JSONObject_ == null)
				cb_setData_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Lorg_json_JSONObject_);
			return cb_setData_Lorg_json_JSONObject_;
		}

		static void n_SetData_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidEvent __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Data = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getData;
		static IntPtr id_setData_Lorg_json_JSONObject_;
		public virtual unsafe global::Org.Json.JSONObject Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal.jsbridge']/class[@name='AvidEvent']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Lorg/json/JSONObject;", "GetGetDataHandler")]
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Lorg/json/JSONObject;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal.jsbridge']/class[@name='AvidEvent']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
			[Register ("setData", "(Lorg/json/JSONObject;)V", "GetSetData_Lorg_json_JSONObject_Handler")]
			set {
				if (id_setData_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_setData_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "setData", "(Lorg/json/JSONObject;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setData_Lorg_json_JSONObject_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setData", "(Lorg/json/JSONObject;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTag;
#pragma warning disable 0169
		static Delegate GetGetTagHandler ()
		{
			if (cb_getTag == null)
				cb_getTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTag);
			return cb_getTag;
		}

		static int n_GetTag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidEvent __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Tag;
		}
#pragma warning restore 0169

		static Delegate cb_setTag_I;
#pragma warning disable 0169
		static Delegate GetSetTag_IHandler ()
		{
			if (cb_setTag_I == null)
				cb_setTag_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTag_I);
			return cb_setTag_I;
		}

		static void n_SetTag_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidEvent __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Tag = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTag;
		static IntPtr id_setTag_I;
		public virtual unsafe int Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal.jsbridge']/class[@name='AvidEvent']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()I", "GetGetTagHandler")]
			get {
				if (id_getTag == IntPtr.Zero)
					id_getTag = JNIEnv.GetMethodID (class_ref, "getTag", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTag);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTag", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal.jsbridge']/class[@name='AvidEvent']/method[@name='setTag' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTag", "(I)V", "GetSetTag_IHandler")]
			set {
				if (id_setTag_I == IntPtr.Zero)
					id_setTag_I = JNIEnv.GetMethodID (class_ref, "setTag", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTag_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTag", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidEvent __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		static Delegate cb_setType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetType_Ljava_lang_String_Handler ()
		{
			if (cb_setType_Ljava_lang_String_ == null)
				cb_setType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Ljava_lang_String_);
			return cb_setType_Ljava_lang_String_;
		}

		static void n_SetType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidEvent __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Jsbridge.AvidEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Type = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		static IntPtr id_setType_Ljava_lang_String_;
		public virtual unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal.jsbridge']/class[@name='AvidEvent']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal.jsbridge']/class[@name='AvidEvent']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setType", "(Ljava/lang/String;)V", "GetSetType_Ljava_lang_String_Handler")]
			set {
				if (id_setType_Ljava_lang_String_ == IntPtr.Zero)
					id_setType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
