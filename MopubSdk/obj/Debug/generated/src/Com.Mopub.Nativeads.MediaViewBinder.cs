using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaViewBinder']"
	[global::Android.Runtime.Register ("com/mopub/nativeads/MediaViewBinder", DoNotGenerateAcw=true)]
	public partial class MediaViewBinder : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaViewBinder.Builder']"
		[global::Android.Runtime.Register ("com/mopub/nativeads/MediaViewBinder$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/nativeads/MediaViewBinder$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaViewBinder.Builder']/constructor[@name='MediaViewBinder.Builder' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register (".ctor", "(I)V", "")]
			public unsafe Builder (int p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (Builder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
						return;
					}

					if (id_ctor_I == IntPtr.Zero)
						id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
				} finally {
				}
			}

			static IntPtr id_addExtra_Ljava_lang_String_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaViewBinder.Builder']/method[@name='addExtra' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
			[Register ("addExtra", "(Ljava/lang/String;I)Lcom/mopub/nativeads/MediaViewBinder$Builder;", "")]
			public unsafe global::Com.Mopub.Nativeads.MediaViewBinder.Builder AddExtra (string p0, int p1)
			{
				if (id_addExtra_Ljava_lang_String_I == IntPtr.Zero)
					id_addExtra_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "addExtra", "(Ljava/lang/String;I)Lcom/mopub/nativeads/MediaViewBinder$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					global::Com.Mopub.Nativeads.MediaViewBinder.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaViewBinder.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addExtra_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_addExtras_Ljava_util_Map_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaViewBinder.Builder']/method[@name='addExtras' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Integer&gt;']]"
			[Register ("addExtras", "(Ljava/util/Map;)Lcom/mopub/nativeads/MediaViewBinder$Builder;", "")]
			public unsafe global::Com.Mopub.Nativeads.MediaViewBinder.Builder AddExtras (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Integer> p0)
			{
				if (id_addExtras_Ljava_util_Map_ == IntPtr.Zero)
					id_addExtras_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "addExtras", "(Ljava/util/Map;)Lcom/mopub/nativeads/MediaViewBinder$Builder;");
				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Integer>.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Nativeads.MediaViewBinder.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaViewBinder.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addExtras_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaViewBinder.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/mopub/nativeads/MediaViewBinder;", "")]
			public unsafe global::Com.Mopub.Nativeads.MediaViewBinder Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/mopub/nativeads/MediaViewBinder;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaViewBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_callToActionId_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaViewBinder.Builder']/method[@name='callToActionId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("callToActionId", "(I)Lcom/mopub/nativeads/MediaViewBinder$Builder;", "")]
			public unsafe global::Com.Mopub.Nativeads.MediaViewBinder.Builder CallToActionId (int p0)
			{
				if (id_callToActionId_I == IntPtr.Zero)
					id_callToActionId_I = JNIEnv.GetMethodID (class_ref, "callToActionId", "(I)Lcom/mopub/nativeads/MediaViewBinder$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaViewBinder.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_callToActionId_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_iconImageId_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaViewBinder.Builder']/method[@name='iconImageId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("iconImageId", "(I)Lcom/mopub/nativeads/MediaViewBinder$Builder;", "")]
			public unsafe global::Com.Mopub.Nativeads.MediaViewBinder.Builder IconImageId (int p0)
			{
				if (id_iconImageId_I == IntPtr.Zero)
					id_iconImageId_I = JNIEnv.GetMethodID (class_ref, "iconImageId", "(I)Lcom/mopub/nativeads/MediaViewBinder$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaViewBinder.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_iconImageId_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_mediaLayoutId_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaViewBinder.Builder']/method[@name='mediaLayoutId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("mediaLayoutId", "(I)Lcom/mopub/nativeads/MediaViewBinder$Builder;", "")]
			public unsafe global::Com.Mopub.Nativeads.MediaViewBinder.Builder MediaLayoutId (int p0)
			{
				if (id_mediaLayoutId_I == IntPtr.Zero)
					id_mediaLayoutId_I = JNIEnv.GetMethodID (class_ref, "mediaLayoutId", "(I)Lcom/mopub/nativeads/MediaViewBinder$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaViewBinder.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_mediaLayoutId_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_privacyInformationIconImageId_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaViewBinder.Builder']/method[@name='privacyInformationIconImageId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("privacyInformationIconImageId", "(I)Lcom/mopub/nativeads/MediaViewBinder$Builder;", "")]
			public unsafe global::Com.Mopub.Nativeads.MediaViewBinder.Builder PrivacyInformationIconImageId (int p0)
			{
				if (id_privacyInformationIconImageId_I == IntPtr.Zero)
					id_privacyInformationIconImageId_I = JNIEnv.GetMethodID (class_ref, "privacyInformationIconImageId", "(I)Lcom/mopub/nativeads/MediaViewBinder$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaViewBinder.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_privacyInformationIconImageId_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_textId_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaViewBinder.Builder']/method[@name='textId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("textId", "(I)Lcom/mopub/nativeads/MediaViewBinder$Builder;", "")]
			public unsafe global::Com.Mopub.Nativeads.MediaViewBinder.Builder TextId (int p0)
			{
				if (id_textId_I == IntPtr.Zero)
					id_textId_I = JNIEnv.GetMethodID (class_ref, "textId", "(I)Lcom/mopub/nativeads/MediaViewBinder$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaViewBinder.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_textId_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_titleId_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MediaViewBinder.Builder']/method[@name='titleId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("titleId", "(I)Lcom/mopub/nativeads/MediaViewBinder$Builder;", "")]
			public unsafe global::Com.Mopub.Nativeads.MediaViewBinder.Builder TitleId (int p0)
			{
				if (id_titleId_I == IntPtr.Zero)
					id_titleId_I = JNIEnv.GetMethodID (class_ref, "titleId", "(I)Lcom/mopub/nativeads/MediaViewBinder$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MediaViewBinder.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_titleId_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/nativeads/MediaViewBinder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaViewBinder); }
		}

		protected MediaViewBinder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
