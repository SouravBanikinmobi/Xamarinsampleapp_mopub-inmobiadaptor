using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeAd']"
	[global::Android.Runtime.Register ("com/mopub/nativeads/NativeAd", DoNotGenerateAcw=true)]
	public partial class NativeAd : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='NativeAd.MoPubNativeEventListener']"
		[Register ("com/mopub/nativeads/NativeAd$MoPubNativeEventListener", "", "Com.Mopub.Nativeads.NativeAd/IMoPubNativeEventListenerInvoker")]
		public partial interface IMoPubNativeEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='NativeAd.MoPubNativeEventListener']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler:Com.Mopub.Nativeads.NativeAd/IMoPubNativeEventListenerInvoker, MopubSdk")]
			void OnClick (global::Android.Views.View p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='NativeAd.MoPubNativeEventListener']/method[@name='onImpression' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("onImpression", "(Landroid/view/View;)V", "GetOnImpression_Landroid_view_View_Handler:Com.Mopub.Nativeads.NativeAd/IMoPubNativeEventListenerInvoker, MopubSdk")]
			void OnImpression (global::Android.Views.View p0);

		}

		[global::Android.Runtime.Register ("com/mopub/nativeads/NativeAd$MoPubNativeEventListener", DoNotGenerateAcw=true)]
		internal class IMoPubNativeEventListenerInvoker : global::Java.Lang.Object, IMoPubNativeEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/nativeads/NativeAd$MoPubNativeEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IMoPubNativeEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IMoPubNativeEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMoPubNativeEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.nativeads.NativeAd.MoPubNativeEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMoPubNativeEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onClick_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnClick_Landroid_view_View_Handler ()
			{
				if (cb_onClick_Landroid_view_View_ == null)
					cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClick_Landroid_view_View_);
				return cb_onClick_Landroid_view_View_;
			}

			static void n_OnClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Nativeads.NativeAd.IMoPubNativeEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeAd.IMoPubNativeEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onClick_Landroid_view_View_;
			public unsafe void OnClick (global::Android.Views.View p0)
			{
				if (id_onClick_Landroid_view_View_ == IntPtr.Zero)
					id_onClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/view/View;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Landroid_view_View_, __args);
			}

			static Delegate cb_onImpression_Landroid_view_View_;
#pragma warning disable 0169
			static Delegate GetOnImpression_Landroid_view_View_Handler ()
			{
				if (cb_onImpression_Landroid_view_View_ == null)
					cb_onImpression_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnImpression_Landroid_view_View_);
				return cb_onImpression_Landroid_view_View_;
			}

			static void n_OnImpression_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Nativeads.NativeAd.IMoPubNativeEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeAd.IMoPubNativeEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnImpression (p0);
			}
