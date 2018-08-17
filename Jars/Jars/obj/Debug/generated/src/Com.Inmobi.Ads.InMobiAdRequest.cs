using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Inmobi.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.inmobi.ads']/class[@name='InMobiAdRequest']"
	[global::Android.Runtime.Register ("com/inmobi/ads/InMobiAdRequest", DoNotGenerateAcw=true)]
	public partial class InMobiAdRequest : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.inmobi.ads']/class[@name='InMobiAdRequest.Builder']"
		[global::Android.Runtime.Register ("com/inmobi/ads/InMobiAdRequest$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/inmobi/ads/InMobiAdRequest$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_J;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.inmobi.ads']/class[@name='InMobiAdRequest.Builder']/constructor[@name='InMobiAdRequest.Builder' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register (".ctor", "(J)V", "")]
			public unsafe Builder (long p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (Builder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(J)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(J)V", __args);
						return;
					}

					if (id_ctor_J == IntPtr.Zero)
						id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_J, __args);
				} finally {
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Inmobi.Ads.InMobiAdRequest.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Inmobi.Ads.InMobiAdRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.inmobi.ads']/class[@name='InMobiAdRequest.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/inmobi/ads/InMobiAdRequest;", "GetBuildHandler")]
			public virtual unsafe global::Com.Inmobi.Ads.InMobiAdRequest Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/inmobi/ads/InMobiAdRequest;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Inmobi.Ads.InMobiAdRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Inmobi.Ads.InMobiAdRequest> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/inmobi/ads/InMobiAdRequest;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setExtras_Ljava_util_Map_;
#pragma warning disable 0169
			static Delegate GetSetExtras_Ljava_util_Map_Handler ()
			{
				if (cb_setExtras_Ljava_util_Map_ == null)
					cb_setExtras_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetExtras_Ljava_util_Map_);
				return cb_setExtras_Ljava_util_Map_;
			}

			static IntPtr n_SetExtras_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Inmobi.Ads.InMobiAdRequest.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Inmobi.Ads.InMobiAdRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetExtras (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setExtras_Ljava_util_Map_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.inmobi.ads']/class[@name='InMobiAdRequest.Builder']/method[@name='setExtras' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setExtras", "(Ljava/util/Map;)Lcom/inmobi/ads/InMobiAdRequest$Builder;", "GetSetExtras_Ljava_util_Map_Handler")]
			public virtual unsafe global::Com.Inmobi.Ads.InMobiAdRequest.Builder SetExtras (global::System.Collections.Generic.IDictionary<string, string> p0)
			{
				if (id_setExtras_Ljava_util_Map_ == IntPtr.Zero)
					id_setExtras_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setExtras", "(Ljava/util/Map;)Lcom/inmobi/ads/InMobiAdRequest$Builder;");
				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Inmobi.Ads.InMobiAdRequest.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Inmobi.Ads.InMobiAdRequest.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setExtras_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Inmobi.Ads.InMobiAdRequest.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExtras", "(Ljava/util/Map;)Lcom/inmobi/ads/InMobiAdRequest$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setKeywords_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetKeywords_Ljava_lang_String_Handler ()
			{
				if (cb_setKeywords_Ljava_lang_String_ == null)
					cb_setKeywords_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetKeywords_Ljava_lang_String_);
				return cb_setKeywords_Ljava_lang_String_;
			}

			static IntPtr n_SetKeywords_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Inmobi.Ads.InMobiAdRequest.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Inmobi.Ads.InMobiAdRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetKeywords (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setKeywords_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.inmobi.ads']/class[@name='InMobiAdRequest.Builder']/method[@name='setKeywords' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setKeywords", "(Ljava/lang/String;)Lcom/inmobi/ads/InMobiAdRequest$Builder;", "GetSetKeywords_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Inmobi.Ads.InMobiAdRequest.Builder SetKeywords (string p0)
			{
				if (id_setKeywords_Ljava_lang_String_ == IntPtr.Zero)
					id_setKeywords_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setKeywords", "(Ljava/lang/String;)Lcom/inmobi/ads/InMobiAdRequest$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Com.Inmobi.Ads.InMobiAdRequest.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Inmobi.Ads.InMobiAdRequest.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setKeywords_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Inmobi.Ads.InMobiAdRequest.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKeywords", "(Ljava/lang/String;)Lcom/inmobi/ads/InMobiAdRequest$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setSlotSize_II;
#pragma warning disable 0169
			static Delegate GetSetSlotSize_IIHandler ()
			{
				if (cb_setSlotSize_II == null)
					cb_setSlotSize_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_SetSlotSize_II);
				return cb_setSlotSize_II;
			}

			static IntPtr n_SetSlotSize_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::Com.Inmobi.Ads.InMobiAdRequest.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Inmobi.Ads.InMobiAdRequest.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetSlotSize (p0, p1));
			}
#pragma warning restore 0169

			static IntPtr id_setSlotSize_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.inmobi.ads']/class[@name='InMobiAdRequest.Builder']/method[@name='setSlotSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("setSlotSize", "(II)Lcom/inmobi/ads/InMobiAdRequest$Builder;", "GetSetSlotSize_IIHandler")]
			public virtual unsafe global::Com.Inmobi.Ads.InMobiAdRequest.Builder SetSlotSize (int p0, int p1)
			{
				if (id_setSlotSize_II == IntPtr.Zero)
					id_setSlotSize_II = JNIEnv.GetMethodID (class_ref, "setSlotSize", "(II)Lcom/inmobi/ads/InMobiAdRequest$Builder;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Inmobi.Ads.InMobiAdRequest.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSlotSize_II, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Inmobi.Ads.InMobiAdRequest.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSlotSize", "(II)Lcom/inmobi/ads/InMobiAdRequest$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/inmobi/ads/InMobiAdRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InMobiAdRequest); }
		}

		protected InMobiAdRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
