using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout']"
	[global::Android.Runtime.Register ("com/mopub/nativeads/MediaLayout", DoNotGenerateAcw=true)]
	public partial class MediaLayout : global::Android.Widget.RelativeLayout {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout.Mode']"
		[global::Android.Runtime.Register ("com/mopub/nativeads/MediaLayout$Mode", DoNotGenerateAcw=true)]
		public sealed partial class Mode : global::Java.Lang.Enum {


			static IntPtr BUFFERING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout.Mode']/field[@name='BUFFERING']"
			[Register ("BUFFERING")]
			public static global::Com.Mopub.Nativeads.MediaLayout.Mode Buffering {
				get {
					if (BUFFERING_jfieldId == IntPtr.Zero)
						BUFFERING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUFFERING", "Lcom/mopub/nativeads/MediaLayout$Mode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUFFERING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FINISHED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout.Mode']/field[@name='FINISHED']"
			[Register ("FINISHED")]
			public static global::Com.Mopub.Nativeads.MediaLayout.Mode Finished {
				get {
					if (FINISHED_jfieldId == IntPtr.Zero)
						FINISHED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FINISHED", "Lcom/mopub/nativeads/MediaLayout$Mode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FINISHED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr IMAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout.Mode']/field[@name='IMAGE']"
			[Register ("IMAGE")]
			public static global::Com.Mopub.Nativeads.MediaLayout.Mode Image {
				get {
					if (IMAGE_jfieldId == IntPtr.Zero)
						IMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IMAGE", "Lcom/mopub/nativeads/MediaLayout$Mode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IMAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LOADING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout.Mode']/field[@name='LOADING']"
			[Register ("LOADING")]
			public static global::Com.Mopub.Nativeads.MediaLayout.Mode Loading {
				get {
					if (LOADING_jfieldId == IntPtr.Zero)
						LOADING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOADING", "Lcom/mopub/nativeads/MediaLayout$Mode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOADING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PAUSED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout.Mode']/field[@name='PAUSED']"
			[Register ("PAUSED")]
			public static global::Com.Mopub.Nativeads.MediaLayout.Mode Paused {
				get {
					if (PAUSED_jfieldId == IntPtr.Zero)
						PAUSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAUSED", "Lcom/mopub/nativeads/MediaLayout$Mode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAUSED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PLAYING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout.Mode']/field[@name='PLAYING']"
			[Register ("PLAYING")]
			public static global::Com.Mopub.Nativeads.MediaLayout.Mode Playing {
				get {
					if (PLAYING_jfieldId == IntPtr.Zero)
						PLAYING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYING", "Lcom/mopub/nativeads/MediaLayout$Mode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAYING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/nativeads/MediaLayout$Mode", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout.Mode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/nativeads/MediaLayout$Mode;", "")]
			public static unsafe global::Com.Mopub.Nativeads.MediaLayout.Mode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/nativeads/MediaLayout$Mode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Nativeads.MediaLayout.Mode __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout.Mode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout.Mode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/nativeads/MediaLayout$Mode;", "")]
			public static unsafe global::Com.Mopub.Nativeads.MediaLayout.Mode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/nativeads/MediaLayout$Mode;");
				try {
					return (global::Com.Mopub.Nativeads.MediaLayout.Mode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Nativeads.MediaLayout.Mode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout.MuteState']"
		[global::Android.Runtime.Register ("com/mopub/nativeads/MediaLayout$MuteState", DoNotGenerateAcw=true)]
		public sealed partial class MuteState : global::Java.Lang.Enum {


			static IntPtr MUTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout.MuteState']/field[@name='MUTED']"
			[Register ("MUTED")]
			public static global::Com.Mopub.Nativeads.MediaLayout.MuteState Muted {
				get {
					if (MUTED_jfieldId == IntPtr.Zero)
						MUTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MUTED", "Lcom/mopub/nativeads/MediaLayout$MuteState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MUTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout.MuteState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNMUTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout.MuteState']/field[@name='UNMUTED']"
			[Register ("UNMUTED")]
			public static global::Com.Mopub.Nativeads.MediaLayout.MuteState Unmuted {
				get {
					if (UNMUTED_jfieldId == IntPtr.Zero)
						UNMUTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNMUTED", "Lcom/mopub/nativeads/MediaLayout$MuteState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNMUTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout.MuteState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/nativeads/MediaLayout$MuteState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MuteState); }
			}

			internal MuteState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout.MuteState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/nativeads/MediaLayout$MuteState;", "")]
			public static unsafe global::Com.Mopub.Nativeads.MediaLayout.MuteState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/nativeads/MediaLayout$MuteState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Nativeads.MediaLayout.MuteState __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout.MuteState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout.MuteState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/nativeads/MediaLayout$MuteState;", "")]
			public static unsafe global::Com.Mopub.Nativeads.MediaLayout.MuteState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/nativeads/MediaLayout$MuteState;");
				try {
					return (global::Com.Mopub.Nativeads.MediaLayout.MuteState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Nativeads.MediaLayout.MuteState));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/nativeads/MediaLayout", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaLayout); }
		}

		protected MediaLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout']/constructor[@name='MediaLayout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe MediaLayout (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (MediaLayout)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout']/constructor[@name='MediaLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe MediaLayout (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MediaLayout)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout']/constructor[@name='MediaLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MediaLayout (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MediaLayout)) {
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

		static Delegate cb_getMainImageView;
#pragma warning disable 0169
		static Delegate GetGetMainImageViewHandler ()
		{
			if (cb_getMainImageView == null)
				cb_getMainImageView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMainImageView);
			return cb_getMainImageView;
		}

		static IntPtr n_GetMainImageView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.MediaLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MainImageView);
		}
#pragma warning restore 0169

		static IntPtr id_getMainImageView;
		public virtual unsafe global::Android.Widget.ImageView MainImageView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout']/method[@name='getMainImageView' and count(parameter)=0]"
			[Register ("getMainImageView", "()Landroid/widget/ImageView;", "GetGetMainImageViewHandler")]
			get {
				if (id_getMainImageView == IntPtr.Zero)
					id_getMainImageView = JNIEnv.GetMethodID (class_ref, "getMainImageView", "()Landroid/widget/ImageView;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMainImageView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMainImageView", "()Landroid/widget/ImageView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Mopub.Nativeads.MediaLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextureView);
		}
#pragma warning restore 0169

		static IntPtr id_getTextureView;
		public virtual unsafe global::Android.Views.TextureView TextureView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout']/method[@name='getTextureView' and count(parameter)=0]"
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

		static Delegate cb_initForVideo;
#pragma warning disable 0169
		static Delegate GetInitForVideoHandler ()
		{
			if (cb_initForVideo == null)
				cb_initForVideo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitForVideo);
			return cb_initForVideo;
		}

		static void n_InitForVideo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.MediaLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitForVideo ();
		}
#pragma warning restore 0169

		static IntPtr id_initForVideo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout']/method[@name='initForVideo' and count(parameter)=0]"
		[Register ("initForVideo", "()V", "GetInitForVideoHandler")]
		public virtual unsafe void InitForVideo ()
		{
			if (id_initForVideo == IntPtr.Zero)
				id_initForVideo = JNIEnv.GetMethodID (class_ref, "initForVideo", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initForVideo);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initForVideo", "()V"));
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.MediaLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
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
			global::Com.Mopub.Nativeads.MediaLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetProgress ();
		}
#pragma warning restore 0169

		static IntPtr id_resetProgress;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout']/method[@name='resetProgress' and count(parameter)=0]"
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

		static Delegate cb_setMainImageDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetMainImageDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setMainImageDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setMainImageDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMainImageDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setMainImageDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetMainImageDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.MediaLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMainImageDrawable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMainImageDrawable_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout']/method[@name='setMainImageDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setMainImageDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetMainImageDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetMainImageDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setMainImageDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setMainImageDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setMainImageDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMainImageDrawable_Landroid_graphics_drawable_Drawable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMainImageDrawable", "(Landroid/graphics/drawable/Drawable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMode_Lcom_mopub_nativeads_MediaLayout_Mode_;
#pragma warning disable 0169
		static Delegate GetSetMode_Lcom_mopub_nativeads_MediaLayout_Mode_Handler ()
		{
			if (cb_setMode_Lcom_mopub_nativeads_MediaLayout_Mode_ == null)
				cb_setMode_Lcom_mopub_nativeads_MediaLayout_Mode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMode_Lcom_mopub_nativeads_MediaLayout_Mode_);
			return cb_setMode_Lcom_mopub_nativeads_MediaLayout_Mode_;
		}

		static void n_SetMode_Lcom_mopub_nativeads_MediaLayout_Mode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.MediaLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.MediaLayout.Mode p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout.Mode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMode_Lcom_mopub_nativeads_MediaLayout_Mode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout']/method[@name='setMode' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.MediaLayout.Mode']]"
		[Register ("setMode", "(Lcom/mopub/nativeads/MediaLayout$Mode;)V", "GetSetMode_Lcom_mopub_nativeads_MediaLayout_Mode_Handler")]
		public virtual unsafe void SetMode (global::Com.Mopub.Nativeads.MediaLayout.Mode p0)
		{
			if (id_setMode_Lcom_mopub_nativeads_MediaLayout_Mode_ == IntPtr.Zero)
				id_setMode_Lcom_mopub_nativeads_MediaLayout_Mode_ = JNIEnv.GetMethodID (class_ref, "setMode", "(Lcom/mopub/nativeads/MediaLayout$Mode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMode_Lcom_mopub_nativeads_MediaLayout_Mode_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMode", "(Lcom/mopub/nativeads/MediaLayout$Mode;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMuteControlClickListener_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetMuteControlClickListener_Landroid_view_View_OnClickListener_Handler ()
		{
			if (cb_setMuteControlClickListener_Landroid_view_View_OnClickListener_ == null)
				cb_setMuteControlClickListener_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMuteControlClickListener_Landroid_view_View_OnClickListener_);
			return cb_setMuteControlClickListener_Landroid_view_View_OnClickListener_;
		}

		static void n_SetMuteControlClickListener_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.MediaLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnClickListener p0 = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMuteControlClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMuteControlClickListener_Landroid_view_View_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout']/method[@name='setMuteControlClickListener' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
		[Register ("setMuteControlClickListener", "(Landroid/view/View$OnClickListener;)V", "GetSetMuteControlClickListener_Landroid_view_View_OnClickListener_Handler")]
		public virtual unsafe void SetMuteControlClickListener (global::Android.Views.View.IOnClickListener p0)
		{
			if (id_setMuteControlClickListener_Landroid_view_View_OnClickListener_ == IntPtr.Zero)
				id_setMuteControlClickListener_Landroid_view_View_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setMuteControlClickListener", "(Landroid/view/View$OnClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMuteControlClickListener_Landroid_view_View_OnClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMuteControlClickListener", "(Landroid/view/View$OnClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMuteState_Lcom_mopub_nativeads_MediaLayout_MuteState_;
#pragma warning disable 0169
		static Delegate GetSetMuteState_Lcom_mopub_nativeads_MediaLayout_MuteState_Handler ()
		{
			if (cb_setMuteState_Lcom_mopub_nativeads_MediaLayout_MuteState_ == null)
				cb_setMuteState_Lcom_mopub_nativeads_MediaLayout_MuteState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMuteState_Lcom_mopub_nativeads_MediaLayout_MuteState_);
			return cb_setMuteState_Lcom_mopub_nativeads_MediaLayout_MuteState_;
		}

		static void n_SetMuteState_Lcom_mopub_nativeads_MediaLayout_MuteState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.MediaLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.MediaLayout.MuteState p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout.MuteState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMuteState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMuteState_Lcom_mopub_nativeads_MediaLayout_MuteState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout']/method[@name='setMuteState' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.MediaLayout.MuteState']]"
		[Register ("setMuteState", "(Lcom/mopub/nativeads/MediaLayout$MuteState;)V", "GetSetMuteState_Lcom_mopub_nativeads_MediaLayout_MuteState_Handler")]
		public virtual unsafe void SetMuteState (global::Com.Mopub.Nativeads.MediaLayout.MuteState p0)
		{
			if (id_setMuteState_Lcom_mopub_nativeads_MediaLayout_MuteState_ == IntPtr.Zero)
				id_setMuteState_Lcom_mopub_nativeads_MediaLayout_MuteState_ = JNIEnv.GetMethodID (class_ref, "setMuteState", "(Lcom/mopub/nativeads/MediaLayout$MuteState;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMuteState_Lcom_mopub_nativeads_MediaLayout_MuteState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMuteState", "(Lcom/mopub/nativeads/MediaLayout$MuteState;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPlayButtonClickListener_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetPlayButtonClickListener_Landroid_view_View_OnClickListener_Handler ()
		{
			if (cb_setPlayButtonClickListener_Landroid_view_View_OnClickListener_ == null)
				cb_setPlayButtonClickListener_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlayButtonClickListener_Landroid_view_View_OnClickListener_);
			return cb_setPlayButtonClickListener_Landroid_view_View_OnClickListener_;
		}

		static void n_SetPlayButtonClickListener_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.MediaLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnClickListener p0 = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPlayButtonClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPlayButtonClickListener_Landroid_view_View_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout']/method[@name='setPlayButtonClickListener' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
		[Register ("setPlayButtonClickListener", "(Landroid/view/View$OnClickListener;)V", "GetSetPlayButtonClickListener_Landroid_view_View_OnClickListener_Handler")]
		public virtual unsafe void SetPlayButtonClickListener (global::Android.Views.View.IOnClickListener p0)
		{
			if (id_setPlayButtonClickListener_Landroid_view_View_OnClickListener_ == IntPtr.Zero)
				id_setPlayButtonClickListener_Landroid_view_View_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setPlayButtonClickListener", "(Landroid/view/View$OnClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlayButtonClickListener_Landroid_view_View_OnClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPlayButtonClickListener", "(Landroid/view/View$OnClickListener;)V"), __args);
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
			global::Com.Mopub.Nativeads.MediaLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.TextureView.ISurfaceTextureListener p0 = (global::Android.Views.TextureView.ISurfaceTextureListener)global::Java.Lang.Object.GetObject<global::Android.Views.TextureView.ISurfaceTextureListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSurfaceTextureListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSurfaceTextureListener_Landroid_view_TextureView_SurfaceTextureListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout']/method[@name='setSurfaceTextureListener' and count(parameter)=1 and parameter[1][@type='android.view.TextureView.SurfaceTextureListener']]"
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

		static Delegate cb_setVideoClickListener_Landroid_view_View_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetVideoClickListener_Landroid_view_View_OnClickListener_Handler ()
		{
			if (cb_setVideoClickListener_Landroid_view_View_OnClickListener_ == null)
				cb_setVideoClickListener_Landroid_view_View_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVideoClickListener_Landroid_view_View_OnClickListener_);
			return cb_setVideoClickListener_Landroid_view_View_OnClickListener_;
		}

		static void n_SetVideoClickListener_Landroid_view_View_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.MediaLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View.IOnClickListener p0 = (global::Android.Views.View.IOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setVideoClickListener_Landroid_view_View_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout']/method[@name='setVideoClickListener' and count(parameter)=1 and parameter[1][@type='android.view.View.OnClickListener']]"
		[Register ("setVideoClickListener", "(Landroid/view/View$OnClickListener;)V", "GetSetVideoClickListener_Landroid_view_View_OnClickListener_Handler")]
		public virtual unsafe void SetVideoClickListener (global::Android.Views.View.IOnClickListener p0)
		{
			if (id_setVideoClickListener_Landroid_view_View_OnClickListener_ == IntPtr.Zero)
				id_setVideoClickListener_Landroid_view_View_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setVideoClickListener", "(Landroid/view/View$OnClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVideoClickListener_Landroid_view_View_OnClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVideoClickListener", "(Landroid/view/View$OnClickListener;)V"), __args);
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
			global::Com.Mopub.Nativeads.MediaLayout __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateProgress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateProgress_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaLayout']/method[@name='updateProgress' and count(parameter)=1 and parameter[1][@type='int']]"
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
