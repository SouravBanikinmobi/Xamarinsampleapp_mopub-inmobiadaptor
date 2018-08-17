using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Moat.Analytics.Mobile.Inm {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/class[@name='NativeDisplayTracker.MoatUserInteractionType']"
	[global::Android.Runtime.Register ("com/moat/analytics/mobile/inm/NativeDisplayTracker$MoatUserInteractionType", DoNotGenerateAcw=true)]
	public sealed partial class NativeDisplayTrackerMoatUserInteractionType : global::Java.Lang.Enum {


		static IntPtr CLICK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/class[@name='NativeDisplayTracker.MoatUserInteractionType']/field[@name='CLICK']"
		[Register ("CLICK")]
		public static global::Com.Moat.Analytics.Mobile.Inm.NativeDisplayTrackerMoatUserInteractionType Click {
			get {
				if (CLICK_jfieldId == IntPtr.Zero)
					CLICK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLICK", "Lcom/moat/analytics/mobile/inm/NativeDisplayTracker$MoatUserInteractionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLICK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Moat.Analytics.Mobile.Inm.NativeDisplayTrackerMoatUserInteractionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TOUCH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/class[@name='NativeDisplayTracker.MoatUserInteractionType']/field[@name='TOUCH']"
		[Register ("TOUCH")]
		public static global::Com.Moat.Analytics.Mobile.Inm.NativeDisplayTrackerMoatUserInteractionType Touch {
			get {
				if (TOUCH_jfieldId == IntPtr.Zero)
					TOUCH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOUCH", "Lcom/moat/analytics/mobile/inm/NativeDisplayTracker$MoatUserInteractionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOUCH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Moat.Analytics.Mobile.Inm.NativeDisplayTrackerMoatUserInteractionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/moat/analytics/mobile/inm/NativeDisplayTracker$MoatUserInteractionType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeDisplayTrackerMoatUserInteractionType); }
		}

		internal NativeDisplayTrackerMoatUserInteractionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/class[@name='NativeDisplayTracker.MoatUserInteractionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/moat/analytics/mobile/inm/NativeDisplayTracker$MoatUserInteractionType;", "")]
		public static unsafe global::Com.Moat.Analytics.Mobile.Inm.NativeDisplayTrackerMoatUserInteractionType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/moat/analytics/mobile/inm/NativeDisplayTracker$MoatUserInteractionType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Moat.Analytics.Mobile.Inm.NativeDisplayTrackerMoatUserInteractionType __ret = global::Java.Lang.Object.GetObject<global::Com.Moat.Analytics.Mobile.Inm.NativeDisplayTrackerMoatUserInteractionType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/class[@name='NativeDisplayTracker.MoatUserInteractionType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/moat/analytics/mobile/inm/NativeDisplayTracker$MoatUserInteractionType;", "")]
		public static unsafe global::Com.Moat.Analytics.Mobile.Inm.NativeDisplayTrackerMoatUserInteractionType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/moat/analytics/mobile/inm/NativeDisplayTracker$MoatUserInteractionType;");
			try {
				return (global::Com.Moat.Analytics.Mobile.Inm.NativeDisplayTrackerMoatUserInteractionType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Moat.Analytics.Mobile.Inm.NativeDisplayTrackerMoatUserInteractionType));
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/interface[@name='NativeDisplayTracker']"
	[Register ("com/moat/analytics/mobile/inm/NativeDisplayTracker", "", "Com.Moat.Analytics.Mobile.Inm.INativeDisplayTrackerInvoker")]
	public partial interface INativeDisplayTracker : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/interface[@name='NativeDisplayTracker']/method[@name='reportUserInteractionEvent' and count(parameter)=1 and parameter[1][@type='com.moat.analytics.mobile.inm.NativeDisplayTracker.MoatUserInteractionType']]"
		[Register ("reportUserInteractionEvent", "(Lcom/moat/analytics/mobile/inm/NativeDisplayTracker$MoatUserInteractionType;)V", "GetReportUserInteractionEvent_Lcom_moat_analytics_mobile_inm_NativeDisplayTracker_MoatUserInteractionType_Handler:Com.Moat.Analytics.Mobile.Inm.INativeDisplayTrackerInvoker, Jars")]
		void ReportUserInteractionEvent (global::Com.Moat.Analytics.Mobile.Inm.NativeDisplayTrackerMoatUserInteractionType p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/interface[@name='NativeDisplayTracker']/method[@name='setActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
[Obsolete (@"deprecated")]
		[Register ("setActivity", "(Landroid/app/Activity;)V", "GetSetActivity_Landroid_app_Activity_Handler:Com.Moat.Analytics.Mobile.Inm.INativeDisplayTrackerInvoker, Jars")]
		void SetActivity (global::Android.App.Activity p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/interface[@name='NativeDisplayTracker']/method[@name='startTracking' and count(parameter)=0]"
		[Register ("startTracking", "()V", "GetStartTrackingHandler:Com.Moat.Analytics.Mobile.Inm.INativeDisplayTrackerInvoker, Jars")]
		void StartTracking ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/interface[@name='NativeDisplayTracker']/method[@name='stopTracking' and count(parameter)=0]"
		[Register ("stopTracking", "()V", "GetStopTrackingHandler:Com.Moat.Analytics.Mobile.Inm.INativeDisplayTrackerInvoker, Jars")]
		void StopTracking ();

	}

	[global::Android.Runtime.Register ("com/moat/analytics/mobile/inm/NativeDisplayTracker", DoNotGenerateAcw=true)]
	internal class INativeDisplayTrackerInvoker : global::Java.Lang.Object, INativeDisplayTracker {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/moat/analytics/mobile/inm/NativeDisplayTracker");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (INativeDisplayTrackerInvoker); }
		}

		IntPtr class_ref;

		public static INativeDisplayTracker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INativeDisplayTracker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.moat.analytics.mobile.inm.NativeDisplayTracker"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INativeDisplayTrackerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_reportUserInteractionEvent_Lcom_moat_analytics_mobile_inm_NativeDisplayTracker_MoatUserInteractionType_;
#pragma warning disable 0169
		static Delegate GetReportUserInteractionEvent_Lcom_moat_analytics_mobile_inm_NativeDisplayTracker_MoatUserInteractionType_Handler ()
		{
			if (cb_reportUserInteractionEvent_Lcom_moat_analytics_mobile_inm_NativeDisplayTracker_MoatUserInteractionType_ == null)
				cb_reportUserInteractionEvent_Lcom_moat_analytics_mobile_inm_NativeDisplayTracker_MoatUserInteractionType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReportUserInteractionEvent_Lcom_moat_analytics_mobile_inm_NativeDisplayTracker_MoatUserInteractionType_);
			return cb_reportUserInteractionEvent_Lcom_moat_analytics_mobile_inm_NativeDisplayTracker_MoatUserInteractionType_;
		}

		static void n_ReportUserInteractionEvent_Lcom_moat_analytics_mobile_inm_NativeDisplayTracker_MoatUserInteractionType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Moat.Analytics.Mobile.Inm.INativeDisplayTracker __this = global::Java.Lang.Object.GetObject<global::Com.Moat.Analytics.Mobile.Inm.INativeDisplayTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Moat.Analytics.Mobile.Inm.NativeDisplayTrackerMoatUserInteractionType p0 = global::Java.Lang.Object.GetObject<global::Com.Moat.Analytics.Mobile.Inm.NativeDisplayTrackerMoatUserInteractionType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReportUserInteractionEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_reportUserInteractionEvent_Lcom_moat_analytics_mobile_inm_NativeDisplayTracker_MoatUserInteractionType_;
		public unsafe void ReportUserInteractionEvent (global::Com.Moat.Analytics.Mobile.Inm.NativeDisplayTrackerMoatUserInteractionType p0)
		{
			if (id_reportUserInteractionEvent_Lcom_moat_analytics_mobile_inm_NativeDisplayTracker_MoatUserInteractionType_ == IntPtr.Zero)
				id_reportUserInteractionEvent_Lcom_moat_analytics_mobile_inm_NativeDisplayTracker_MoatUserInteractionType_ = JNIEnv.GetMethodID (class_ref, "reportUserInteractionEvent", "(Lcom/moat/analytics/mobile/inm/NativeDisplayTracker$MoatUserInteractionType;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reportUserInteractionEvent_Lcom_moat_analytics_mobile_inm_NativeDisplayTracker_MoatUserInteractionType_, __args);
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
			global::Com.Moat.Analytics.Mobile.Inm.INativeDisplayTracker __this = global::Java.Lang.Object.GetObject<global::Com.Moat.Analytics.Mobile.Inm.INativeDisplayTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_startTracking;
#pragma warning disable 0169
		static Delegate GetStartTrackingHandler ()
		{
			if (cb_startTracking == null)
				cb_startTracking = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartTracking);
			return cb_startTracking;
		}

		static void n_StartTracking (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Moat.Analytics.Mobile.Inm.INativeDisplayTracker __this = global::Java.Lang.Object.GetObject<global::Com.Moat.Analytics.Mobile.Inm.INativeDisplayTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartTracking ();
		}
#pragma warning restore 0169

		IntPtr id_startTracking;
		public unsafe void StartTracking ()
		{
			if (id_startTracking == IntPtr.Zero)
				id_startTracking = JNIEnv.GetMethodID (class_ref, "startTracking", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startTracking);
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
			global::Com.Moat.Analytics.Mobile.Inm.INativeDisplayTracker __this = global::Java.Lang.Object.GetObject<global::Com.Moat.Analytics.Mobile.Inm.INativeDisplayTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}

}
