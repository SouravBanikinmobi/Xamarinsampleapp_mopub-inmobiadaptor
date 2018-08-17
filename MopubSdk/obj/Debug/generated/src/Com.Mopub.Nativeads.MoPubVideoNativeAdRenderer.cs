using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubVideoNativeAdRenderer']"
	[global::Android.Runtime.Register ("com/mopub/nativeads/MoPubVideoNativeAdRenderer", DoNotGenerateAcw=true)]
	public partial class MoPubVideoNativeAdRenderer : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/nativeads/MoPubVideoNativeAdRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubVideoNativeAdRenderer); }
		}

		protected MoPubVideoNativeAdRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mopub_nativeads_MediaViewBinder_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubVideoNativeAdRenderer']/constructor[@name='MoPubVideoNativeAdRenderer' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.MediaViewBinder']]"
		[Register (".ctor", "(Lcom/mopub/nativeads/MediaViewBinder;)V", "")]
		public unsafe MoPubVideoNativeAdRenderer (global::Com.Mopub.Nativeads.MediaViewBinder p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MoPubVideoNativeAdRenderer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/mopub/nativeads/MediaViewBinder;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/mopub/nativeads/MediaViewBinder;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_nativeads_MediaViewBinder_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_nativeads_MediaViewBinder_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/nativeads/MediaViewBinder;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_nativeads_MediaViewBinder_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mopub_nativeads_MediaViewBinder_, __args);
			} finally {
			}
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
			global::Com.Mopub.Nativeads.MoPubVideoNativeAdRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubVideoNativeAdRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p1 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAdView (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createAdView_Landroid_app_Activity_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubVideoNativeAdRenderer']/method[@name='createAdView' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.view.ViewGroup']]"
		[Register ("createAdView", "(Landroid/app/Activity;Landroid/view/ViewGroup;)Landroid/view/View;", "GetCreateAdView_Landroid_app_Activity_Landroid_view_ViewGroup_Handler")]
		public virtual unsafe global::Android.Views.View CreateAdView (global::Android.App.Activity p0, global::Android.Views.ViewGroup p1)
		{
			if (id_createAdView_Landroid_app_Activity_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_createAdView_Landroid_app_Activity_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "createAdView", "(Landroid/app/Activity;Landroid/view/ViewGroup;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Views.View __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createAdView_Landroid_app_Activity_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createAdView", "(Landroid/app/Activity;Landroid/view/ViewGroup;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
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
			global::Com.Mopub.Nativeads.MoPubVideoNativeAdRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubVideoNativeAdRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.BaseNativeAd p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.BaseNativeAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Supports (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_supports_Lcom_mopub_nativeads_BaseNativeAd_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubVideoNativeAdRenderer']/method[@name='supports' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.BaseNativeAd']]"
		[Register ("supports", "(Lcom/mopub/nativeads/BaseNativeAd;)Z", "GetSupports_Lcom_mopub_nativeads_BaseNativeAd_Handler")]
		public virtual unsafe bool Supports (global::Com.Mopub.Nativeads.BaseNativeAd p0)
		{
			if (id_supports_Lcom_mopub_nativeads_BaseNativeAd_ == IntPtr.Zero)
				id_supports_Lcom_mopub_nativeads_BaseNativeAd_ = JNIEnv.GetMethodID (class_ref, "supports", "(Lcom/mopub/nativeads/BaseNativeAd;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_supports_Lcom_mopub_nativeads_BaseNativeAd_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "supports", "(Lcom/mopub/nativeads/BaseNativeAd;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
