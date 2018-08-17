using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='AdRendererRegistry']"
	[global::Android.Runtime.Register ("com/mopub/nativeads/AdRendererRegistry", DoNotGenerateAcw=true)]
	public partial class AdRendererRegistry : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/nativeads/AdRendererRegistry", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdRendererRegistry); }
		}

		protected AdRendererRegistry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='AdRendererRegistry']/constructor[@name='AdRendererRegistry' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AdRendererRegistry ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AdRendererRegistry)) {
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

		static Delegate cb_getAdRendererCount;
#pragma warning disable 0169
		static Delegate GetGetAdRendererCountHandler ()
		{
			if (cb_getAdRendererCount == null)
				cb_getAdRendererCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAdRendererCount);
			return cb_getAdRendererCount;
		}

		static int n_GetAdRendererCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.AdRendererRegistry __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.AdRendererRegistry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdRendererCount;
		}
#pragma warning restore 0169

		static IntPtr id_getAdRendererCount;
		public virtual unsafe int AdRendererCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='AdRendererRegistry']/method[@name='getAdRendererCount' and count(parameter)=0]"
			[Register ("getAdRendererCount", "()I", "GetGetAdRendererCountHandler")]
			get {
				if (id_getAdRendererCount == IntPtr.Zero)
					id_getAdRendererCount = JNIEnv.GetMethodID (class_ref, "getAdRendererCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdRendererCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdRendererCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getRendererIterable;
#pragma warning disable 0169
		static Delegate GetGetRendererIterableHandler ()
		{
			if (cb_getRendererIterable == null)
				cb_getRendererIterable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRendererIterable);
			return cb_getRendererIterable;
		}

		static IntPtr n_GetRendererIterable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.AdRendererRegistry __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.AdRendererRegistry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RendererIterable);
		}
