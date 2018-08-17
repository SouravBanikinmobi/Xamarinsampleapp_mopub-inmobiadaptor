using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Inmobi.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.inmobi.ads']/class[@name='NativeVideoWrapper']"
	[global::Android.Runtime.Register ("com/inmobi/ads/NativeVideoWrapper", DoNotGenerateAcw=true)]
	public partial class NativeVideoWrapper : global::Android.Widget.RelativeLayout {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/inmobi/ads/NativeVideoWrapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeVideoWrapper); }
		}

		protected NativeVideoWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.inmobi.ads']/class[@name='NativeVideoWrapper']/constructor[@name='NativeVideoWrapper' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe NativeVideoWrapper (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (NativeVideoWrapper)) {
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

		static Delegate cb_getPoster;
#pragma warning disable 0169
		static Delegate GetGetPosterHandler ()
		{
			if (cb_getPoster == null)
				cb_getPoster = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoster);
			return cb_getPoster;
		}

		static IntPtr n_GetPoster (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Inmobi.Ads.NativeVideoWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Inmobi.Ads.NativeVideoWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Poster);
		}
#pragma warning restore 0169

		static IntPtr id_getPoster;
		public virtual unsafe global::Android.Widget.ImageView Poster {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.inmobi.ads']/class[@name='NativeVideoWrapper']/method[@name='getPoster' and count(parameter)=0]"
			[Register ("getPoster", "()Landroid/widget/ImageView;", "GetGetPosterHandler")]
			get {
				if (id_getPoster == IntPtr.Zero)
					id_getPoster = JNIEnv.GetMethodID (class_ref, "getPoster", "()Landroid/widget/ImageView;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPoster), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPoster", "()Landroid/widget/ImageView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProgressBar;
#pragma warning disable 0169
		static Delegate GetGetProgressBarHandler ()
		{
			if (cb_getProgressBar == null)
				cb_getProgressBar = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProgressBar);
			return cb_getProgressBar;
		}

		static IntPtr n_GetProgressBar (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Inmobi.Ads.NativeVideoWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Inmobi.Ads.NativeVideoWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProgressBar);
		}
#pragma warning restore 0169

		static IntPtr id_getProgressBar;
		public virtual unsafe global::Android.Widget.ProgressBar ProgressBar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.inmobi.ads']/class[@name='NativeVideoWrapper']/method[@name='getProgressBar' and count(parameter)=0]"
			[Register ("getProgressBar", "()Landroid/widget/ProgressBar;", "GetGetProgressBarHandler")]
			get {
				if (id_getProgressBar == IntPtr.Zero)
					id_getProgressBar = JNIEnv.GetMethodID (class_ref, "getProgressBar", "()Landroid/widget/ProgressBar;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ProgressBar> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProgressBar), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ProgressBar> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProgressBar", "()Landroid/widget/ProgressBar;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setPosterImage_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetPosterImage_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setPosterImage_Landroid_graphics_Bitmap_ == null)
				cb_setPosterImage_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPosterImage_Landroid_graphics_Bitmap_);
			return cb_setPosterImage_Landroid_graphics_Bitmap_;
		}

		static void n_SetPosterImage_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Inmobi.Ads.NativeVideoWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Inmobi.Ads.NativeVideoWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPosterImage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPosterImage_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.inmobi.ads']/class[@name='NativeVideoWrapper']/method[@name='setPosterImage' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setPosterImage", "(Landroid/graphics/Bitmap;)V", "GetSetPosterImage_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void SetPosterImage (global::Android.Graphics.Bitmap p0)
		{
			if (id_setPosterImage_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setPosterImage_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setPosterImage", "(Landroid/graphics/Bitmap;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPosterImage_Landroid_graphics_Bitmap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPosterImage", "(Landroid/graphics/Bitmap;)V"), __args);
			} finally {
			}
		}

	}
}
