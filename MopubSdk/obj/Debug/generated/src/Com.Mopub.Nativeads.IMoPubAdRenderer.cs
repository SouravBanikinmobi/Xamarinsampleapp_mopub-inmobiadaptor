using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='MoPubAdRenderer']"
	[Register ("com/mopub/nativeads/MoPubAdRenderer", "", "Com.Mopub.Nativeads.IMoPubAdRendererInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.mopub.nativeads.BaseNativeAd"})]
	public partial interface IMoPubAdRenderer : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='MoPubAdRenderer']/method[@name='createAdView' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.view.ViewGroup']]"
		[Register ("createAdView", "(Landroid/app/Activity;Landroid/view/ViewGroup;)Landroid/view/View;", "GetCreateAdView_Landroid_app_Activity_Landroid_view_ViewGroup_Handler:Com.Mopub.Nativeads.IMoPubAdRendererInvoker, MopubSdk")]
		global::Android.Views.View CreateAdView (global::Android.App.Activity p0, global::Android.Views.ViewGroup p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='MoPubAdRenderer']/method[@name='renderAdView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='T']]"
		[Register ("renderAdView", "(Landroid/view/View;Lcom/mopub/nativeads/BaseNativeAd;)V", "GetRenderAdView_Landroid_view_View_Lcom_mopub_nativeads_BaseNativeAd_Handler:Com.Mopub.Nativeads.IMoPubAdRendererInvoker, MopubSdk")]
		void RenderAdView (global::Android.Views.View p0, global::Java.Lang.Object p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='MoPubAdRenderer']/method[@name='supports' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.BaseNativeAd']]"
		[Register ("supports", "(Lcom/mopub/nativeads/BaseNativeAd;)Z", "GetSupports_Lcom_mopub_nativeads_BaseNativeAd_Handler:Com.Mopub.Nativeads.IMoPubAdRendererInvoker, MopubSdk")]
		bool Supports (global::Com.Mopub.Nativeads.BaseNativeAd p0);

	}

	[global::Android.Runtime.Register ("com/mopub/nativeads/MoPubAdRenderer", DoNotGenerateAcw=true)]
	internal class IMoPubAdRendererInvoker : global::Java.Lang.Object, IMoPubAdRenderer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/nativeads/MoPubAdRenderer");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMoPubAdRendererInvoker); }
		}

		IntPtr class_ref;

		public static IMoPubAdRenderer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMoPubAdRenderer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mopub.nativeads.MoPubAdRenderer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMoPubAdRendererInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createAdView_Landroid_app_Activity_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetCreateAdView_Landroid_app_Activity_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_createAdView_Landroid_app_Activity_Landroid_view_ViewGroup_ == null)
				cb_createAdView_Landroid_app_Activity_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateAdView_Landroid_app_Activity_Landroid_view_ViewGroup_);
			return cb_createAdView_Landroid_app_Activity_Landroid_view_ViewGroup_;
		}

		static IntPtr n_CreateAdView_Landroid_app_Activity_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Nativeads.IMoPubAdRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IMoPubAdRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p1 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAdView (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createAdView_Landroid_app_Activity_Landroid_view_ViewGroup_;
		public unsafe global::Android.Views.View CreateAdView (global::Android.App.Activity p0, global::Android.Views.ViewGroup p1)
		{
			if (id_createAdView_Landroid_app_Activity_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_createAdView_Landroid_app_Activity_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "createAdView", "(Landroid/app/Activity;Landroid/view/ViewGroup;)Landroid/view/View;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createAdView_Landroid_app_Activity_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_renderAdView_Landroid_view_View_Lcom_mopub_nativeads_BaseNativeAd_;
#pragma warning disable 0169
		static Delegate GetRenderAdView_Landroid_view_View_Lcom_mopub_nativeads_BaseNativeAd_Handler ()
		{
			if (cb_renderAdView_Landroid_view_View_Lcom_mopub_nativeads_BaseNativeAd_ == null)
				cb_renderAdView_Landroid_view_View_Lcom_mopub_nativeads_BaseNativeAd_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RenderAdView_Landroid_view_View_Lcom_mopub_nativeads_BaseNativeAd_);
			return cb_renderAdView_Landroid_view_View_Lcom_mopub_nativeads_BaseNativeAd_;
		}

		static void n_RenderAdView_Landroid_view_View_Lcom_mopub_nativeads_BaseNativeAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Nativeads.IMoPubAdRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IMoPubAdRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RenderAdView (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_renderAdView_Landroid_view_View_Lcom_mopub_nativeads_BaseNativeAd_;
		public unsafe void RenderAdView (global::Android.Views.View p0, global::Java.Lang.Object p1)
		{
			if (id_renderAdView_Landroid_view_View_Lcom_mopub_nativeads_BaseNativeAd_ == IntPtr.Zero)
				id_renderAdView_Landroid_view_View_Lcom_mopub_nativeads_BaseNativeAd_ = JNIEnv.GetMethodID (class_ref, "renderAdView", "(Landroid/view/View;Lcom/mopub/nativeads/BaseNativeAd;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_renderAdView_Landroid_view_View_Lcom_mopub_nativeads_BaseNativeAd_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_supports_Lcom_mopub_nativeads_BaseNativeAd_;
#pragma warning disable 0169
		static Delegate GetSupports_Lcom_mopub_nativeads_BaseNativeAd_Handler ()
		{
			if (cb_supports_Lcom_mopub_nativeads_BaseNativeAd_ == null)
				cb_supports_Lcom_mopub_nativeads_BaseNativeAd_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Supports_Lcom_mopub_nativeads_BaseNativeAd_);
			return cb_supports_Lcom_mopub_nativeads_BaseNativeAd_;
		}

		static bool n_Supports_Lcom_mopub_nativeads_BaseNativeAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.IMoPubAdRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IMoPubAdRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.BaseNativeAd p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.BaseNativeAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Supports (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_supports_Lcom_mopub_nativeads_BaseNativeAd_;
		public unsafe bool Supports (global::Com.Mopub.Nativeads.BaseNativeAd p0)
		{
			if (id_supports_Lcom_mopub_nativeads_BaseNativeAd_ == IntPtr.Zero)
				id_supports_Lcom_mopub_nativeads_BaseNativeAd_ = JNIEnv.GetMethodID (class_ref, "supports", "(Lcom/mopub/nativeads/BaseNativeAd;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_supports_Lcom_mopub_nativeads_BaseNativeAd_, __args);
			return __ret;
		}

	}

}