#pragma warning restore 0169

		static IntPtr id_getRendererIterable;
		public virtual unsafe global::Java.Lang.IIterable RendererIterable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='AdRendererRegistry']/method[@name='getRendererIterable' and count(parameter)=0]"
			[Register ("getRendererIterable", "()Ljava/lang/Iterable;", "GetGetRendererIterableHandler")]
			get {
				if (id_getRendererIterable == IntPtr.Zero)
					id_getRendererIterable = JNIEnv.GetMethodID (class_ref, "getRendererIterable", "()Ljava/lang/Iterable;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRendererIterable), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRendererIterable", "()Ljava/lang/Iterable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRendererForAd_Lcom_mopub_nativeads_BaseNativeAd_;
#pragma warning disable 0169
		static Delegate GetGetRendererForAd_Lcom_mopub_nativeads_BaseNativeAd_Handler ()
		{
			if (cb_getRendererForAd_Lcom_mopub_nativeads_BaseNativeAd_ == null)
				cb_getRendererForAd_Lcom_mopub_nativeads_BaseNativeAd_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRendererForAd_Lcom_mopub_nativeads_BaseNativeAd_);
			return cb_getRendererForAd_Lcom_mopub_nativeads_BaseNativeAd_;
		}

		static IntPtr n_GetRendererForAd_Lcom_mopub_nativeads_BaseNativeAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.AdRendererRegistry __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.AdRendererRegistry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.BaseNativeAd p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.BaseNativeAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRendererForAd (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRendererForAd_Lcom_mopub_nativeads_BaseNativeAd_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='AdRendererRegistry']/method[@name='getRendererForAd' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.BaseNativeAd']]"
		[Register ("getRendererForAd", "(Lcom/mopub/nativeads/BaseNativeAd;)Lcom/mopub/nativeads/MoPubAdRenderer;", "GetGetRendererForAd_Lcom_mopub_nativeads_BaseNativeAd_Handler")]
		public virtual unsafe global::Com.Mopub.Nativeads.IMoPubAdRenderer GetRendererForAd (global::Com.Mopub.Nativeads.BaseNativeAd p0)
		{
			if (id_getRendererForAd_Lcom_mopub_nativeads_BaseNativeAd_ == IntPtr.Zero)
				id_getRendererForAd_Lcom_mopub_nativeads_BaseNativeAd_ = JNIEnv.GetMethodID (class_ref, "getRendererForAd", "(Lcom/mopub/nativeads/BaseNativeAd;)Lcom/mopub/nativeads/MoPubAdRenderer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mopub.Nativeads.IMoPubAdRenderer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IMoPubAdRenderer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRendererForAd_Lcom_mopub_nativeads_BaseNativeAd_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IMoPubAdRenderer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRendererForAd", "(Lcom/mopub/nativeads/BaseNativeAd;)Lcom/mopub/nativeads/MoPubAdRenderer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getRendererForViewType_I;
#pragma warning disable 0169
		static Delegate GetGetRendererForViewType_IHandler ()
		{
			if (cb_getRendererForViewType_I == null)
				cb_getRendererForViewType_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetRendererForViewType_I);
			return cb_getRendererForViewType_I;
		}

		static IntPtr n_GetRendererForViewType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.AdRendererRegistry __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.AdRendererRegistry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetRendererForViewType (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getRendererForViewType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='AdRendererRegistry']/method[@name='getRendererForViewType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getRendererForViewType", "(I)Lcom/mopub/nativeads/MoPubAdRenderer;", "GetGetRendererForViewType_IHandler")]
		public virtual unsafe global::Com.Mopub.Nativeads.IMoPubAdRenderer GetRendererForViewType (int p0)
		{
			if (id_getRendererForViewType_I == IntPtr.Zero)
				id_getRendererForViewType_I = JNIEnv.GetMethodID (class_ref, "getRendererForViewType", "(I)Lcom/mopub/nativeads/MoPubAdRenderer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IMoPubAdRenderer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRendererForViewType_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IMoPubAdRenderer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRendererForViewType", "(I)Lcom/mopub/nativeads/MoPubAdRenderer;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getViewTypeForAd_Lcom_mopub_nativeads_NativeAd_;
#pragma warning disable 0169
		static Delegate GetGetViewTypeForAd_Lcom_mopub_nativeads_NativeAd_Handler ()
		{
			if (cb_getViewTypeForAd_Lcom_mopub_nativeads_NativeAd_ == null)
				cb_getViewTypeForAd_Lcom_mopub_nativeads_NativeAd_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetViewTypeForAd_Lcom_mopub_nativeads_NativeAd_);
			return cb_getViewTypeForAd_Lcom_mopub_nativeads_NativeAd_;
		}

		static int n_GetViewTypeForAd_Lcom_mopub_nativeads_NativeAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.AdRendererRegistry __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.AdRendererRegistry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.NativeAd p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetViewTypeForAd (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getViewTypeForAd_Lcom_mopub_nativeads_NativeAd_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='AdRendererRegistry']/method[@name='getViewTypeForAd' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.NativeAd']]"
		[Register ("getViewTypeForAd", "(Lcom/mopub/nativeads/NativeAd;)I", "GetGetViewTypeForAd_Lcom_mopub_nativeads_NativeAd_Handler")]
		public virtual unsafe int GetViewTypeForAd (global::Com.Mopub.Nativeads.NativeAd p0)
		{
			if (id_getViewTypeForAd_Lcom_mopub_nativeads_NativeAd_ == IntPtr.Zero)
				id_getViewTypeForAd_Lcom_mopub_nativeads_NativeAd_ = JNIEnv.GetMethodID (class_ref, "getViewTypeForAd", "(Lcom/mopub/nativeads/NativeAd;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getViewTypeForAd_Lcom_mopub_nativeads_NativeAd_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getViewTypeForAd", "(Lcom/mopub/nativeads/NativeAd;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_;
#pragma warning disable 0169
		static Delegate GetRegisterAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_Handler ()
		{
			if (cb_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_ == null)
				cb_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_);
			return cb_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_;
		}

		static void n_RegisterAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.AdRendererRegistry __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.AdRendererRegistry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.IMoPubAdRenderer p0 = (global::Com.Mopub.Nativeads.IMoPubAdRenderer)global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IMoPubAdRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterAdRenderer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='AdRendererRegistry']/method[@name='registerAdRenderer' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.MoPubAdRenderer']]"
		[Register ("registerAdRenderer", "(Lcom/mopub/nativeads/MoPubAdRenderer;)V", "GetRegisterAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_Handler")]
		public virtual unsafe void RegisterAdRenderer (global::Com.Mopub.Nativeads.IMoPubAdRenderer p0)
		{
			if (id_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_ == IntPtr.Zero)
				id_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_ = JNIEnv.GetMethodID (class_ref, "registerAdRenderer", "(Lcom/mopub/nativeads/MoPubAdRenderer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerAdRenderer", "(Lcom/mopub/nativeads/MoPubAdRenderer;)V"), __args);
			} finally {
			}
		}

	}
}
