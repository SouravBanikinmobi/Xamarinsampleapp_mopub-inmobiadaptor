using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Integralads.Avid.Library.Inmobi.Processing {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.integralads.avid.library.inmobi.processing']/interface[@name='IAvidNodeProcessor.IAvidViewWalker']"
	[Register ("com/integralads/avid/library/inmobi/processing/IAvidNodeProcessor$IAvidViewWalker", "", "Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessorAvidViewWalkerInvoker")]
	public partial interface IAvidNodeProcessorAvidViewWalker : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.processing']/interface[@name='IAvidNodeProcessor.IAvidViewWalker']/method[@name='walkView' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.integralads.avid.library.inmobi.processing.IAvidNodeProcessor'] and parameter[3][@type='org.json.JSONObject']]"
		[Register ("walkView", "(Landroid/view/View;Lcom/integralads/avid/library/inmobi/processing/IAvidNodeProcessor;Lorg/json/JSONObject;)V", "GetWalkView_Landroid_view_View_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_Lorg_json_JSONObject_Handler:Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessorAvidViewWalkerInvoker, Jars")]
		void WalkView (global::Android.Views.View p0, global::Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessor p1, global::Org.Json.JSONObject p2);

	}

	[global::Android.Runtime.Register ("com/integralads/avid/library/inmobi/processing/IAvidNodeProcessor$IAvidViewWalker", DoNotGenerateAcw=true)]
	internal class IAvidNodeProcessorAvidViewWalkerInvoker : global::Java.Lang.Object, IAvidNodeProcessorAvidViewWalker {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/integralads/avid/library/inmobi/processing/IAvidNodeProcessor$IAvidViewWalker");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAvidNodeProcessorAvidViewWalkerInvoker); }
		}

		IntPtr class_ref;

		public static IAvidNodeProcessorAvidViewWalker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAvidNodeProcessorAvidViewWalker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.integralads.avid.library.inmobi.processing.IAvidNodeProcessor.IAvidViewWalker"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAvidNodeProcessorAvidViewWalkerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_walkView_Landroid_view_View_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetWalkView_Landroid_view_View_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_Lorg_json_JSONObject_Handler ()
		{
			if (cb_walkView_Landroid_view_View_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_Lorg_json_JSONObject_ == null)
				cb_walkView_Landroid_view_View_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WalkView_Landroid_view_View_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_Lorg_json_JSONObject_);
			return cb_walkView_Landroid_view_View_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_Lorg_json_JSONObject_;
		}

		static void n_WalkView_Landroid_view_View_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessorAvidViewWalker __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessorAvidViewWalker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessor p1 = (global::Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessor)global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessor> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p2 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.WalkView (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_walkView_Landroid_view_View_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_Lorg_json_JSONObject_;
		public unsafe void WalkView (global::Android.Views.View p0, global::Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessor p1, global::Org.Json.JSONObject p2)
		{
			if (id_walkView_Landroid_view_View_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_walkView_Landroid_view_View_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "walkView", "(Landroid/view/View;Lcom/integralads/avid/library/inmobi/processing/IAvidNodeProcessor;Lorg/json/JSONObject;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_walkView_Landroid_view_View_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_Lorg_json_JSONObject_, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.integralads.avid.library.inmobi.processing']/interface[@name='IAvidNodeProcessor']"
	[Register ("com/integralads/avid/library/inmobi/processing/IAvidNodeProcessor", "", "Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessorInvoker")]
	public partial interface IAvidNodeProcessor : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.processing']/interface[@name='IAvidNodeProcessor']/method[@name='getState' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getState", "(Landroid/view/View;)Lorg/json/JSONObject;", "GetGetState_Landroid_view_View_Handler:Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessorInvoker, Jars")]
		global::Org.Json.JSONObject GetState (global::Android.Views.View p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.processing']/interface[@name='IAvidNodeProcessor']/method[@name='iterateChildren' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='org.json.JSONObject'] and parameter[3][@type='com.integralads.avid.library.inmobi.processing.IAvidNodeProcessor.IAvidViewWalker'] and parameter[4][@type='boolean']]"
		[Register ("iterateChildren", "(Landroid/view/View;Lorg/json/JSONObject;Lcom/integralads/avid/library/inmobi/processing/IAvidNodeProcessor$IAvidViewWalker;Z)V", "GetIterateChildren_Landroid_view_View_Lorg_json_JSONObject_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_IAvidViewWalker_ZHandler:Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessorInvoker, Jars")]
		void IterateChildren (global::Android.Views.View p0, global::Org.Json.JSONObject p1, global::Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessorAvidViewWalker p2, bool p3);

	}

	[global::Android.Runtime.Register ("com/integralads/avid/library/inmobi/processing/IAvidNodeProcessor", DoNotGenerateAcw=true)]
	internal class IAvidNodeProcessorInvoker : global::Java.Lang.Object, IAvidNodeProcessor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/integralads/avid/library/inmobi/processing/IAvidNodeProcessor");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAvidNodeProcessorInvoker); }
		}

		IntPtr class_ref;

		public static IAvidNodeProcessor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAvidNodeProcessor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.integralads.avid.library.inmobi.processing.IAvidNodeProcessor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAvidNodeProcessorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getState_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetGetState_Landroid_view_View_Handler ()
		{
			if (cb_getState_Landroid_view_View_ == null)
				cb_getState_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetState_Landroid_view_View_);
			return cb_getState_Landroid_view_View_;
		}

		static IntPtr n_GetState_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessor __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetState (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getState_Landroid_view_View_;
		public unsafe global::Org.Json.JSONObject GetState (global::Android.Views.View p0)
		{
			if (id_getState_Landroid_view_View_ == IntPtr.Zero)
				id_getState_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "getState", "(Landroid/view/View;)Lorg/json/JSONObject;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Org.Json.JSONObject __ret = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getState_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_iterateChildren_Landroid_view_View_Lorg_json_JSONObject_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_IAvidViewWalker_Z;
#pragma warning disable 0169
		static Delegate GetIterateChildren_Landroid_view_View_Lorg_json_JSONObject_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_IAvidViewWalker_ZHandler ()
		{
			if (cb_iterateChildren_Landroid_view_View_Lorg_json_JSONObject_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_IAvidViewWalker_Z == null)
				cb_iterateChildren_Landroid_view_View_Lorg_json_JSONObject_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_IAvidViewWalker_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IterateChildren_Landroid_view_View_Lorg_json_JSONObject_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_IAvidViewWalker_Z);
			return cb_iterateChildren_Landroid_view_View_Lorg_json_JSONObject_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_IAvidViewWalker_Z;
		}

		static void n_IterateChildren_Landroid_view_View_Lorg_json_JSONObject_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_IAvidViewWalker_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessor __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p1 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessorAvidViewWalker p2 = (global::Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessorAvidViewWalker)global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessorAvidViewWalker> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.IterateChildren (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_iterateChildren_Landroid_view_View_Lorg_json_JSONObject_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_IAvidViewWalker_Z;
		public unsafe void IterateChildren (global::Android.Views.View p0, global::Org.Json.JSONObject p1, global::Com.Integralads.Avid.Library.Inmobi.Processing.IAvidNodeProcessorAvidViewWalker p2, bool p3)
		{
			if (id_iterateChildren_Landroid_view_View_Lorg_json_JSONObject_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_IAvidViewWalker_Z == IntPtr.Zero)
				id_iterateChildren_Landroid_view_View_Lorg_json_JSONObject_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_IAvidViewWalker_Z = JNIEnv.GetMethodID (class_ref, "iterateChildren", "(Landroid/view/View;Lorg/json/JSONObject;Lcom/integralads/avid/library/inmobi/processing/IAvidNodeProcessor$IAvidViewWalker;Z)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_iterateChildren_Landroid_view_View_Lorg_json_JSONObject_Lcom_integralads_avid_library_inmobi_processing_IAvidNodeProcessor_IAvidViewWalker_Z, __args);
		}

	}

}
