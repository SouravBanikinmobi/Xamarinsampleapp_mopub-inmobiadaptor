using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.mopub.common.events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails']"
	[global::Android.Runtime.Register ("com/mopub/common/event/EventDetails", DoNotGenerateAcw=true)]
	public partial class EventDetails : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails.Builder']"
		[global::Android.Runtime.Register ("com/mopub/common/event/EventDetails$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/common/event/EventDetails$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails.Builder']/constructor[@name='EventDetails.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static Delegate cb_adHeightPx_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetAdHeightPx_Ljava_lang_Integer_Handler ()
			{
				if (cb_adHeightPx_Ljava_lang_Integer_ == null)
					cb_adHeightPx_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AdHeightPx_Ljava_lang_Integer_);
				return cb_adHeightPx_Ljava_lang_Integer_;
			}

			static IntPtr n_AdHeightPx_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::com.mopub.common.events.EventDetails.Builder __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AdHeightPx (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_adHeightPx_Ljava_lang_Integer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails.Builder']/method[@name='adHeightPx' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("adHeightPx", "(Ljava/lang/Integer;)Lcom/mopub/common/event/EventDetails$Builder;", "GetAdHeightPx_Ljava_lang_Integer_Handler")]
			public virtual unsafe global::com.mopub.common.events.EventDetails.Builder AdHeightPx (global::Java.Lang.Integer p0)
			{
				if (id_adHeightPx_Ljava_lang_Integer_ == IntPtr.Zero)
					id_adHeightPx_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "adHeightPx", "(Ljava/lang/Integer;)Lcom/mopub/common/event/EventDetails$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::com.mopub.common.events.EventDetails.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_adHeightPx_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "adHeightPx", "(Ljava/lang/Integer;)Lcom/mopub/common/event/EventDetails$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_adNetworkType_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAdNetworkType_Ljava_lang_String_Handler ()
			{
				if (cb_adNetworkType_Ljava_lang_String_ == null)
					cb_adNetworkType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AdNetworkType_Ljava_lang_String_);
				return cb_adNetworkType_Ljava_lang_String_;
			}

			static IntPtr n_AdNetworkType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::com.mopub.common.events.EventDetails.Builder __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AdNetworkType (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_adNetworkType_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails.Builder']/method[@name='adNetworkType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("adNetworkType", "(Ljava/lang/String;)Lcom/mopub/common/event/EventDetails$Builder;", "GetAdNetworkType_Ljava_lang_String_Handler")]
			public virtual unsafe global::com.mopub.common.events.EventDetails.Builder AdNetworkType (string p0)
			{
				if (id_adNetworkType_Ljava_lang_String_ == IntPtr.Zero)
					id_adNetworkType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "adNetworkType", "(Ljava/lang/String;)Lcom/mopub/common/event/EventDetails$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::com.mopub.common.events.EventDetails.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_adNetworkType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "adNetworkType", "(Ljava/lang/String;)Lcom/mopub/common/event/EventDetails$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_adType_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAdType_Ljava_lang_String_Handler ()
			{
				if (cb_adType_Ljava_lang_String_ == null)
					cb_adType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AdType_Ljava_lang_String_);
				return cb_adType_Ljava_lang_String_;
			}

			static IntPtr n_AdType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::com.mopub.common.events.EventDetails.Builder __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AdType (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_adType_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails.Builder']/method[@name='adType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("adType", "(Ljava/lang/String;)Lcom/mopub/common/event/EventDetails$Builder;", "GetAdType_Ljava_lang_String_Handler")]
			public virtual unsafe global::com.mopub.common.events.EventDetails.Builder AdType (string p0)
			{
				if (id_adType_Ljava_lang_String_ == IntPtr.Zero)
					id_adType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "adType", "(Ljava/lang/String;)Lcom/mopub/common/event/EventDetails$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::com.mopub.common.events.EventDetails.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_adType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "adType", "(Ljava/lang/String;)Lcom/mopub/common/event/EventDetails$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_adUnitId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAdUnitId_Ljava_lang_String_Handler ()
			{
				if (cb_adUnitId_Ljava_lang_String_ == null)
					cb_adUnitId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AdUnitId_Ljava_lang_String_);
				return cb_adUnitId_Ljava_lang_String_;
			}

			static IntPtr n_AdUnitId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::com.mopub.common.events.EventDetails.Builder __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AdUnitId (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_adUnitId_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails.Builder']/method[@name='adUnitId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("adUnitId", "(Ljava/lang/String;)Lcom/mopub/common/event/EventDetails$Builder;", "GetAdUnitId_Ljava_lang_String_Handler")]
			public virtual unsafe global::com.mopub.common.events.EventDetails.Builder AdUnitId (string p0)
			{
				if (id_adUnitId_Ljava_lang_String_ == IntPtr.Zero)
					id_adUnitId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "adUnitId", "(Ljava/lang/String;)Lcom/mopub/common/event/EventDetails$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::com.mopub.common.events.EventDetails.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_adUnitId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "adUnitId", "(Ljava/lang/String;)Lcom/mopub/common/event/EventDetails$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_adWidthPx_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetAdWidthPx_Ljava_lang_Integer_Handler ()
			{
				if (cb_adWidthPx_Ljava_lang_Integer_ == null)
					cb_adWidthPx_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AdWidthPx_Ljava_lang_Integer_);
				return cb_adWidthPx_Ljava_lang_Integer_;
			}

			static IntPtr n_AdWidthPx_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::com.mopub.common.events.EventDetails.Builder __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AdWidthPx (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_adWidthPx_Ljava_lang_Integer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails.Builder']/method[@name='adWidthPx' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("adWidthPx", "(Ljava/lang/Integer;)Lcom/mopub/common/event/EventDetails$Builder;", "GetAdWidthPx_Ljava_lang_Integer_Handler")]
			public virtual unsafe global::com.mopub.common.events.EventDetails.Builder AdWidthPx (global::Java.Lang.Integer p0)
			{
				if (id_adWidthPx_Ljava_lang_Integer_ == IntPtr.Zero)
					id_adWidthPx_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "adWidthPx", "(Ljava/lang/Integer;)Lcom/mopub/common/event/EventDetails$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::com.mopub.common.events.EventDetails.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_adWidthPx_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "adWidthPx", "(Ljava/lang/Integer;)Lcom/mopub/common/event/EventDetails$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
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
				global::com.mopub.common.events.EventDetails.Builder __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/mopub/common/event/EventDetails;", "GetBuildHandler")]
			public virtual unsafe global::com.mopub.common.events.EventDetails Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/mopub/common/event/EventDetails;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/mopub/common/event/EventDetails;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_dspCreativeId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDspCreativeId_Ljava_lang_String_Handler ()
			{
				if (cb_dspCreativeId_Ljava_lang_String_ == null)
					cb_dspCreativeId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DspCreativeId_Ljava_lang_String_);
				return cb_dspCreativeId_Ljava_lang_String_;
			}

			static IntPtr n_DspCreativeId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::com.mopub.common.events.EventDetails.Builder __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DspCreativeId (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_dspCreativeId_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails.Builder']/method[@name='dspCreativeId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("dspCreativeId", "(Ljava/lang/String;)Lcom/mopub/common/event/EventDetails$Builder;", "GetDspCreativeId_Ljava_lang_String_Handler")]
			public virtual unsafe global::com.mopub.common.events.EventDetails.Builder DspCreativeId (string p0)
			{
				if (id_dspCreativeId_Ljava_lang_String_ == IntPtr.Zero)
					id_dspCreativeId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "dspCreativeId", "(Ljava/lang/String;)Lcom/mopub/common/event/EventDetails$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::com.mopub.common.events.EventDetails.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dspCreativeId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dspCreativeId", "(Ljava/lang/String;)Lcom/mopub/common/event/EventDetails$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_geoAccuracy_Ljava_lang_Float_;
#pragma warning disable 0169
			static Delegate GetGeoAccuracy_Ljava_lang_Float_Handler ()
			{
				if (cb_geoAccuracy_Ljava_lang_Float_ == null)
					cb_geoAccuracy_Ljava_lang_Float_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GeoAccuracy_Ljava_lang_Float_);
				return cb_geoAccuracy_Ljava_lang_Float_;
			}

			static IntPtr n_GeoAccuracy_Ljava_lang_Float_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::com.mopub.common.events.EventDetails.Builder __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Float p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Float> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GeoAccuracy (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_geoAccuracy_Ljava_lang_Float_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails.Builder']/method[@name='geoAccuracy' and count(parameter)=1 and parameter[1][@type='java.lang.Float']]"
			[Register ("geoAccuracy", "(Ljava/lang/Float;)Lcom/mopub/common/event/EventDetails$Builder;", "GetGeoAccuracy_Ljava_lang_Float_Handler")]
			public virtual unsafe global::com.mopub.common.events.EventDetails.Builder GeoAccuracy (global::Java.Lang.Float p0)
			{
				if (id_geoAccuracy_Ljava_lang_Float_ == IntPtr.Zero)
					id_geoAccuracy_Ljava_lang_Float_ = JNIEnv.GetMethodID (class_ref, "geoAccuracy", "(Ljava/lang/Float;)Lcom/mopub/common/event/EventDetails$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::com.mopub.common.events.EventDetails.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_geoAccuracy_Ljava_lang_Float_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "geoAccuracy", "(Ljava/lang/Float;)Lcom/mopub/common/event/EventDetails$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_geoLatitude_Ljava_lang_Double_;
#pragma warning disable 0169
			static Delegate GetGeoLatitude_Ljava_lang_Double_Handler ()
			{
				if (cb_geoLatitude_Ljava_lang_Double_ == null)
					cb_geoLatitude_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GeoLatitude_Ljava_lang_Double_);
				return cb_geoLatitude_Ljava_lang_Double_;
			}

			static IntPtr n_GeoLatitude_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::com.mopub.common.events.EventDetails.Builder __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GeoLatitude (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_geoLatitude_Ljava_lang_Double_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails.Builder']/method[@name='geoLatitude' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("geoLatitude", "(Ljava/lang/Double;)Lcom/mopub/common/event/EventDetails$Builder;", "GetGeoLatitude_Ljava_lang_Double_Handler")]
			public virtual unsafe global::com.mopub.common.events.EventDetails.Builder GeoLatitude (global::Java.Lang.Double p0)
			{
				if (id_geoLatitude_Ljava_lang_Double_ == IntPtr.Zero)
					id_geoLatitude_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "geoLatitude", "(Ljava/lang/Double;)Lcom/mopub/common/event/EventDetails$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::com.mopub.common.events.EventDetails.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_geoLatitude_Ljava_lang_Double_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "geoLatitude", "(Ljava/lang/Double;)Lcom/mopub/common/event/EventDetails$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_geoLongitude_Ljava_lang_Double_;
#pragma warning disable 0169
			static Delegate GetGeoLongitude_Ljava_lang_Double_Handler ()
			{
				if (cb_geoLongitude_Ljava_lang_Double_ == null)
					cb_geoLongitude_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GeoLongitude_Ljava_lang_Double_);
				return cb_geoLongitude_Ljava_lang_Double_;
			}

			static IntPtr n_GeoLongitude_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::com.mopub.common.events.EventDetails.Builder __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GeoLongitude (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_geoLongitude_Ljava_lang_Double_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails.Builder']/method[@name='geoLongitude' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("geoLongitude", "(Ljava/lang/Double;)Lcom/mopub/common/event/EventDetails$Builder;", "GetGeoLongitude_Ljava_lang_Double_Handler")]
			public virtual unsafe global::com.mopub.common.events.EventDetails.Builder GeoLongitude (global::Java.Lang.Double p0)
			{
				if (id_geoLongitude_Ljava_lang_Double_ == IntPtr.Zero)
					id_geoLongitude_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "geoLongitude", "(Ljava/lang/Double;)Lcom/mopub/common/event/EventDetails$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::com.mopub.common.events.EventDetails.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_geoLongitude_Ljava_lang_Double_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "geoLongitude", "(Ljava/lang/Double;)Lcom/mopub/common/event/EventDetails$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_performanceDurationMs_Ljava_lang_Long_;
#pragma warning disable 0169
			static Delegate GetPerformanceDurationMs_Ljava_lang_Long_Handler ()
			{
				if (cb_performanceDurationMs_Ljava_lang_Long_ == null)
					cb_performanceDurationMs_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PerformanceDurationMs_Ljava_lang_Long_);
				return cb_performanceDurationMs_Ljava_lang_Long_;
			}

			static IntPtr n_PerformanceDurationMs_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::com.mopub.common.events.EventDetails.Builder __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PerformanceDurationMs (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_performanceDurationMs_Ljava_lang_Long_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails.Builder']/method[@name='performanceDurationMs' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("performanceDurationMs", "(Ljava/lang/Long;)Lcom/mopub/common/event/EventDetails$Builder;", "GetPerformanceDurationMs_Ljava_lang_Long_Handler")]
			public virtual unsafe global::com.mopub.common.events.EventDetails.Builder PerformanceDurationMs (global::Java.Lang.Long p0)
			{
				if (id_performanceDurationMs_Ljava_lang_Long_ == IntPtr.Zero)
					id_performanceDurationMs_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "performanceDurationMs", "(Ljava/lang/Long;)Lcom/mopub/common/event/EventDetails$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::com.mopub.common.events.EventDetails.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_performanceDurationMs_Ljava_lang_Long_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "performanceDurationMs", "(Ljava/lang/Long;)Lcom/mopub/common/event/EventDetails$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_requestId_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetRequestId_Ljava_lang_String_Handler ()
			{
				if (cb_requestId_Ljava_lang_String_ == null)
					cb_requestId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestId_Ljava_lang_String_);
				return cb_requestId_Ljava_lang_String_;
			}

			static IntPtr n_RequestId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::com.mopub.common.events.EventDetails.Builder __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RequestId (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_requestId_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails.Builder']/method[@name='requestId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("requestId", "(Ljava/lang/String;)Lcom/mopub/common/event/EventDetails$Builder;", "GetRequestId_Ljava_lang_String_Handler")]
			public virtual unsafe global::com.mopub.common.events.EventDetails.Builder RequestId (string p0)
			{
				if (id_requestId_Ljava_lang_String_ == IntPtr.Zero)
					id_requestId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "requestId", "(Ljava/lang/String;)Lcom/mopub/common/event/EventDetails$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::com.mopub.common.events.EventDetails.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_requestId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestId", "(Ljava/lang/String;)Lcom/mopub/common/event/EventDetails$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_requestStatusCode_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetRequestStatusCode_Ljava_lang_Integer_Handler ()
			{
				if (cb_requestStatusCode_Ljava_lang_Integer_ == null)
					cb_requestStatusCode_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestStatusCode_Ljava_lang_Integer_);
				return cb_requestStatusCode_Ljava_lang_Integer_;
			}

			static IntPtr n_RequestStatusCode_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::com.mopub.common.events.EventDetails.Builder __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RequestStatusCode (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_requestStatusCode_Ljava_lang_Integer_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails.Builder']/method[@name='requestStatusCode' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("requestStatusCode", "(Ljava/lang/Integer;)Lcom/mopub/common/event/EventDetails$Builder;", "GetRequestStatusCode_Ljava_lang_Integer_Handler")]
			public virtual unsafe global::com.mopub.common.events.EventDetails.Builder RequestStatusCode (global::Java.Lang.Integer p0)
			{
				if (id_requestStatusCode_Ljava_lang_Integer_ == IntPtr.Zero)
					id_requestStatusCode_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "requestStatusCode", "(Ljava/lang/Integer;)Lcom/mopub/common/event/EventDetails$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::com.mopub.common.events.EventDetails.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_requestStatusCode_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestStatusCode", "(Ljava/lang/Integer;)Lcom/mopub/common/event/EventDetails$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_requestUri_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetRequestUri_Ljava_lang_String_Handler ()
			{
				if (cb_requestUri_Ljava_lang_String_ == null)
					cb_requestUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestUri_Ljava_lang_String_);
				return cb_requestUri_Ljava_lang_String_;
			}

			static IntPtr n_RequestUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::com.mopub.common.events.EventDetails.Builder __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RequestUri (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_requestUri_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails.Builder']/method[@name='requestUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("requestUri", "(Ljava/lang/String;)Lcom/mopub/common/event/EventDetails$Builder;", "GetRequestUri_Ljava_lang_String_Handler")]
			public virtual unsafe global::com.mopub.common.events.EventDetails.Builder RequestUri (string p0)
			{
				if (id_requestUri_Ljava_lang_String_ == IntPtr.Zero)
					id_requestUri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "requestUri", "(Ljava/lang/String;)Lcom/mopub/common/event/EventDetails$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::com.mopub.common.events.EventDetails.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_requestUri_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestUri", "(Ljava/lang/String;)Lcom/mopub/common/event/EventDetails$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/common/event/EventDetails", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventDetails); }
		}

		protected EventDetails (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAdHeightPx;
#pragma warning disable 0169
		static Delegate GetGetAdHeightPxHandler ()
		{
			if (cb_getAdHeightPx == null)
				cb_getAdHeightPx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdHeightPx);
			return cb_getAdHeightPx;
		}

		static IntPtr n_GetAdHeightPx (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.common.events.EventDetails __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdHeightPx);
		}
#pragma warning restore 0169

		static IntPtr id_getAdHeightPx;
		public virtual unsafe global::Java.Lang.Double AdHeightPx {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails']/method[@name='getAdHeightPx' and count(parameter)=0]"
			[Register ("getAdHeightPx", "()Ljava/lang/Double;", "GetGetAdHeightPxHandler")]
			get {
				if (id_getAdHeightPx == IntPtr.Zero)
					id_getAdHeightPx = JNIEnv.GetMethodID (class_ref, "getAdHeightPx", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdHeightPx), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdHeightPx", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdNetworkType;
#pragma warning disable 0169
		static Delegate GetGetAdNetworkTypeHandler ()
		{
			if (cb_getAdNetworkType == null)
				cb_getAdNetworkType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdNetworkType);
			return cb_getAdNetworkType;
		}

		static IntPtr n_GetAdNetworkType (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.common.events.EventDetails __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdNetworkType);
		}
#pragma warning restore 0169

		static IntPtr id_getAdNetworkType;
		public virtual unsafe string AdNetworkType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails']/method[@name='getAdNetworkType' and count(parameter)=0]"
			[Register ("getAdNetworkType", "()Ljava/lang/String;", "GetGetAdNetworkTypeHandler")]
			get {
				if (id_getAdNetworkType == IntPtr.Zero)
					id_getAdNetworkType = JNIEnv.GetMethodID (class_ref, "getAdNetworkType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdNetworkType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdNetworkType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdType;
#pragma warning disable 0169
		static Delegate GetGetAdTypeHandler ()
		{
			if (cb_getAdType == null)
				cb_getAdType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdType);
			return cb_getAdType;
		}

		static IntPtr n_GetAdType (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.common.events.EventDetails __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdType);
		}
#pragma warning restore 0169

		static IntPtr id_getAdType;
		public virtual unsafe string AdType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails']/method[@name='getAdType' and count(parameter)=0]"
			[Register ("getAdType", "()Ljava/lang/String;", "GetGetAdTypeHandler")]
			get {
				if (id_getAdType == IntPtr.Zero)
					id_getAdType = JNIEnv.GetMethodID (class_ref, "getAdType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdUnitId;
#pragma warning disable 0169
		static Delegate GetGetAdUnitIdHandler ()
		{
			if (cb_getAdUnitId == null)
				cb_getAdUnitId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdUnitId);
			return cb_getAdUnitId;
		}

		static IntPtr n_GetAdUnitId (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.common.events.EventDetails __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdUnitId);
		}
#pragma warning restore 0169

		static IntPtr id_getAdUnitId;
		public virtual unsafe string AdUnitId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails']/method[@name='getAdUnitId' and count(parameter)=0]"
			[Register ("getAdUnitId", "()Ljava/lang/String;", "GetGetAdUnitIdHandler")]
			get {
				if (id_getAdUnitId == IntPtr.Zero)
					id_getAdUnitId = JNIEnv.GetMethodID (class_ref, "getAdUnitId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdUnitId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdUnitId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdWidthPx;
#pragma warning disable 0169
		static Delegate GetGetAdWidthPxHandler ()
		{
			if (cb_getAdWidthPx == null)
				cb_getAdWidthPx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdWidthPx);
			return cb_getAdWidthPx;
		}

		static IntPtr n_GetAdWidthPx (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.common.events.EventDetails __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdWidthPx);
		}
#pragma warning restore 0169

		static IntPtr id_getAdWidthPx;
		public virtual unsafe global::Java.Lang.Double AdWidthPx {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails']/method[@name='getAdWidthPx' and count(parameter)=0]"
			[Register ("getAdWidthPx", "()Ljava/lang/Double;", "GetGetAdWidthPxHandler")]
			get {
				if (id_getAdWidthPx == IntPtr.Zero)
					id_getAdWidthPx = JNIEnv.GetMethodID (class_ref, "getAdWidthPx", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdWidthPx), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdWidthPx", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDspCreativeId;
#pragma warning disable 0169
		static Delegate GetGetDspCreativeIdHandler ()
		{
			if (cb_getDspCreativeId == null)
				cb_getDspCreativeId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDspCreativeId);
			return cb_getDspCreativeId;
		}

		static IntPtr n_GetDspCreativeId (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.common.events.EventDetails __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DspCreativeId);
		}
#pragma warning restore 0169

		static IntPtr id_getDspCreativeId;
		public virtual unsafe string DspCreativeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails']/method[@name='getDspCreativeId' and count(parameter)=0]"
			[Register ("getDspCreativeId", "()Ljava/lang/String;", "GetGetDspCreativeIdHandler")]
			get {
				if (id_getDspCreativeId == IntPtr.Zero)
					id_getDspCreativeId = JNIEnv.GetMethodID (class_ref, "getDspCreativeId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDspCreativeId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDspCreativeId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGeoAccuracy;
#pragma warning disable 0169
		static Delegate GetGetGeoAccuracyHandler ()
		{
			if (cb_getGeoAccuracy == null)
				cb_getGeoAccuracy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGeoAccuracy);
			return cb_getGeoAccuracy;
		}

		static IntPtr n_GetGeoAccuracy (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.common.events.EventDetails __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GeoAccuracy);
		}
#pragma warning restore 0169

		static IntPtr id_getGeoAccuracy;
		public virtual unsafe global::Java.Lang.Double GeoAccuracy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails']/method[@name='getGeoAccuracy' and count(parameter)=0]"
			[Register ("getGeoAccuracy", "()Ljava/lang/Double;", "GetGetGeoAccuracyHandler")]
			get {
				if (id_getGeoAccuracy == IntPtr.Zero)
					id_getGeoAccuracy = JNIEnv.GetMethodID (class_ref, "getGeoAccuracy", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGeoAccuracy), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGeoAccuracy", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGeoLatitude;
#pragma warning disable 0169
		static Delegate GetGetGeoLatitudeHandler ()
		{
			if (cb_getGeoLatitude == null)
				cb_getGeoLatitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGeoLatitude);
			return cb_getGeoLatitude;
		}

		static IntPtr n_GetGeoLatitude (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.common.events.EventDetails __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GeoLatitude);
		}
#pragma warning restore 0169

		static IntPtr id_getGeoLatitude;
		public virtual unsafe global::Java.Lang.Double GeoLatitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails']/method[@name='getGeoLatitude' and count(parameter)=0]"
			[Register ("getGeoLatitude", "()Ljava/lang/Double;", "GetGetGeoLatitudeHandler")]
			get {
				if (id_getGeoLatitude == IntPtr.Zero)
					id_getGeoLatitude = JNIEnv.GetMethodID (class_ref, "getGeoLatitude", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGeoLatitude), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGeoLatitude", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGeoLongitude;
#pragma warning disable 0169
		static Delegate GetGetGeoLongitudeHandler ()
		{
			if (cb_getGeoLongitude == null)
				cb_getGeoLongitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGeoLongitude);
			return cb_getGeoLongitude;
		}

		static IntPtr n_GetGeoLongitude (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.common.events.EventDetails __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GeoLongitude);
		}
#pragma warning restore 0169

		static IntPtr id_getGeoLongitude;
		public virtual unsafe global::Java.Lang.Double GeoLongitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails']/method[@name='getGeoLongitude' and count(parameter)=0]"
			[Register ("getGeoLongitude", "()Ljava/lang/Double;", "GetGetGeoLongitudeHandler")]
			get {
				if (id_getGeoLongitude == IntPtr.Zero)
					id_getGeoLongitude = JNIEnv.GetMethodID (class_ref, "getGeoLongitude", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGeoLongitude), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGeoLongitude", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPerformanceDurationMs;
#pragma warning disable 0169
		static Delegate GetGetPerformanceDurationMsHandler ()
		{
			if (cb_getPerformanceDurationMs == null)
				cb_getPerformanceDurationMs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPerformanceDurationMs);
			return cb_getPerformanceDurationMs;
		}

		static IntPtr n_GetPerformanceDurationMs (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.common.events.EventDetails __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PerformanceDurationMs);
		}
#pragma warning restore 0169

		static IntPtr id_getPerformanceDurationMs;
		public virtual unsafe global::Java.Lang.Double PerformanceDurationMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails']/method[@name='getPerformanceDurationMs' and count(parameter)=0]"
			[Register ("getPerformanceDurationMs", "()Ljava/lang/Double;", "GetGetPerformanceDurationMsHandler")]
			get {
				if (id_getPerformanceDurationMs == IntPtr.Zero)
					id_getPerformanceDurationMs = JNIEnv.GetMethodID (class_ref, "getPerformanceDurationMs", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPerformanceDurationMs), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPerformanceDurationMs", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestId;
#pragma warning disable 0169
		static Delegate GetGetRequestIdHandler ()
		{
			if (cb_getRequestId == null)
				cb_getRequestId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestId);
			return cb_getRequestId;
		}

		static IntPtr n_GetRequestId (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.common.events.EventDetails __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestId);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestId;
		public virtual unsafe string RequestId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails']/method[@name='getRequestId' and count(parameter)=0]"
			[Register ("getRequestId", "()Ljava/lang/String;", "GetGetRequestIdHandler")]
			get {
				if (id_getRequestId == IntPtr.Zero)
					id_getRequestId = JNIEnv.GetMethodID (class_ref, "getRequestId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestStatusCode;
#pragma warning disable 0169
		static Delegate GetGetRequestStatusCodeHandler ()
		{
			if (cb_getRequestStatusCode == null)
				cb_getRequestStatusCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestStatusCode);
			return cb_getRequestStatusCode;
		}

		static IntPtr n_GetRequestStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.common.events.EventDetails __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestStatusCode);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestStatusCode;
		public virtual unsafe global::Java.Lang.Integer RequestStatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails']/method[@name='getRequestStatusCode' and count(parameter)=0]"
			[Register ("getRequestStatusCode", "()Ljava/lang/Integer;", "GetGetRequestStatusCodeHandler")]
			get {
				if (id_getRequestStatusCode == IntPtr.Zero)
					id_getRequestStatusCode = JNIEnv.GetMethodID (class_ref, "getRequestStatusCode", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestStatusCode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestStatusCode", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestUri;
#pragma warning disable 0169
		static Delegate GetGetRequestUriHandler ()
		{
			if (cb_getRequestUri == null)
				cb_getRequestUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestUri);
			return cb_getRequestUri;
		}

		static IntPtr n_GetRequestUri (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.common.events.EventDetails __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestUri);
		}
#pragma warning restore 0169

		static IntPtr id_getRequestUri;
		public virtual unsafe string RequestUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails']/method[@name='getRequestUri' and count(parameter)=0]"
			[Register ("getRequestUri", "()Ljava/lang/String;", "GetGetRequestUriHandler")]
			get {
				if (id_getRequestUri == IntPtr.Zero)
					id_getRequestUri = JNIEnv.GetMethodID (class_ref, "getRequestUri", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestUri), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestUri", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_toJsonString;
#pragma warning disable 0169
		static Delegate GetToJsonStringHandler ()
		{
			if (cb_toJsonString == null)
				cb_toJsonString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJsonString);
			return cb_toJsonString;
		}

		static IntPtr n_ToJsonString (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.common.events.EventDetails __this = global::Java.Lang.Object.GetObject<global::com.mopub.common.events.EventDetails> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToJsonString ());
		}
#pragma warning restore 0169

		static IntPtr id_toJsonString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.common.event']/class[@name='EventDetails']/method[@name='toJsonString' and count(parameter)=0]"
		[Register ("toJsonString", "()Ljava/lang/String;", "GetToJsonStringHandler")]
		public virtual unsafe string ToJsonString ()
		{
			if (id_toJsonString == IntPtr.Zero)
				id_toJsonString = JNIEnv.GetMethodID (class_ref, "toJsonString", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJsonString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toJsonString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
