using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Moat.Analytics.Mobile.Inm {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/interface[@name='ReactiveVideoTracker']"
	[Register ("com/moat/analytics/mobile/inm/ReactiveVideoTracker", "", "Com.Moat.Analytics.Mobile.Inm.IReactiveVideoTrackerInvoker")]
	public partial interface IReactiveVideoTracker : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/interface[@name='ReactiveVideoTracker']/method[@name='changeTargetView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("changeTargetView", "(Landroid/view/View;)V", "GetChangeTargetView_Landroid_view_View_Handler:Com.Moat.Analytics.Mobile.Inm.IReactiveVideoTrackerInvoker, Jars")]
		void ChangeTargetView (global::Android.Views.View p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/interface[@name='ReactiveVideoTracker']/method[@name='dispatchEvent' and count(parameter)=1 and parameter[1][@type='com.moat.analytics.mobile.inm.MoatAdEvent']]"
		[Register ("dispatchEvent", "(Lcom/moat/analytics/mobile/inm/MoatAdEvent;)V", "GetDispatchEvent_Lcom_moat_analytics_mobile_inm_MoatAdEvent_Handler:Com.Moat.Analytics.Mobile.Inm.IReactiveVideoTrackerInvoker, Jars")]
		void DispatchEvent (global::Com.Moat.Analytics.Mobile.Inm.MoatAdEvent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/interface[@name='ReactiveVideoTracker']/method[@name='setActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
[Obsolete (@"deprecated")]
		[Register ("setActivity", "(Landroid/app/Activity;)V", "GetSetActivity_Landroid_app_Activity_Handler:Com.Moat.Analytics.Mobile.Inm.IReactiveVideoTrackerInvoker, Jars")]
		void SetActivity (global::Android.App.Activity p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/interface[@name='ReactiveVideoTracker']/method[@name='setPlayerVolume' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
		[Register ("setPlayerVolume", "(Ljava/lang/Double;)V", "GetSetPlayerVolume_Ljava_lang_Double_Handler:Com.Moat.Analytics.Mobile.Inm.IReactiveVideoTrackerInvoker, Jars")]
		void SetPlayerVolume (global::Java.Lang.Double p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/interface[@name='ReactiveVideoTracker']/method[@name='stopTracking' and count(parameter)=0]"
		[Register ("stopTracking", "()V", "GetStopTrackingHandler:Com.Moat.Analytics.Mobile.Inm.IReactiveVideoTrackerInvoker, Jars")]
		void StopTracking ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/interface[@name='ReactiveVideoTracker']/method[@name='trackVideoAd' and count(parameter)=3 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='android.view.View']]"
		[Register ("trackVideoAd", "(Ljava/util/Map;Ljava/lang/Integer;Landroid/view/View;)Z", "GetTrackVideoAd_Ljava_util_Map_Ljava_lang_Integer_Landroid_view_View_Handler:Com.Moat.Analytics.Mobile.Inm.IReactiveVideoTrackerInvoker, Jars")]
		bool TrackVideoAd (global::System.Collections.Generic.IDictionary<string, string> p0, global::Java.Lang.Integer p1, global::Android.Views.View p2);

	}

	[global::Android.Runtime.Register ("com/moat/analytics/mobile/inm/ReactiveVideoTracker", DoNotGenerateAcw=true)]
	internal class IReactiveVideoTrackerInvoker : global::Java.Lang.Object, IReactiveVideoTracker {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/moat/analytics/mobile/inm/ReactiveVideoTracker");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IReactiveVideoTrackerInvoker); }
		}

		IntPtr class_ref;

		public static IReactiveVideoTracker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IReactiveVideoTracker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.moat.analytics.mobile.inm.ReactiveVideoTracker"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IReactiveVideoTrackerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_changeTargetView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetChangeTargetView_Landroid_view_View_Handler ()
		{
			if (cb_changeTargetView_Landroid_view_View_ == null)
				cb_changeTargetView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ChangeTargetView_Landroid_view_View_);
			return cb_changeTargetView_Landroid_view_View_;
		}

		static void n_ChangeTargetView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Moat.Analytics.Mobile.Inm.IReactiveVideoTracker __this = global::Java.Lang.Object.GetObject<global::Com.Moat.Analytics.Mobile.Inm.IReactiveVideoTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChangeTargetView (p0);
		}
#pragma warning restore 0169

		IntPtr id_changeTargetView_Landroid_view_View_;
		public unsafe void ChangeTargetView (global::Android.Views.View p0)
		{
			if (id_changeTargetView_Landroid_view_View_ == IntPtr.Zero)
				id_changeTargetView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "changeTargetView", "(Landroid/view/View;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_changeTargetView_Landroid_view_View_, __args);
		}

		static Delegate cb_dispatchEvent_Lcom_moat_analytics_mobile_inm_MoatAdEvent_;
#pragma warning disable 0169
		static Delegate GetDispatchEvent_Lcom_moat_analytics_mobile_inm_MoatAdEvent_Handler ()
		{
			if (cb_dispatchEvent_Lcom_moat_analytics_mobile_inm_MoatAdEvent_ == null)
				cb_dispatchEvent_Lcom_moat_analytics_mobile_inm_MoatAdEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DispatchEvent_Lcom_moat_analytics_mobile_inm_MoatAdEvent_);
			return cb_dispatchEvent_Lcom_moat_analytics_mobile_inm_MoatAdEvent_;
		}

		static void n_DispatchEvent_Lcom_moat_analytics_mobile_inm_MoatAdEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Moat.Analytics.Mobile.Inm.IReactiveVideoTracker __this = global::Java.Lang.Object.GetObject<global::Com.Moat.Analytics.Mobile.Inm.IReactiveVideoTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Moat.Analytics.Mobile.Inm.MoatAdEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Moat.Analytics.Mobile.Inm.MoatAdEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DispatchEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_dispatchEvent_Lcom_moat_analytics_mobile_inm_MoatAdEvent_;
		public unsafe void DispatchEvent (global::Com.Moat.Analytics.Mobile.Inm.MoatAdEvent p0)
		{
			if (id_dispatchEvent_Lcom_moat_analytics_mobile_inm_MoatAdEvent_ == IntPtr.Zero)
				id_dispatchEvent_Lcom_moat_analytics_mobile_inm_MoatAdEvent_ = JNIEnv.GetMethodID (class_ref, "dispatchEvent", "(Lcom/moat/analytics/mobile/inm/MoatAdEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispatchEvent_Lcom_moat_analytics_mobile_inm_MoatAdEvent_, __args);
		}

		static Delegate cb_setActivity_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetSetActivity_Landroid_app_Activity_Handler ()
		{
			if (cb_setActivity_Landroid_app_Activity_ == null)
				cb_setActivity_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActivity_Landroid_app_Activity_);
			return cb_setActivity_Landroid_app_Activity_;
		}

		static void n_SetActivity_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Moat.Analytics.Mobile.Inm.IReactiveVideoTracker __this = global::Java.Lang.Object.GetObject<global::Com.Moat.Analytics.Mobile.Inm.IReactiveVideoTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetActivity (p0);
		}
#pragma warning restore 0169

		IntPtr id_setActivity_Landroid_app_Activity_;
		public unsafe void SetActivity (global::Android.App.Activity p0)
		{
			if (id_setActivity_Landroid_app_Activity_ == IntPtr.Zero)
				id_setActivity_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "setActivity", "(Landroid/app/Activity;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActivity_Landroid_app_Activity_, __args);
		}

		static Delegate cb_setPlayerVolume_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetPlayerVolume_Ljava_lang_Double_Handler ()
		{
			if (cb_setPlayerVolume_Ljava_lang_Double_ == null)
				cb_setPlayerVolume_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlayerVolume_Ljava_lang_Double_);
			return cb_setPlayerVolume_Ljava_lang_Double_;
		}

		static void n_SetPlayerVolume_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Moat.Analytics.Mobile.Inm.IReactiveVideoTracker __this = global::Java.Lang.Object.GetObject<global::Com.Moat.Analytics.Mobile.Inm.IReactiveVideoTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPlayerVolume (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPlayerVolume_Ljava_lang_Double_;
		public unsafe void SetPlayerVolume (global::Java.Lang.Double p0)
		{
			if (id_setPlayerVolume_Ljava_lang_Double_ == IntPtr.Zero)
				id_setPlayerVolume_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setPlayerVolume", "(Ljava/lang/Double;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlayerVolume_Ljava_lang_Double_, __args);
		}

		static Delegate cb_stopTracking;
#pragma warning disable 0169
		static Delegate GetStopTrackingHandler ()
		{
			if (cb_stopTracking == null)
				cb_stopTracking = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopTracking);
			return cb_stopTracking;
		}

		static void n_StopTracking (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moat.Analytics.Mobile.Inm.IReactiveVideoTracker __this = global::Java.Lang.Object.GetObject<global::Com.Moat.Analytics.Mobile.Inm.IReactiveVideoTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopTracking ();
		}
#pragma warning restore 0169

		IntPtr id_stopTracking;
		public unsafe void StopTracking ()
		{
			if (id_stopTracking == IntPtr.Zero)
				id_stopTracking = JNIEnv.GetMethodID (class_ref, "stopTracking", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopTracking);
		}

		static Delegate cb_trackVideoAd_Ljava_util_Map_Ljava_lang_Integer_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetTrackVideoAd_Ljava_util_Map_Ljava_lang_Integer_Landroid_view_View_Handler ()
		{
			if (cb_trackVideoAd_Ljava_util_Map_Ljava_lang_Integer_Landroid_view_View_ == null)
				cb_trackVideoAd_Ljava_util_Map_Ljava_lang_Integer_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_TrackVideoAd_Ljava_util_Map_Ljava_lang_Integer_Landroid_view_View_);
			return cb_trackVideoAd_Ljava_util_Map_Ljava_lang_Integer_Landroid_view_View_;
		}

		static bool n_TrackVideoAd_Ljava_util_Map_Ljava_lang_Integer_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Moat.Analytics.Mobile.Inm.IReactiveVideoTracker __this = global::Java.Lang.Object.GetObject<global::Com.Moat.Analytics.Mobile.Inm.IReactiveVideoTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p2 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.TrackVideoAd (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_trackVideoAd_Ljava_util_Map_Ljava_lang_Integer_Landroid_view_View_;
		public unsafe bool TrackVideoAd (global::System.Collections.Generic.IDictionary<string, string> p0, global::Java.Lang.Integer p1, global::Android.Views.View p2)
		{
			if (id_trackVideoAd_Ljava_util_Map_Ljava_lang_Integer_Landroid_view_View_ == IntPtr.Zero)
				id_trackVideoAd_Ljava_util_Map_Ljava_lang_Integer_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "trackVideoAd", "(Ljava/util/Map;Ljava/lang/Integer;Landroid/view/View;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_trackVideoAd_Ljava_util_Map_Ljava_lang_Integer_Landroid_view_View_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
