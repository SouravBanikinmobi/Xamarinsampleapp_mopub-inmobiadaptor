using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Moat.Analytics.Mobile.Inm {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/interface[@name='WebAdTracker']"
	[Register ("com/moat/analytics/mobile/inm/WebAdTracker", "", "Com.Moat.Analytics.Mobile.Inm.IWebAdTrackerInvoker")]
	public partial interface IWebAdTracker : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/interface[@name='WebAdTracker']/method[@name='setActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
[Obsolete (@"deprecated")]
		[Register ("setActivity", "(Landroid/app/Activity;)V", "GetSetActivity_Landroid_app_Activity_Handler:Com.Moat.Analytics.Mobile.Inm.IWebAdTrackerInvoker, Jars")]
		void SetActivity (global::Android.App.Activity p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/interface[@name='WebAdTracker']/method[@name='startTracking' and count(parameter)=0]"
		[Register ("startTracking", "()V", "GetStartTrackingHandler:Com.Moat.Analytics.Mobile.Inm.IWebAdTrackerInvoker, Jars")]
		void StartTracking ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.moat.analytics.mobile.inm']/interface[@name='WebAdTracker']/method[@name='stopTracking' and count(parameter)=0]"
		[Register ("stopTracking", "()V", "GetStopTrackingHandler:Com.Moat.Analytics.Mobile.Inm.IWebAdTrackerInvoker, Jars")]
		void StopTracking ();

	}

	[global::Android.Runtime.Register ("com/moat/analytics/mobile/inm/WebAdTracker", DoNotGenerateAcw=true)]
	internal class IWebAdTrackerInvoker : global::Java.Lang.Object, IWebAdTracker {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/moat/analytics/mobile/inm/WebAdTracker");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IWebAdTrackerInvoker); }
		}

		IntPtr class_ref;

		public static IWebAdTracker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IWebAdTracker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.moat.analytics.mobile.inm.WebAdTracker"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IWebAdTrackerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Moat.Analytics.Mobile.Inm.IWebAdTracker __this = global::Java.Lang.Object.GetObject<global::Com.Moat.Analytics.Mobile.Inm.IWebAdTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Moat.Analytics.Mobile.Inm.IWebAdTracker __this = global::Java.Lang.Object.GetObject<global::Com.Moat.Analytics.Mobile.Inm.IWebAdTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Moat.Analytics.Mobile.Inm.IWebAdTracker __this = global::Java.Lang.Object.GetObject<global::Com.Moat.Analytics.Mobile.Inm.IWebAdTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
