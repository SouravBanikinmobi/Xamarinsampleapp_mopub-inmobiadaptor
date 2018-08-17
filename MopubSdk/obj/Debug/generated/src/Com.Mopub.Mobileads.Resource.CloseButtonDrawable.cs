using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Resource {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='CloseButtonDrawable']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/resource/CloseButtonDrawable", DoNotGenerateAcw=true)]
	public partial class CloseButtonDrawable : global::Com.Mopub.Mobileads.Resource.BaseWidgetDrawable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/resource/CloseButtonDrawable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CloseButtonDrawable); }
		}

		protected CloseButtonDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='CloseButtonDrawable']/constructor[@name='CloseButtonDrawable' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CloseButtonDrawable ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CloseButtonDrawable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_ctor_F;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='CloseButtonDrawable']/constructor[@name='CloseButtonDrawable' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register (".ctor", "(F)V", "")]
		public unsafe CloseButtonDrawable (float p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (CloseButtonDrawable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(F)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(F)V", __args);
					return;
				}

				if (id_ctor_F == IntPtr.Zero)
					id_ctor_F = JNIEnv.GetMethodID (class_ref, "<init>", "(F)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_F, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_F, __args);
			} finally {
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_ == null)
				cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_);
			return cb_draw_Landroid_graphics_Canvas_;
		}

		static void n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.Resource.CloseButtonDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Resource.CloseButtonDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.resource']/class[@name='CloseButtonDrawable']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public override unsafe void Draw (global::Android.Graphics.Canvas p0)
		{
			if (id_draw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_draw_Landroid_graphics_Canvas_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;)V"), __args);
			} finally {
			}
		}

	}
}
