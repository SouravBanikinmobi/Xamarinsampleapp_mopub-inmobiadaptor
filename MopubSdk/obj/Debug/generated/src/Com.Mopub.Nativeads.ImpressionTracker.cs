using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='ImpressionTracker']"
	[global::Android.Runtime.Register ("com/mopub/nativeads/ImpressionTracker", DoNotGenerateAcw=true)]
	public partial class ImpressionTracker : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='ImpressionTracker.PollingRunnable']"
		[global::Android.Runtime.Register ("com/mopub/nativeads/ImpressionTracker$PollingRunnable", DoNotGenerateAcw=true)]
		public partial class PollingRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/nativeads/ImpressionTracker$PollingRunnable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PollingRunnable); }
			}

			protected PollingRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Nativeads.ImpressionTracker.PollingRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.ImpressionTracker.PollingRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='ImpressionTracker.PollingRunnable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/nativeads/ImpressionTracker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImpressionTracker); }
		}

		protected ImpressionTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='ImpressionTracker']/constructor[@name='ImpressionTracker' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register (".ctor", "(Landroid/app/Activity;)V", "")]
		public unsafe ImpressionTracker (global::Android.App.Activity p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ImpressionTracker)) {
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

		static Delegate cb_addView_Landroid_view_View_Lcom_mopub_nativeads_ImpressionInterface_;
#pragma warning disable 0169
		static Delegate GetAddView_Landroid_view_View_Lcom_mopub_nativeads_ImpressionInterface_Handler ()
		{
			if (cb_addView_Landroid_view_View_Lcom_mopub_nativeads_ImpressionInterface_ == null)
				cb_addView_Landroid_view_View_Lcom_mopub_nativeads_ImpressionInterface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddView_Landroid_view_View_Lcom_mopub_nativeads_ImpressionInterface_);
			return cb_addView_Landroid_view_View_Lcom_mopub_nativeads_ImpressionInterface_;
		}

		static void n_AddView_Landroid_view_View_Lcom_mopub_nativeads_ImpressionInterface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Nativeads.ImpressionTracker __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.ImpressionTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.IImpressionInterface p1 = (global::Com.Mopub.Nativeads.IImpressionInterface)global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IImpressionInterface> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddView (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addView_Landroid_view_View_Lcom_mopub_nativeads_ImpressionInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='ImpressionTracker']/method[@name='addView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.mopub.nativeads.ImpressionInterface']]"
		[Register ("addView", "(Landroid/view/View;Lcom/mopub/nativeads/ImpressionInterface;)V", "GetAddView_Landroid_view_View_Lcom_mopub_nativeads_ImpressionInterface_Handler")]
		public virtual unsafe void AddView (global::Android.Views.View p0, global::Com.Mopub.Nativeads.IImpressionInterface p1)
		{
			if (id_addView_Landroid_view_View_Lcom_mopub_nativeads_ImpressionInterface_ == IntPtr.Zero)
				id_addView_Landroid_view_View_Lcom_mopub_nativeads_ImpressionInterface_ = JNIEnv.GetMethodID (class_ref, "addView", "(Landroid/view/View;Lcom/mopub/nativeads/ImpressionInterface;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addView_Landroid_view_View_Lcom_mopub_nativeads_ImpressionInterface_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addView", "(Landroid/view/View;Lcom/mopub/nativeads/ImpressionInterface;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.ImpressionTracker __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.ImpressionTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='ImpressionTracker']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
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
			global::Com.Mopub.Nativeads.ImpressionTracker __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.ImpressionTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='ImpressionTracker']/method[@name='destroy' and count(parameter)=0]"
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

		static Delegate cb_removeView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetRemoveView_Landroid_view_View_Handler ()
		{
			if (cb_removeView_Landroid_view_View_ == null)
				cb_removeView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveView_Landroid_view_View_);
			return cb_removeView_Landroid_view_View_;
		}

		static void n_RemoveView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.ImpressionTracker __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.ImpressionTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='ImpressionTracker']/method[@name='removeView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("removeView", "(Landroid/view/View;)V", "GetRemoveView_Landroid_view_View_Handler")]
		public virtual unsafe void RemoveView (global::Android.Views.View p0)
		{
			if (id_removeView_Landroid_view_View_ == IntPtr.Zero)
				id_removeView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "removeView", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeView_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeView", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

	}
}
