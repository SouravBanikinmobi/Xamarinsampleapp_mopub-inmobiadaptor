using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']"
	[global::Android.Runtime.Register ("com/mopub/nativeads/MoPubStreamAdPlacer", DoNotGenerateAcw=true)]
	public partial class MoPubStreamAdPlacer : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/field[@name='CONTENT_VIEW_TYPE']"
		[Register ("CONTENT_VIEW_TYPE")]
		public const int ContentViewType = (int) 0;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/nativeads/MoPubStreamAdPlacer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubStreamAdPlacer); }
		}

		protected MoPubStreamAdPlacer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_Lcom_mopub_nativeads_MoPubNativeAdPositioning_MoPubClientPositioning_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/constructor[@name='MoPubStreamAdPlacer' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.mopub.nativeads.MoPubNativeAdPositioning.MoPubClientPositioning']]"
		[Register (".ctor", "(Landroid/app/Activity;Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubClientPositioning;)V", "")]
		public unsafe MoPubStreamAdPlacer (global::Android.App.Activity p0, global::Com.Mopub.Nativeads.MoPubNativeAdPositioning.MoPubClientPositioning p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MoPubStreamAdPlacer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/app/Activity;Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubClientPositioning;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubClientPositioning;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_Lcom_mopub_nativeads_MoPubNativeAdPositioning_MoPubClientPositioning_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_Lcom_mopub_nativeads_MoPubNativeAdPositioning_MoPubClientPositioning_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubClientPositioning;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_Lcom_mopub_nativeads_MoPubNativeAdPositioning_MoPubClientPositioning_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_Lcom_mopub_nativeads_MoPubNativeAdPositioning_MoPubClientPositioning_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_app_Activity_Lcom_mopub_nativeads_MoPubNativeAdPositioning_MoPubServerPositioning_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/constructor[@name='MoPubStreamAdPlacer' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.mopub.nativeads.MoPubNativeAdPositioning.MoPubServerPositioning']]"
		[Register (".ctor", "(Landroid/app/Activity;Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubServerPositioning;)V", "")]
		public unsafe MoPubStreamAdPlacer (global::Android.App.Activity p0, global::Com.Mopub.Nativeads.MoPubNativeAdPositioning.MoPubServerPositioning p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MoPubStreamAdPlacer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/app/Activity;Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubServerPositioning;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubServerPositioning;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_Lcom_mopub_nativeads_MoPubNativeAdPositioning_MoPubServerPositioning_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_Lcom_mopub_nativeads_MoPubNativeAdPositioning_MoPubServerPositioning_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubServerPositioning;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_Lcom_mopub_nativeads_MoPubNativeAdPositioning_MoPubServerPositioning_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_Lcom_mopub_nativeads_MoPubNativeAdPositioning_MoPubServerPositioning_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_app_Activity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/constructor[@name='MoPubStreamAdPlacer' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register (".ctor", "(Landroid/app/Activity;)V", "")]
		public unsafe MoPubStreamAdPlacer (global::Android.App.Activity p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MoPubStreamAdPlacer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/app/Activity;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static Delegate cb_getAdViewTypeCount;
#pragma warning disable 0169
		static Delegate GetGetAdViewTypeCountHandler ()
		{
			if (cb_getAdViewTypeCount == null)
				cb_getAdViewTypeCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAdViewTypeCount);
			return cb_getAdViewTypeCount;
		}

		static int n_GetAdViewTypeCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdViewTypeCount;
		}
#pragma warning restore 0169

		static IntPtr id_getAdViewTypeCount;
		public virtual unsafe int AdViewTypeCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='getAdViewTypeCount' and count(parameter)=0]"
			[Register ("getAdViewTypeCount", "()I", "GetGetAdViewTypeCountHandler")]
			get {
				if (id_getAdViewTypeCount == IntPtr.Zero)
					id_getAdViewTypeCount = JNIEnv.GetMethodID (class_ref, "getAdViewTypeCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdViewTypeCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdViewTypeCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_bindAdView_Lcom_mopub_nativeads_NativeAd_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetBindAdView_Lcom_mopub_nativeads_NativeAd_Landroid_view_View_Handler ()
		{
			if (cb_bindAdView_Lcom_mopub_nativeads_NativeAd_Landroid_view_View_ == null)
				cb_bindAdView_Lcom_mopub_nativeads_NativeAd_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_BindAdView_Lcom_mopub_nativeads_NativeAd_Landroid_view_View_);
			return cb_bindAdView_Lcom_mopub_nativeads_NativeAd_Landroid_view_View_;
		}

		static void n_BindAdView_Lcom_mopub_nativeads_NativeAd_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.NativeAd p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.BindAdView (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_bindAdView_Lcom_mopub_nativeads_NativeAd_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='bindAdView' and count(parameter)=2 and parameter[1][@type='com.mopub.nativeads.NativeAd'] and parameter[2][@type='android.view.View']]"
		[Register ("bindAdView", "(Lcom/mopub/nativeads/NativeAd;Landroid/view/View;)V", "GetBindAdView_Lcom_mopub_nativeads_NativeAd_Landroid_view_View_Handler")]
		public virtual unsafe void BindAdView (global::Com.Mopub.Nativeads.NativeAd p0, global::Android.Views.View p1)
		{
			if (id_bindAdView_Lcom_mopub_nativeads_NativeAd_Landroid_view_View_ == IntPtr.Zero)
				id_bindAdView_Lcom_mopub_nativeads_NativeAd_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "bindAdView", "(Lcom/mopub/nativeads/NativeAd;Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindAdView_Lcom_mopub_nativeads_NativeAd_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bindAdView", "(Lcom/mopub/nativeads/NativeAd;Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_clearAds;
#pragma warning disable 0169
		static Delegate GetClearAdsHandler ()
		{
			if (cb_clearAds == null)
				cb_clearAds = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearAds);
			return cb_clearAds;
		}

		static void n_ClearAds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAds ();
		}
#pragma warning restore 0169

		static IntPtr id_clearAds;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='clearAds' and count(parameter)=0]"
		[Register ("clearAds", "()V", "GetClearAdsHandler")]
		public virtual unsafe void ClearAds ()
		{
			if (id_clearAds == IntPtr.Zero)
				id_clearAds = JNIEnv.GetMethodID (class_ref, "clearAds", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearAds);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearAds", "()V"));
			} finally {
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroy", "()V"));
			} finally {
			}
		}

		static Delegate cb_getAdData_I;
