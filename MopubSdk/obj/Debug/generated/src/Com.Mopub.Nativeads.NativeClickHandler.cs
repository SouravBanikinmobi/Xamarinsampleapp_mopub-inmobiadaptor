using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeClickHandler']"
	[global::Android.Runtime.Register ("com/mopub/nativeads/NativeClickHandler", DoNotGenerateAcw=true)]
	public partial class NativeClickHandler : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/nativeads/NativeClickHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeClickHandler); }
		}

		protected NativeClickHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeClickHandler']/constructor[@name='NativeClickHandler' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe NativeClickHandler (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (NativeClickHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_clearOnClickListener_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetClearOnClickListener_Landroid_view_View_Handler ()
		{
			if (cb_clearOnClickListener_Landroid_view_View_ == null)
				cb_clearOnClickListener_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ClearOnClickListener_Landroid_view_View_);
			return cb_clearOnClickListener_Landroid_view_View_;
		}

		static void n_ClearOnClickListener_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.NativeClickHandler __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeClickHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClearOnClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_clearOnClickListener_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeClickHandler']/method[@name='clearOnClickListener' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("clearOnClickListener", "(Landroid/view/View;)V", "GetClearOnClickListener_Landroid_view_View_Handler")]
		public virtual unsafe void ClearOnClickListener (global::Android.Views.View p0)
		{
			if (id_clearOnClickListener_Landroid_view_View_ == IntPtr.Zero)
				id_clearOnClickListener_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "clearOnClickListener", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearOnClickListener_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearOnClickListener", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_openClickDestinationUrl_Ljava_lang_String_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOpenClickDestinationUrl_Ljava_lang_String_Landroid_view_View_Handler ()
		{
			if (cb_openClickDestinationUrl_Ljava_lang_String_Landroid_view_View_ == null)
				cb_openClickDestinationUrl_Ljava_lang_String_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OpenClickDestinationUrl_Ljava_lang_String_Landroid_view_View_);
			return cb_openClickDestinationUrl_Ljava_lang_String_Landroid_view_View_;
		}

		static void n_OpenClickDestinationUrl_Ljava_lang_String_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Nativeads.NativeClickHandler __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeClickHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OpenClickDestinationUrl (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_openClickDestinationUrl_Ljava_lang_String_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeClickHandler']/method[@name='openClickDestinationUrl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.view.View']]"
		[Register ("openClickDestinationUrl", "(Ljava/lang/String;Landroid/view/View;)V", "GetOpenClickDestinationUrl_Ljava_lang_String_Landroid_view_View_Handler")]
		public virtual unsafe void OpenClickDestinationUrl (string p0, global::Android.Views.View p1)
		{
			if (id_openClickDestinationUrl_Ljava_lang_String_Landroid_view_View_ == IntPtr.Zero)
				id_openClickDestinationUrl_Ljava_lang_String_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "openClickDestinationUrl", "(Ljava/lang/String;Landroid/view/View;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_openClickDestinationUrl_Ljava_lang_String_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openClickDestinationUrl", "(Ljava/lang/String;Landroid/view/View;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setOnClickListener_Landroid_view_View_Lcom_mopub_nativeads_ClickInterface_;
#pragma warning disable 0169
		static Delegate GetSetOnClickListener_Landroid_view_View_Lcom_mopub_nativeads_ClickInterface_Handler ()
		{
			if (cb_setOnClickListener_Landroid_view_View_Lcom_mopub_nativeads_ClickInterface_ == null)
				cb_setOnClickListener_Landroid_view_View_Lcom_mopub_nativeads_ClickInterface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnClickListener_Landroid_view_View_Lcom_mopub_nativeads_ClickInterface_);
			return cb_setOnClickListener_Landroid_view_View_Lcom_mopub_nativeads_ClickInterface_;
		}

		static void n_SetOnClickListener_Landroid_view_View_Lcom_mopub_nativeads_ClickInterface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Nativeads.NativeClickHandler __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeClickHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.IClickInterface p1 = (global::Com.Mopub.Nativeads.IClickInterface)global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IClickInterface> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetOnClickListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setOnClickListener_Landroid_view_View_Lcom_mopub_nativeads_ClickInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeClickHandler']/method[@name='setOnClickListener' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.mopub.nativeads.ClickInterface']]"
		[Register ("setOnClickListener", "(Landroid/view/View;Lcom/mopub/nativeads/ClickInterface;)V", "GetSetOnClickListener_Landroid_view_View_Lcom_mopub_nativeads_ClickInterface_Handler")]
		public virtual unsafe void SetOnClickListener (global::Android.Views.View p0, global::Com.Mopub.Nativeads.IClickInterface p1)
		{
			if (id_setOnClickListener_Landroid_view_View_Lcom_mopub_nativeads_ClickInterface_ == IntPtr.Zero)
				id_setOnClickListener_Landroid_view_View_Lcom_mopub_nativeads_ClickInterface_ = JNIEnv.GetMethodID (class_ref, "setOnClickListener", "(Landroid/view/View;Lcom/mopub/nativeads/ClickInterface;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnClickListener_Landroid_view_View_Lcom_mopub_nativeads_ClickInterface_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnClickListener", "(Landroid/view/View;Lcom/mopub/nativeads/ClickInterface;)V"), __args);
			} finally {
			}
		}

	}
}