#pragma warning restore 0169

			IntPtr id_onImpression_Landroid_view_View_;
			public unsafe void OnImpression (global::Android.Views.View p0)
			{
				if (id_onImpression_Landroid_view_View_ == IntPtr.Zero)
					id_onImpression_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onImpression", "(Landroid/view/View;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onImpression_Landroid_view_View_, __args);
			}

		}

		// event args for com.mopub.nativeads.NativeAd.MoPubNativeEventListener.onClick
		public partial class ClickEventArgs : global::System.EventArgs {

			public ClickEventArgs (global::Android.Views.View p0)
			{
				this.p0 = p0;
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}
		}

		// event args for com.mopub.nativeads.NativeAd.MoPubNativeEventListener.onImpression
		public partial class ImpressionEventArgs : global::System.EventArgs {

			public ImpressionEventArgs (global::Android.Views.View p0)
			{
				this.p0 = p0;
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/nativeads/NativeAd_MoPubNativeEventListenerImplementor")]
		internal sealed partial class IMoPubNativeEventListenerImplementor : global::Java.Lang.Object, IMoPubNativeEventListener {

			object sender;

			public IMoPubNativeEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/nativeads/NativeAd_MoPubNativeEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ClickEventArgs> OnClickHandler;
#pragma warning restore 0649

			public void OnClick (global::Android.Views.View p0)
			{
				var __h = OnClickHandler;
				if (__h != null)
					__h (sender, new ClickEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<ImpressionEventArgs> OnImpressionHandler;
#pragma warning restore 0649

			public void OnImpression (global::Android.Views.View p0)
			{
				var __h = OnImpressionHandler;
				if (__h != null)
					__h (sender, new ImpressionEventArgs (p0));
			}

			internal static bool __IsEmpty (IMoPubNativeEventListenerImplementor value)
			{
				return value.OnClickHandler == null && value.OnImpressionHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/nativeads/NativeAd", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeAd); }
		}

		protected NativeAd (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mopub_nativeads_BaseNativeAd_Lcom_mopub_nativeads_MoPubAdRenderer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeAd']/constructor[@name='NativeAd' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.mopub.nativeads.BaseNativeAd'] and parameter[6][@type='com.mopub.nativeads.MoPubAdRenderer']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/mopub/nativeads/BaseNativeAd;Lcom/mopub/nativeads/MoPubAdRenderer;)V", "")]
		public unsafe NativeAd (global::Android.Content.Context p0, string p1, string p2, string p3, global::Com.Mopub.Nativeads.BaseNativeAd p4, global::Com.Mopub.Nativeads.IMoPubAdRenderer p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				if (((object) this).GetType () != typeof (NativeAd)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/mopub/nativeads/BaseNativeAd;Lcom/mopub/nativeads/MoPubAdRenderer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/mopub/nativeads/BaseNativeAd;Lcom/mopub/nativeads/MoPubAdRenderer;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mopub_nativeads_BaseNativeAd_Lcom_mopub_nativeads_MoPubAdRenderer_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mopub_nativeads_BaseNativeAd_Lcom_mopub_nativeads_MoPubAdRenderer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/mopub/nativeads/BaseNativeAd;Lcom/mopub/nativeads/MoPubAdRenderer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mopub_nativeads_BaseNativeAd_Lcom_mopub_nativeads_MoPubAdRenderer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_mopub_nativeads_BaseNativeAd_Lcom_mopub_nativeads_MoPubAdRenderer_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
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
			global::Com.Mopub.Nativeads.NativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdUnitId);
		}
#pragma warning restore 0169

		static IntPtr id_getAdUnitId;
		public virtual unsafe string AdUnitId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeAd']/method[@name='getAdUnitId' and count(parameter)=0]"
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

		static Delegate cb_getBaseNativeAd;
#pragma warning disable 0169
		static Delegate GetGetBaseNativeAdHandler ()
		{
			if (cb_getBaseNativeAd == null)
				cb_getBaseNativeAd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBaseNativeAd);
			return cb_getBaseNativeAd;
		}

		static IntPtr n_GetBaseNativeAd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.NativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BaseNativeAd);
		}
#pragma warning restore 0169

		static IntPtr id_getBaseNativeAd;
		public virtual unsafe global::Com.Mopub.Nativeads.BaseNativeAd BaseNativeAd {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeAd']/method[@name='getBaseNativeAd' and count(parameter)=0]"
			[Register ("getBaseNativeAd", "()Lcom/mopub/nativeads/BaseNativeAd;", "GetGetBaseNativeAdHandler")]
			get {
				if (id_getBaseNativeAd == IntPtr.Zero)
					id_getBaseNativeAd = JNIEnv.GetMethodID (class_ref, "getBaseNativeAd", "()Lcom/mopub/nativeads/BaseNativeAd;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.BaseNativeAd> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBaseNativeAd), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.BaseNativeAd> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBaseNativeAd", "()Lcom/mopub/nativeads/BaseNativeAd;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isDestroyed;
#pragma warning disable 0169
		static Delegate GetIsDestroyedHandler ()
		{
			if (cb_isDestroyed == null)
				cb_isDestroyed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDestroyed);
			return cb_isDestroyed;
		}

		static bool n_IsDestroyed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.NativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDestroyed;
		}
#pragma warning restore 0169

		static IntPtr id_isDestroyed;
		public virtual unsafe bool IsDestroyed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeAd']/method[@name='isDestroyed' and count(parameter)=0]"
			[Register ("isDestroyed", "()Z", "GetIsDestroyedHandler")]
			get {
				if (id_isDestroyed == IntPtr.Zero)
					id_isDestroyed = JNIEnv.GetMethodID (class_ref, "isDestroyed", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDestroyed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDestroyed", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMoPubAdRenderer;
#pragma warning disable 0169
		static Delegate GetGetMoPubAdRendererHandler ()
		{
			if (cb_getMoPubAdRenderer == null)
				cb_getMoPubAdRenderer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMoPubAdRenderer);
			return cb_getMoPubAdRenderer;
		}

		static IntPtr n_GetMoPubAdRenderer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.NativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MoPubAdRenderer);
		}
#pragma warning restore 0169

		static IntPtr id_getMoPubAdRenderer;
		public virtual unsafe global::Com.Mopub.Nativeads.IMoPubAdRenderer MoPubAdRenderer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeAd']/method[@name='getMoPubAdRenderer' and count(parameter)=0]"
			[Register ("getMoPubAdRenderer", "()Lcom/mopub/nativeads/MoPubAdRenderer;", "GetGetMoPubAdRendererHandler")]
			get {
				if (id_getMoPubAdRenderer == IntPtr.Zero)
					id_getMoPubAdRenderer = JNIEnv.GetMethodID (class_ref, "getMoPubAdRenderer", "()Lcom/mopub/nativeads/MoPubAdRenderer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IMoPubAdRenderer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMoPubAdRenderer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IMoPubAdRenderer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMoPubAdRenderer", "()Lcom/mopub/nativeads/MoPubAdRenderer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clear_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetClear_Landroid_view_View_Handler ()
		{
			if (cb_clear_Landroid_view_View_ == null)
				cb_clear_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Clear_Landroid_view_View_);
			return cb_clear_Landroid_view_View_;
		}

		static void n_Clear_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.NativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Clear (p0);
		}
#pragma warning restore 0169

		static IntPtr id_clear_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeAd']/method[@name='clear' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("clear", "(Landroid/view/View;)V", "GetClear_Landroid_view_View_Handler")]
		public virtual unsafe void Clear (global::Android.Views.View p0)
		{
			if (id_clear_Landroid_view_View_ == IntPtr.Zero)
				id_clear_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "clear", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_createAdView_Landroid_app_Activity_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetCreateAdView_Landroid_app_Activity_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_createAdView_Landroid_app_Activity_Landroid_view_ViewGroup_ == null)
				cb_createAdView_Landroid_app_Activity_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateAdView_Landroid_app_Activity_Landroid_view_ViewGroup_);
			return cb_createAdView_Landroid_app_Activity_Landroid_view_ViewGroup_;
		}

		static IntPtr n_CreateAdView_Landroid_app_Activity_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Nativeads.NativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p1 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAdView (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createAdView_Landroid_app_Activity_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeAd']/method[@name='createAdView' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.view.ViewGroup']]"
		[Register ("createAdView", "(Landroid/app/Activity;Landroid/view/ViewGroup;)Landroid/view/View;", "GetCreateAdView_Landroid_app_Activity_Landroid_view_ViewGroup_Handler")]
		public virtual unsafe global::Android.Views.View CreateAdView (global::Android.App.Activity p0, global::Android.Views.ViewGroup p1)
		{
			if (id_createAdView_Landroid_app_Activity_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_createAdView_Landroid_app_Activity_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "createAdView", "(Landroid/app/Activity;Landroid/view/ViewGroup;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Views.View __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createAdView_Landroid_app_Activity_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createAdView", "(Landroid/app/Activity;Landroid/view/ViewGroup;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::Com.Mopub.Nativeads.NativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeAd']/method[@name='destroy' and count(parameter)=0]"
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

		static Delegate cb_prepare_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetPrepare_Landroid_view_View_Handler ()
		{
			if (cb_prepare_Landroid_view_View_ == null)
				cb_prepare_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Prepare_Landroid_view_View_);
			return cb_prepare_Landroid_view_View_;
		}

		static void n_Prepare_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.NativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Prepare (p0);
		}