#pragma warning disable 0169
		static Delegate GetGetAdData_IHandler ()
		{
			if (cb_getAdData_I == null)
				cb_getAdData_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetAdData_I);
			return cb_getAdData_I;
		}

		static IntPtr n_GetAdData_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetAdData (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getAdData_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='getAdData' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAdData", "(I)Ljava/lang/Object;", "GetGetAdData_IHandler")]
		public virtual unsafe global::Java.Lang.Object GetAdData (int p0)
		{
			if (id_getAdData_I == IntPtr.Zero)
				id_getAdData_I = JNIEnv.GetMethodID (class_ref, "getAdData", "(I)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdData_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdData", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getAdRendererForViewType_I;
#pragma warning disable 0169
		static Delegate GetGetAdRendererForViewType_IHandler ()
		{
			if (cb_getAdRendererForViewType_I == null)
				cb_getAdRendererForViewType_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetAdRendererForViewType_I);
			return cb_getAdRendererForViewType_I;
		}

		static IntPtr n_GetAdRendererForViewType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetAdRendererForViewType (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getAdRendererForViewType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='getAdRendererForViewType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAdRendererForViewType", "(I)Lcom/mopub/nativeads/MoPubAdRenderer;", "GetGetAdRendererForViewType_IHandler")]
		public virtual unsafe global::Com.Mopub.Nativeads.IMoPubAdRenderer GetAdRendererForViewType (int p0)
		{
			if (id_getAdRendererForViewType_I == IntPtr.Zero)
				id_getAdRendererForViewType_I = JNIEnv.GetMethodID (class_ref, "getAdRendererForViewType", "(I)Lcom/mopub/nativeads/MoPubAdRenderer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IMoPubAdRenderer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdRendererForViewType_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IMoPubAdRenderer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdRendererForViewType", "(I)Lcom/mopub/nativeads/MoPubAdRenderer;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getAdView_ILandroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetAdView_ILandroid_view_View_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_getAdView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
				cb_getAdView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetAdView_ILandroid_view_View_Landroid_view_ViewGroup_);
			return cb_getAdView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetAdView_ILandroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAdView (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAdView_ILandroid_view_View_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='getAdView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getAdView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetAdView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
		public virtual unsafe global::Android.Views.View GetAdView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2)
		{
			if (id_getAdView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getAdView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getAdView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Android.Views.View __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdView_ILandroid_view_View_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getAdViewType_I;
#pragma warning disable 0169
		static Delegate GetGetAdViewType_IHandler ()
		{
			if (cb_getAdViewType_I == null)
				cb_getAdViewType_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetAdViewType_I);
			return cb_getAdViewType_I;
		}

		static int n_GetAdViewType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetAdViewType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getAdViewType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='getAdViewType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAdViewType", "(I)I", "GetGetAdViewType_IHandler")]
		public virtual unsafe int GetAdViewType (int p0)
		{
			if (id_getAdViewType_I == IntPtr.Zero)
				id_getAdViewType_I = JNIEnv.GetMethodID (class_ref, "getAdViewType", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdViewType_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdViewType", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getAdjustedCount_I;
#pragma warning disable 0169
		static Delegate GetGetAdjustedCount_IHandler ()
		{
			if (cb_getAdjustedCount_I == null)
				cb_getAdjustedCount_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetAdjustedCount_I);
			return cb_getAdjustedCount_I;
		}

		static int n_GetAdjustedCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetAdjustedCount (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getAdjustedCount_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='getAdjustedCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAdjustedCount", "(I)I", "GetGetAdjustedCount_IHandler")]
		public virtual unsafe int GetAdjustedCount (int p0)
		{
			if (id_getAdjustedCount_I == IntPtr.Zero)
				id_getAdjustedCount_I = JNIEnv.GetMethodID (class_ref, "getAdjustedCount", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdjustedCount_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdjustedCount", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getAdjustedPosition_I;
#pragma warning disable 0169
		static Delegate GetGetAdjustedPosition_IHandler ()
		{
			if (cb_getAdjustedPosition_I == null)
				cb_getAdjustedPosition_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetAdjustedPosition_I);
			return cb_getAdjustedPosition_I;
		}

		static int n_GetAdjustedPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetAdjustedPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getAdjustedPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='getAdjustedPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAdjustedPosition", "(I)I", "GetGetAdjustedPosition_IHandler")]
		public virtual unsafe int GetAdjustedPosition (int p0)
		{
			if (id_getAdjustedPosition_I == IntPtr.Zero)
				id_getAdjustedPosition_I = JNIEnv.GetMethodID (class_ref, "getAdjustedPosition", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdjustedPosition_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdjustedPosition", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getOriginalCount_I;
#pragma warning disable 0169
		static Delegate GetGetOriginalCount_IHandler ()
		{
			if (cb_getOriginalCount_I == null)
				cb_getOriginalCount_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetOriginalCount_I);
			return cb_getOriginalCount_I;
		}

		static int n_GetOriginalCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetOriginalCount (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getOriginalCount_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='getOriginalCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getOriginalCount", "(I)I", "GetGetOriginalCount_IHandler")]
		public virtual unsafe int GetOriginalCount (int p0)
		{
			if (id_getOriginalCount_I == IntPtr.Zero)
				id_getOriginalCount_I = JNIEnv.GetMethodID (class_ref, "getOriginalCount", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOriginalCount_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOriginalCount", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getOriginalPosition_I;
#pragma warning disable 0169
		static Delegate GetGetOriginalPosition_IHandler ()
		{
			if (cb_getOriginalPosition_I == null)
				cb_getOriginalPosition_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetOriginalPosition_I);
			return cb_getOriginalPosition_I;
		}

		static int n_GetOriginalPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetOriginalPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getOriginalPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='getOriginalPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getOriginalPosition", "(I)I", "GetGetOriginalPosition_IHandler")]
		public virtual unsafe int GetOriginalPosition (int p0)
		{
			if (id_getOriginalPosition_I == IntPtr.Zero)
				id_getOriginalPosition_I = JNIEnv.GetMethodID (class_ref, "getOriginalPosition", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOriginalPosition_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOriginalPosition", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_insertItem_I;
#pragma warning disable 0169
		static Delegate GetInsertItem_IHandler ()
		{
			if (cb_insertItem_I == null)
				cb_insertItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_InsertItem_I);
			return cb_insertItem_I;
		}

		static void n_InsertItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InsertItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_insertItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='insertItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("insertItem", "(I)V", "GetInsertItem_IHandler")]
		public virtual unsafe void InsertItem (int p0)
		{
			if (id_insertItem_I == IntPtr.Zero)
				id_insertItem_I = JNIEnv.GetMethodID (class_ref, "insertItem", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_insertItem_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insertItem", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_isAd_I;
#pragma warning disable 0169
		static Delegate GetIsAd_IHandler ()
		{
			if (cb_isAd_I == null)
				cb_isAd_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsAd_I);
			return cb_isAd_I;
		}

		static bool n_IsAd_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAd (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isAd_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='isAd' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isAd", "(I)Z", "GetIsAd_IHandler")]
		public virtual unsafe bool IsAd (int p0)
		{
			if (id_isAd_I == IntPtr.Zero)
				id_isAd_I = JNIEnv.GetMethodID (class_ref, "isAd", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAd_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAd", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_loadAds_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadAds_Ljava_lang_String_Handler ()
		{
			if (cb_loadAds_Ljava_lang_String_ == null)
				cb_loadAds_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadAds_Ljava_lang_String_);
			return cb_loadAds_Ljava_lang_String_;
		}

		static void n_LoadAds_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadAds (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadAds_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='loadAds' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadAds", "(Ljava/lang/String;)V", "GetLoadAds_Ljava_lang_String_Handler")]
		public virtual unsafe void LoadAds (string p0)
		{
			if (id_loadAds_Ljava_lang_String_ == IntPtr.Zero)
				id_loadAds_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadAds", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadAds_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadAds", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_;
#pragma warning disable 0169
		static Delegate GetLoadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_Handler ()
		{
			if (cb_loadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_ == null)
				cb_loadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_);
			return cb_loadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_;
		}

		static void n_LoadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.RequestParameters p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.RequestParameters> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LoadAds (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_loadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='loadAds' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.nativeads.RequestParameters']]"
		[Register ("loadAds", "(Ljava/lang/String;Lcom/mopub/nativeads/RequestParameters;)V", "GetLoadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_Handler")]
		public virtual unsafe void LoadAds (string p0, global::Com.Mopub.Nativeads.RequestParameters p1)
		{
			if (id_loadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_ == IntPtr.Zero)
				id_loadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_ = JNIEnv.GetMethodID (class_ref, "loadAds", "(Ljava/lang/String;Lcom/mopub/nativeads/RequestParameters;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadAds", "(Ljava/lang/String;Lcom/mopub/nativeads/RequestParameters;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_moveItem_II;
#pragma warning disable 0169
		static Delegate GetMoveItem_IIHandler ()
		{
			if (cb_moveItem_II == null)
				cb_moveItem_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_MoveItem_II);
			return cb_moveItem_II;
		}

		static void n_MoveItem_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MoveItem (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_moveItem_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='moveItem' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("moveItem", "(II)V", "GetMoveItem_IIHandler")]
		public virtual unsafe void MoveItem (int p0, int p1)
		{
			if (id_moveItem_II == IntPtr.Zero)
				id_moveItem_II = JNIEnv.GetMethodID (class_ref, "moveItem", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_moveItem_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveItem", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_placeAdsInRange_II;
#pragma warning disable 0169
		static Delegate GetPlaceAdsInRange_IIHandler ()
		{
			if (cb_placeAdsInRange_II == null)
				cb_placeAdsInRange_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_PlaceAdsInRange_II);
			return cb_placeAdsInRange_II;
		}

		static void n_PlaceAdsInRange_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PlaceAdsInRange (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_placeAdsInRange_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='placeAdsInRange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("placeAdsInRange", "(II)V", "GetPlaceAdsInRange_IIHandler")]
		public virtual unsafe void PlaceAdsInRange (int p0, int p1)
		{
			if (id_placeAdsInRange_II == IntPtr.Zero)
				id_placeAdsInRange_II = JNIEnv.GetMethodID (class_ref, "placeAdsInRange", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_placeAdsInRange_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "placeAdsInRange", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_;
#pragma warning disable 0169
		static Delegate GetRegisterAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_Handler ()
		{
			if (cb_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_ == null)
				cb_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_);
			return cb_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_;
		}

		static void n_RegisterAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.IMoPubAdRenderer p0 = (global::Com.Mopub.Nativeads.IMoPubAdRenderer)global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IMoPubAdRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterAdRenderer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='registerAdRenderer' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.MoPubAdRenderer']]"
		[Register ("registerAdRenderer", "(Lcom/mopub/nativeads/MoPubAdRenderer;)V", "GetRegisterAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_Handler")]
		public virtual unsafe void RegisterAdRenderer (global::Com.Mopub.Nativeads.IMoPubAdRenderer p0)
		{
			if (id_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_ == IntPtr.Zero)
				id_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_ = JNIEnv.GetMethodID (class_ref, "registerAdRenderer", "(Lcom/mopub/nativeads/MoPubAdRenderer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerAdRenderer", "(Lcom/mopub/nativeads/MoPubAdRenderer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeAdsInRange_II;
#pragma warning disable 0169
		static Delegate GetRemoveAdsInRange_IIHandler ()
		{
			if (cb_removeAdsInRange_II == null)
				cb_removeAdsInRange_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_RemoveAdsInRange_II);
			return cb_removeAdsInRange_II;
		}

		static int n_RemoveAdsInRange_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveAdsInRange (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_removeAdsInRange_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='removeAdsInRange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("removeAdsInRange", "(II)I", "GetRemoveAdsInRange_IIHandler")]
		public virtual unsafe int RemoveAdsInRange (int p0, int p1)
		{
			if (id_removeAdsInRange_II == IntPtr.Zero)
				id_removeAdsInRange_II = JNIEnv.GetMethodID (class_ref, "removeAdsInRange", "(II)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_removeAdsInRange_II, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAdsInRange", "(II)I"), __args);
			} finally {
			}
		}

		static Delegate cb_removeItem_I;
#pragma warning disable 0169
		static Delegate GetRemoveItem_IHandler ()
		{
			if (cb_removeItem_I == null)
				cb_removeItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveItem_I);
			return cb_removeItem_I;
		}

		static void n_RemoveItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='removeItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeItem", "(I)V", "GetRemoveItem_IHandler")]
		public virtual unsafe void RemoveItem (int p0)
		{
			if (id_removeItem_I == IntPtr.Zero)
				id_removeItem_I = JNIEnv.GetMethodID (class_ref, "removeItem", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeItem_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeItem", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAdLoadedListener_Lcom_mopub_nativeads_MoPubNativeAdLoadedListener_;
#pragma warning disable 0169
		static Delegate GetSetAdLoadedListener_Lcom_mopub_nativeads_MoPubNativeAdLoadedListener_Handler ()
		{
			if (cb_setAdLoadedListener_Lcom_mopub_nativeads_MoPubNativeAdLoadedListener_ == null)
				cb_setAdLoadedListener_Lcom_mopub_nativeads_MoPubNativeAdLoadedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdLoadedListener_Lcom_mopub_nativeads_MoPubNativeAdLoadedListener_);
			return cb_setAdLoadedListener_Lcom_mopub_nativeads_MoPubNativeAdLoadedListener_;
		}

		static void n_SetAdLoadedListener_Lcom_mopub_nativeads_MoPubNativeAdLoadedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListener p0 = (global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAdLoadedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAdLoadedListener_Lcom_mopub_nativeads_MoPubNativeAdLoadedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='setAdLoadedListener' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.MoPubNativeAdLoadedListener']]"
		[Register ("setAdLoadedListener", "(Lcom/mopub/nativeads/MoPubNativeAdLoadedListener;)V", "GetSetAdLoadedListener_Lcom_mopub_nativeads_MoPubNativeAdLoadedListener_Handler")]
		public virtual unsafe void SetAdLoadedListener (global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListener p0)
		{
			if (id_setAdLoadedListener_Lcom_mopub_nativeads_MoPubNativeAdLoadedListener_ == IntPtr.Zero)
				id_setAdLoadedListener_Lcom_mopub_nativeads_MoPubNativeAdLoadedListener_ = JNIEnv.GetMethodID (class_ref, "setAdLoadedListener", "(Lcom/mopub/nativeads/MoPubNativeAdLoadedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdLoadedListener_Lcom_mopub_nativeads_MoPubNativeAdLoadedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdLoadedListener", "(Lcom/mopub/nativeads/MoPubNativeAdLoadedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setItemCount_I;
#pragma warning disable 0169
		static Delegate GetSetItemCount_IHandler ()
		{
			if (cb_setItemCount_I == null)
				cb_setItemCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetItemCount_I);
			return cb_setItemCount_I;
		}

		static void n_SetItemCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.MoPubStreamAdPlacer __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubStreamAdPlacer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetItemCount (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setItemCount_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubStreamAdPlacer']/method[@name='setItemCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setItemCount", "(I)V", "GetSetItemCount_IHandler")]
		public virtual unsafe void SetItemCount (int p0)
		{
			if (id_setItemCount_I == IntPtr.Zero)
				id_setItemCount_I = JNIEnv.GetMethodID (class_ref, "setItemCount", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemCount_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItemCount", "(I)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Mopub.Nativeads.IMoPubNativeAdLoadedListener"
		public event EventHandler<global::Com.Mopub.Nativeads.AdLoadedEventArgs> AdLoaded {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListener, global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerImplementor>(
						ref weak_implementor_SetAdLoadedListener,
						__CreateIMoPubNativeAdLoadedListenerImplementor,
						SetAdLoadedListener,
						__h => __h.OnAdLoadedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListener, global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerImplementor>(
						ref weak_implementor_SetAdLoadedListener,
						global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerImplementor.__IsEmpty,
						__v => SetAdLoadedListener (null),
						__h => __h.OnAdLoadedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Nativeads.AdRemovedEventArgs> AdRemoved {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListener, global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerImplementor>(
						ref weak_implementor_SetAdLoadedListener,
						__CreateIMoPubNativeAdLoadedListenerImplementor,
						SetAdLoadedListener,
						__h => __h.OnAdRemovedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListener, global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerImplementor>(
						ref weak_implementor_SetAdLoadedListener,
						global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerImplementor.__IsEmpty,
						__v => SetAdLoadedListener (null),
						__h => __h.OnAdRemovedHandler -= value);
			}
		}

		WeakReference weak_implementor_SetAdLoadedListener;

		global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerImplementor __CreateIMoPubNativeAdLoadedListenerImplementor ()
		{
			return new global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerImplementor (this);
		}
#endregion
	}
}
