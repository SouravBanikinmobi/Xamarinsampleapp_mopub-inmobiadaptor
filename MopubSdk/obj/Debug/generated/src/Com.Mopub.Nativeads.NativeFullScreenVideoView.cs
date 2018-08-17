using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView']"
	[global::Android.Runtime.Register ("com/mopub/nativeads/NativeFullScreenVideoView", DoNotGenerateAcw=true)]
	public partial class NativeFullScreenVideoView : global::Android.Widget.RelativeLayout {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView.LoadingBackground']"
		[global::Android.Runtime.Register ("com/mopub/nativeads/NativeFullScreenVideoView$LoadingBackground", DoNotGenerateAcw=true)]
		public partial class LoadingBackground : global::Android.Graphics.Drawables.Drawable {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/nativeads/NativeFullScreenVideoView$LoadingBackground", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LoadingBackground); }
			}

			protected LoadingBackground (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getOpacity;
#pragma warning disable 0169
			static Delegate GetGetOpacityHandler ()
			{
				if (cb_getOpacity == null)
					cb_getOpacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOpacity);
				return cb_getOpacity;
			}

			static int n_GetOpacity (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Nativeads.NativeFullScreenVideoView.LoadingBackground __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeFullScreenVideoView.LoadingBackground> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Opacity;
			}
#pragma warning restore 0169

			static IntPtr id_getOpacity;
			public override unsafe int Opacity {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView.LoadingBackground']/method[@name='getOpacity' and count(parameter)=0]"
				[Register ("getOpacity", "()I", "GetGetOpacityHandler")]
				get {
					if (id_getOpacity == IntPtr.Zero)
						id_getOpacity = JNIEnv.GetMethodID (class_ref, "getOpacity", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOpacity);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOpacity", "()I"));
					} finally {
					}
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
				global::Com.Mopub.Nativeads.NativeFullScreenVideoView.LoadingBackground __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeFullScreenVideoView.LoadingBackground> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Draw (p0);
			}
#pragma warning restore 0169

			static IntPtr id_draw_Landroid_graphics_Canvas_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView.LoadingBackground']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
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

			static Delegate cb_setAlpha_I;
#pragma warning disable 0169
			static Delegate GetSetAlpha_IHandler ()
			{
				if (cb_setAlpha_I == null)
					cb_setAlpha_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAlpha_I);
				return cb_setAlpha_I;
			}

			static void n_SetAlpha_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Mopub.Nativeads.NativeFullScreenVideoView.LoadingBackground __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeFullScreenVideoView.LoadingBackground> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetAlpha (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setAlpha_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView.LoadingBackground']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAlpha", "(I)V", "GetSetAlpha_IHandler")]
			public override unsafe void SetAlpha (int p0)
			{
				if (id_setAlpha_I == IntPtr.Zero)
					id_setAlpha_I = JNIEnv.GetMethodID (class_ref, "setAlpha", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlpha_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlpha", "(I)V"), __args);
				} finally {
				}
			}

			static Delegate cb_setColorFilter_Landroid_graphics_ColorFilter_;
#pragma warning disable 0169
			static Delegate GetSetColorFilter_Landroid_graphics_ColorFilter_Handler ()
			{
				if (cb_setColorFilter_Landroid_graphics_ColorFilter_ == null)
					cb_setColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorFilter_Landroid_graphics_ColorFilter_);
				return cb_setColorFilter_Landroid_graphics_ColorFilter_;
			}

			static void n_SetColorFilter_Landroid_graphics_ColorFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Nativeads.NativeFullScreenVideoView.LoadingBackground __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeFullScreenVideoView.LoadingBackground> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.ColorFilter p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetColorFilter (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setColorFilter_Landroid_graphics_ColorFilter_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView.LoadingBackground']/method[@name='setColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
			[Register ("setColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetColorFilter_Landroid_graphics_ColorFilter_Handler")]
			public override unsafe void SetColorFilter (global::Android.Graphics.ColorFilter p0)
			{
				if (id_setColorFilter_Landroid_graphics_ColorFilter_ == IntPtr.Zero)
					id_setColorFilter_Landroid_graphics_ColorFilter_ = JNIEnv.GetMethodID (class_ref, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColorFilter_Landroid_graphics_ColorFilter_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView.Mode']"
		[global::Android.Runtime.Register ("com/mopub/nativeads/NativeFullScreenVideoView$Mode", DoNotGenerateAcw=true)]
		public sealed partial class Mode : global::Java.Lang.Enum {


			static IntPtr FINISHED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView.Mode']/field[@name='FINISHED']"
			[Register ("FINISHED")]
			public static global::Com.Mopub.Nativeads.NativeFullScreenVideoView.Mode Finished {
				get {
					if (FINISHED_jfieldId == IntPtr.Zero)
						FINISHED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FINISHED", "Lcom/mopub/nativeads/NativeFullScreenVideoView$Mode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FINISHED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeFullScreenVideoView.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LOADING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView.Mode']/field[@name='LOADING']"
			[Register ("LOADING")]
			public static global::Com.Mopub.Nativeads.NativeFullScreenVideoView.Mode Loading {
				get {
					if (LOADING_jfieldId == IntPtr.Zero)
						LOADING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOADING", "Lcom/mopub/nativeads/NativeFullScreenVideoView$Mode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOADING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeFullScreenVideoView.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PAUSED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView.Mode']/field[@name='PAUSED']"
			[Register ("PAUSED")]
			public static global::Com.Mopub.Nativeads.NativeFullScreenVideoView.Mode Paused {
				get {
					if (PAUSED_jfieldId == IntPtr.Zero)
						PAUSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAUSED", "Lcom/mopub/nativeads/NativeFullScreenVideoView$Mode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAUSED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeFullScreenVideoView.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PLAYING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView.Mode']/field[@name='PLAYING']"
			[Register ("PLAYING")]
			public static global::Com.Mopub.Nativeads.NativeFullScreenVideoView.Mode Playing {
				get {
					if (PLAYING_jfieldId == IntPtr.Zero)
						PLAYING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYING", "Lcom/mopub/nativeads/NativeFullScreenVideoView$Mode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAYING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeFullScreenVideoView.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/nativeads/NativeFullScreenVideoView$Mode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Mode); }
			}

			internal Mode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView.Mode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/nativeads/NativeFullScreenVideoView$Mode;", "")]
			public static unsafe global::Com.Mopub.Nativeads.NativeFullScreenVideoView.Mode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/nativeads/NativeFullScreenVideoView$Mode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Nativeads.NativeFullScreenVideoView.Mode __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeFullScreenVideoView.Mode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView.Mode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/nativeads/NativeFullScreenVideoView$Mode;", "")]
			public static unsafe global::Com.Mopub.Nativeads.NativeFullScreenVideoView.Mode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/nativeads/NativeFullScreenVideoView$Mode;");
				try {
					return (global::Com.Mopub.Nativeads.NativeFullScreenVideoView.Mode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Nativeads.NativeFullScreenVideoView.Mode));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/nativeads/NativeFullScreenVideoView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeFullScreenVideoView); }
		}

		protected NativeFullScreenVideoView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView']/constructor[@name='NativeFullScreenVideoView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;ILjava/lang/String;)V", "")]
		public unsafe NativeFullScreenVideoView (global::Android.Content.Context p0, int p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (NativeFullScreenVideoView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getTextureView;
#pragma warning disable 0169
		static Delegate GetGetTextureViewHandler ()
		{
			if (cb_getTextureView == null)
				cb_getTextureView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextureView);
			return cb_getTextureView;
		}

		static IntPtr n_GetTextureView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.NativeFullScreenVideoView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeFullScreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextureView);
		}
#pragma warning restore 0169

		static IntPtr id_getTextureView;
		public virtual unsafe global::Android.Views.TextureView TextureView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView']/method[@name='getTextureView' and count(parameter)=0]"
			[Register ("getTextureView", "()Landroid/view/TextureView;", "GetGetTextureViewHandler")]
			get {
				if (id_getTextureView == IntPtr.Zero)
					id_getTextureView = JNIEnv.GetMethodID (class_ref, "getTextureView", "()Landroid/view/TextureView;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.TextureView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTextureView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.TextureView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextureView", "()Landroid/view/TextureView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_resetProgress;
#pragma warning disable 0169
		static Delegate GetResetProgressHandler ()
		{
			if (cb_resetProgress == null)
				cb_resetProgress = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetProgress);
			return cb_resetProgress;
		}

		static void n_ResetProgress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.NativeFullScreenVideoView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeFullScreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetProgress ();
		}
#pragma warning restore 0169

		static IntPtr id_resetProgress;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView']/method[@name='resetProgress' and count(parameter)=0]"
		[Register ("resetProgress", "()V", "GetResetProgressHandler")]
		public virtual unsafe void ResetProgress ()
		{
			if (id_resetProgress == IntPtr.Zero)
				id_resetProgress = JNIEnv.GetMethodID (class_ref, "resetProgress", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetProgress);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetProgress", "()V"));
			} finally {
			}
		}

		static Delegate cb_setCachedVideoFrame_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetCachedVideoFrame_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setCachedVideoFrame_Landroid_graphics_Bitmap_ == null)
				cb_setCachedVideoFrame_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCachedVideoFrame_Landroid_graphics_Bitmap_);
			return cb_setCachedVideoFrame_Landroid_graphics_Bitmap_;
		}

		static void n_SetCachedVideoFrame_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.NativeFullScreenVideoView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeFullScreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCachedVideoFrame (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCachedVideoFrame_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView']/method[@name='setCachedVideoFrame' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setCachedVideoFrame", "(Landroid/graphics/Bitmap;)V", "GetSetCachedVideoFrame_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void SetCachedVideoFrame (global::Android.Graphics.Bitmap p0)
		{
			if (id_setCachedVideoFrame_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setCachedVideoFrame_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setCachedVideoFrame", "(Landroid/graphics/Bitmap;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCachedVideoFrame_Landroid_graphics_Bitmap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCachedVideoFrame", "(Landroid/graphics/Bitmap;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCloseControlListener_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetCloseControlListener_Landroid_view_View_OnClickListener_Handler ()
		{
			if (cb_setCloseControlListener_Landroid_view_View_OnClickListener_ == null)
				cb_setCloseControlListener_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCloseControlListener_Landroid_view_View_OnClickListener_);
			return cb_setCloseControlListener_Landroid_view_View_OnClickListener_;
		}

		static void n_SetCloseControlListener_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.NativeFullScreenVideoView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeFullScreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnClickListener p0 = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCloseControlListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCloseControlListener_Landroid_view_View_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView']/method[@name='setCloseControlListener' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
		[Register ("setCloseControlListener", "(Landroid/view/View$OnClickListener;)V", "GetSetCloseControlListener_Landroid_view_View_OnClickListener_Handler")]
		public virtual unsafe void SetCloseControlListener (global::Android.Views.View.IOnClickListener p0)
		{
			if (id_setCloseControlListener_Landroid_view_View_OnClickListener_ == IntPtr.Zero)
				id_setCloseControlListener_Landroid_view_View_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setCloseControlListener", "(Landroid/view/View$OnClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCloseControlListener_Landroid_view_View_OnClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCloseControlListener", "(Landroid/view/View$OnClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCtaClickListener_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetCtaClickListener_Landroid_view_View_OnClickListener_Handler ()
		{
			if (cb_setCtaClickListener_Landroid_view_View_OnClickListener_ == null)
				cb_setCtaClickListener_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCtaClickListener_Landroid_view_View_OnClickListener_);
			return cb_setCtaClickListener_Landroid_view_View_OnClickListener_;
		}

		static void n_SetCtaClickListener_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.NativeFullScreenVideoView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeFullScreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnClickListener p0 = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCtaClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCtaClickListener_Landroid_view_View_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView']/method[@name='setCtaClickListener' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
		[Register ("setCtaClickListener", "(Landroid/view/View$OnClickListener;)V", "GetSetCtaClickListener_Landroid_view_View_OnClickListener_Handler")]
		public virtual unsafe void SetCtaClickListener (global::Android.Views.View.IOnClickListener p0)
		{
			if (id_setCtaClickListener_Landroid_view_View_OnClickListener_ == IntPtr.Zero)
				id_setCtaClickListener_Landroid_view_View_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setCtaClickListener", "(Landroid/view/View$OnClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCtaClickListener_Landroid_view_View_OnClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCtaClickListener", "(Landroid/view/View$OnClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMode_Lcom_mopub_nativeads_NativeFullScreenVideoView_Mode_;
#pragma warning disable 0169
		static Delegate GetSetMode_Lcom_mopub_nativeads_NativeFullScreenVideoView_Mode_Handler ()
		{
			if (cb_setMode_Lcom_mopub_nativeads_NativeFullScreenVideoView_Mode_ == null)
				cb_setMode_Lcom_mopub_nativeads_NativeFullScreenVideoView_Mode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMode_Lcom_mopub_nativeads_NativeFullScreenVideoView_Mode_);
			return cb_setMode_Lcom_mopub_nativeads_NativeFullScreenVideoView_Mode_;
		}

		static void n_SetMode_Lcom_mopub_nativeads_NativeFullScreenVideoView_Mode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.NativeFullScreenVideoView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeFullScreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.NativeFullScreenVideoView.Mode p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeFullScreenVideoView.Mode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMode_Lcom_mopub_nativeads_NativeFullScreenVideoView_Mode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView']/method[@name='setMode' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.NativeFullScreenVideoView.Mode']]"
		[Register ("setMode", "(Lcom/mopub/nativeads/NativeFullScreenVideoView$Mode;)V", "GetSetMode_Lcom_mopub_nativeads_NativeFullScreenVideoView_Mode_Handler")]
		public virtual unsafe void SetMode (global::Com.Mopub.Nativeads.NativeFullScreenVideoView.Mode p0)
		{
			if (id_setMode_Lcom_mopub_nativeads_NativeFullScreenVideoView_Mode_ == IntPtr.Zero)
				id_setMode_Lcom_mopub_nativeads_NativeFullScreenVideoView_Mode_ = JNIEnv.GetMethodID (class_ref, "setMode", "(Lcom/mopub/nativeads/NativeFullScreenVideoView$Mode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMode_Lcom_mopub_nativeads_NativeFullScreenVideoView_Mode_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMode", "(Lcom/mopub/nativeads/NativeFullScreenVideoView$Mode;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOrientation_I;
#pragma warning disable 0169
		static Delegate GetSetOrientation_IHandler ()
		{
			if (cb_setOrientation_I == null)
				cb_setOrientation_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOrientation_I);
			return cb_setOrientation_I;
		}

		static void n_SetOrientation_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.NativeFullScreenVideoView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeFullScreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOrientation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOrientation_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView']/method[@name='setOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOrientation", "(I)V", "GetSetOrientation_IHandler")]
		public virtual unsafe void SetOrientation (int p0)
		{
			if (id_setOrientation_I == IntPtr.Zero)
				id_setOrientation_I = JNIEnv.GetMethodID (class_ref, "setOrientation", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOrientation_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOrientation", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPlayControlClickListener_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetPlayControlClickListener_Landroid_view_View_OnClickListener_Handler ()
		{
			if (cb_setPlayControlClickListener_Landroid_view_View_OnClickListener_ == null)
				cb_setPlayControlClickListener_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlayControlClickListener_Landroid_view_View_OnClickListener_);
			return cb_setPlayControlClickListener_Landroid_view_View_OnClickListener_;
		}

		static void n_SetPlayControlClickListener_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.NativeFullScreenVideoView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeFullScreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnClickListener p0 = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPlayControlClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPlayControlClickListener_Landroid_view_View_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView']/method[@name='setPlayControlClickListener' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
		[Register ("setPlayControlClickListener", "(Landroid/view/View$OnClickListener;)V", "GetSetPlayControlClickListener_Landroid_view_View_OnClickListener_Handler")]
		public virtual unsafe void SetPlayControlClickListener (global::Android.Views.View.IOnClickListener p0)
		{
			if (id_setPlayControlClickListener_Landroid_view_View_OnClickListener_ == IntPtr.Zero)
				id_setPlayControlClickListener_Landroid_view_View_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setPlayControlClickListener", "(Landroid/view/View$OnClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlayControlClickListener_Landroid_view_View_OnClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPlayControlClickListener", "(Landroid/view/View$OnClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPrivacyInformationClickListener_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetPrivacyInformationClickListener_Landroid_view_View_OnClickListener_Handler ()
		{
			if (cb_setPrivacyInformationClickListener_Landroid_view_View_OnClickListener_ == null)
				cb_setPrivacyInformationClickListener_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPrivacyInformationClickListener_Landroid_view_View_OnClickListener_);
			return cb_setPrivacyInformationClickListener_Landroid_view_View_OnClickListener_;
		}

		static void n_SetPrivacyInformationClickListener_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.NativeFullScreenVideoView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeFullScreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnClickListener p0 = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPrivacyInformationClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPrivacyInformationClickListener_Landroid_view_View_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView']/method[@name='setPrivacyInformationClickListener' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
		[Register ("setPrivacyInformationClickListener", "(Landroid/view/View$OnClickListener;)V", "GetSetPrivacyInformationClickListener_Landroid_view_View_OnClickListener_Handler")]
		public virtual unsafe void SetPrivacyInformationClickListener (global::Android.Views.View.IOnClickListener p0)
		{
			if (id_setPrivacyInformationClickListener_Landroid_view_View_OnClickListener_ == IntPtr.Zero)
				id_setPrivacyInformationClickListener_Landroid_view_View_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setPrivacyInformationClickListener", "(Landroid/view/View$OnClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPrivacyInformationClickListener_Landroid_view_View_OnClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPrivacyInformationClickListener", "(Landroid/view/View$OnClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSurfaceTextureListener_Landroid_view_TextureView_SurfaceTextureListener_;
#pragma warning disable 0169
		static Delegate GetSetSurfaceTextureListener_Landroid_view_TextureView_SurfaceTextureListener_Handler ()
		{
			if (cb_setSurfaceTextureListener_Landroid_view_TextureView_SurfaceTextureListener_ == null)
				cb_setSurfaceTextureListener_Landroid_view_TextureView_SurfaceTextureListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSurfaceTextureListener_Landroid_view_TextureView_SurfaceTextureListener_);
			return cb_setSurfaceTextureListener_Landroid_view_TextureView_SurfaceTextureListener_;
		}

		static void n_SetSurfaceTextureListener_Landroid_view_TextureView_SurfaceTextureListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.NativeFullScreenVideoView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeFullScreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.TextureView.ISurfaceTextureListener p0 = (global::Android.Views.TextureView.ISurfaceTextureListener)global::Java.Lang.Object.GetObject<global::Android.Views.TextureView.ISurfaceTextureListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSurfaceTextureListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSurfaceTextureListener_Landroid_view_TextureView_SurfaceTextureListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView']/method[@name='setSurfaceTextureListener' and count(parameter)=1 and parameter[1][@type='android.view.TextureView.SurfaceTextureListener']]"
		[Register ("setSurfaceTextureListener", "(Landroid/view/TextureView$SurfaceTextureListener;)V", "GetSetSurfaceTextureListener_Landroid_view_TextureView_SurfaceTextureListener_Handler")]
		public virtual unsafe void SetSurfaceTextureListener (global::Android.Views.TextureView.ISurfaceTextureListener p0)
		{
			if (id_setSurfaceTextureListener_Landroid_view_TextureView_SurfaceTextureListener_ == IntPtr.Zero)
				id_setSurfaceTextureListener_Landroid_view_TextureView_SurfaceTextureListener_ = JNIEnv.GetMethodID (class_ref, "setSurfaceTextureListener", "(Landroid/view/TextureView$SurfaceTextureListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSurfaceTextureListener_Landroid_view_TextureView_SurfaceTextureListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSurfaceTextureListener", "(Landroid/view/TextureView$SurfaceTextureListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateProgress_I;
#pragma warning disable 0169
		static Delegate GetUpdateProgress_IHandler ()
		{
			if (cb_updateProgress_I == null)
				cb_updateProgress_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_UpdateProgress_I);
			return cb_updateProgress_I;
		}

		static void n_UpdateProgress_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.NativeFullScreenVideoView __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeFullScreenVideoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateProgress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateProgress_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeFullScreenVideoView']/method[@name='updateProgress' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updateProgress", "(I)V", "GetUpdateProgress_IHandler")]
		public virtual unsafe void UpdateProgress (int p0)
		{
			if (id_updateProgress_I == IntPtr.Zero)
				id_updateProgress_I = JNIEnv.GetMethodID (class_ref, "updateProgress", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateProgress_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateProgress", "(I)V"), __args);
			} finally {
			}
		}

	}
}