#pragma warning restore 0169

		static IntPtr id_prepare_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeAd']/method[@name='prepare' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("prepare", "(Landroid/view/View;)V", "GetPrepare_Landroid_view_View_Handler")]
		public virtual unsafe void Prepare (global::Android.Views.View p0)
		{
			if (id_prepare_Landroid_view_View_ == IntPtr.Zero)
				id_prepare_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "prepare", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepare_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepare", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_renderAdView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetRenderAdView_Landroid_view_View_Handler ()
		{
			if (cb_renderAdView_Landroid_view_View_ == null)
				cb_renderAdView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RenderAdView_Landroid_view_View_);
			return cb_renderAdView_Landroid_view_View_;
		}

		static void n_RenderAdView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.NativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RenderAdView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_renderAdView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeAd']/method[@name='renderAdView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("renderAdView", "(Landroid/view/View;)V", "GetRenderAdView_Landroid_view_View_Handler")]
		public virtual unsafe void RenderAdView (global::Android.Views.View p0)
		{
			if (id_renderAdView_Landroid_view_View_ == IntPtr.Zero)
				id_renderAdView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "renderAdView", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_renderAdView_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "renderAdView", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMoPubNativeEventListener_Lcom_mopub_nativeads_NativeAd_MoPubNativeEventListener_;
#pragma warning disable 0169
		static Delegate GetSetMoPubNativeEventListener_Lcom_mopub_nativeads_NativeAd_MoPubNativeEventListener_Handler ()
		{
			if (cb_setMoPubNativeEventListener_Lcom_mopub_nativeads_NativeAd_MoPubNativeEventListener_ == null)
				cb_setMoPubNativeEventListener_Lcom_mopub_nativeads_NativeAd_MoPubNativeEventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMoPubNativeEventListener_Lcom_mopub_nativeads_NativeAd_MoPubNativeEventListener_);
			return cb_setMoPubNativeEventListener_Lcom_mopub_nativeads_NativeAd_MoPubNativeEventListener_;
		}

		static void n_SetMoPubNativeEventListener_Lcom_mopub_nativeads_NativeAd_MoPubNativeEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.NativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.NativeAd.IMoPubNativeEventListener p0 = (global::Com.Mopub.Nativeads.NativeAd.IMoPubNativeEventListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeAd.IMoPubNativeEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMoPubNativeEventListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMoPubNativeEventListener_Lcom_mopub_nativeads_NativeAd_MoPubNativeEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeAd']/method[@name='setMoPubNativeEventListener' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.NativeAd.MoPubNativeEventListener']]"
		[Register ("setMoPubNativeEventListener", "(Lcom/mopub/nativeads/NativeAd$MoPubNativeEventListener;)V", "GetSetMoPubNativeEventListener_Lcom_mopub_nativeads_NativeAd_MoPubNativeEventListener_Handler")]
		public virtual unsafe void SetMoPubNativeEventListener (global::Com.Mopub.Nativeads.NativeAd.IMoPubNativeEventListener p0)
		{
			if (id_setMoPubNativeEventListener_Lcom_mopub_nativeads_NativeAd_MoPubNativeEventListener_ == IntPtr.Zero)
				id_setMoPubNativeEventListener_Lcom_mopub_nativeads_NativeAd_MoPubNativeEventListener_ = JNIEnv.GetMethodID (class_ref, "setMoPubNativeEventListener", "(Lcom/mopub/nativeads/NativeAd$MoPubNativeEventListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMoPubNativeEventListener_Lcom_mopub_nativeads_NativeAd_MoPubNativeEventListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMoPubNativeEventListener", "(Lcom/mopub/nativeads/NativeAd$MoPubNativeEventListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Mopub.Nativeads.NativeAd.IMoPubNativeEventListener"
		public event EventHandler<global::Com.Mopub.Nativeads.NativeAd.ClickEventArgs> Click {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Nativeads.NativeAd.IMoPubNativeEventListener, global::Com.Mopub.Nativeads.NativeAd.IMoPubNativeEventListenerImplementor>(
						ref weak_implementor_SetMoPubNativeEventListener,
						__CreateIMoPubNativeEventListenerImplementor,
						SetMoPubNativeEventListener,
						__h => __h.OnClickHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Nativeads.NativeAd.IMoPubNativeEventListener, global::Com.Mopub.Nativeads.NativeAd.IMoPubNativeEventListenerImplementor>(
						ref weak_implementor_SetMoPubNativeEventListener,
						global::Com.Mopub.Nativeads.NativeAd.IMoPubNativeEventListenerImplementor.__IsEmpty,
						__v => SetMoPubNativeEventListener (null),
						__h => __h.OnClickHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Nativeads.NativeAd.ImpressionEventArgs> Impression {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Nativeads.NativeAd.IMoPubNativeEventListener, global::Com.Mopub.Nativeads.NativeAd.IMoPubNativeEventListenerImplementor>(
						ref weak_implementor_SetMoPubNativeEventListener,
						__CreateIMoPubNativeEventListenerImplementor,
						SetMoPubNativeEventListener,
						__h => __h.OnImpressionHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Nativeads.NativeAd.IMoPubNativeEventListener, global::Com.Mopub.Nativeads.NativeAd.IMoPubNativeEventListenerImplementor>(
						ref weak_implementor_SetMoPubNativeEventListener,
						global::Com.Mopub.Nativeads.NativeAd.IMoPubNativeEventListenerImplementor.__IsEmpty,
						__v => SetMoPubNativeEventListener (null),
						__h => __h.OnImpressionHandler -= value);
			}
		}

		WeakReference weak_implementor_SetMoPubNativeEventListener;

		global::Com.Mopub.Nativeads.NativeAd.IMoPubNativeEventListenerImplementor __CreateIMoPubNativeEventListenerImplementor ()
		{
			return new global::Com.Mopub.Nativeads.NativeAd.IMoPubNativeEventListenerImplementor (this);
		}
#endregion
	}
}
