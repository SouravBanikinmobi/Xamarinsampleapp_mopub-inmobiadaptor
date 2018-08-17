using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='BaseNativeAd']"
	[global::Android.Runtime.Register ("com/mopub/nativeads/BaseNativeAd", DoNotGenerateAcw=true)]
	public abstract partial class BaseNativeAd : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='BaseNativeAd.NativeEventListener']"
		[Register ("com/mopub/nativeads/BaseNativeAd$NativeEventListener", "", "Com.Mopub.Nativeads.BaseNativeAd/INativeEventListenerInvoker")]
		public partial interface INativeEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='BaseNativeAd.NativeEventListener']/method[@name='onAdClicked' and count(parameter)=0]"
			[Register ("onAdClicked", "()V", "GetOnAdClickedHandler:Com.Mopub.Nativeads.BaseNativeAd/INativeEventListenerInvoker, MopubSdk")]
			void OnAdClicked ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='BaseNativeAd.NativeEventListener']/method[@name='onAdImpressed' and count(parameter)=0]"
			[Register ("onAdImpressed", "()V", "GetOnAdImpressedHandler:Com.Mopub.Nativeads.BaseNativeAd/INativeEventListenerInvoker, MopubSdk")]
			void OnAdImpressed ();

		}

		[global::Android.Runtime.Register ("com/mopub/nativeads/BaseNativeAd$NativeEventListener", DoNotGenerateAcw=true)]
		internal class INativeEventListenerInvoker : global::Java.Lang.Object, INativeEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/nativeads/BaseNativeAd$NativeEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (INativeEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static INativeEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<INativeEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.nativeads.BaseNativeAd.NativeEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public INativeEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onAdClicked;
#pragma warning disable 0169
			static Delegate GetOnAdClickedHandler ()
			{
				if (cb_onAdClicked == null)
					cb_onAdClicked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAdClicked);
				return cb_onAdClicked;
			}

			static void n_OnAdClicked (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Nativeads.BaseNativeAd.INativeEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.BaseNativeAd.INativeEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnAdClicked ();
			}
#pragma warning restore 0169

			IntPtr id_onAdClicked;
			public unsafe void OnAdClicked ()
			{
				if (id_onAdClicked == IntPtr.Zero)
					id_onAdClicked = JNIEnv.GetMethodID (class_ref, "onAdClicked", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdClicked);
			}

			static Delegate cb_onAdImpressed;
#pragma warning disable 0169
			static Delegate GetOnAdImpressedHandler ()
			{
				if (cb_onAdImpressed == null)
					cb_onAdImpressed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAdImpressed);
				return cb_onAdImpressed;
			}

			static void n_OnAdImpressed (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Nativeads.BaseNativeAd.INativeEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.BaseNativeAd.INativeEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnAdImpressed ();
			}
#pragma warning restore 0169

			IntPtr id_onAdImpressed;
			public unsafe void OnAdImpressed ()
			{
				if (id_onAdImpressed == IntPtr.Zero)
					id_onAdImpressed = JNIEnv.GetMethodID (class_ref, "onAdImpressed", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdImpressed);
			}

		}

		[global::Android.Runtime.Register ("mono/com/mopub/nativeads/BaseNativeAd_NativeEventListenerImplementor")]
		internal sealed partial class INativeEventListenerImplementor : global::Java.Lang.Object, INativeEventListener {

			object sender;

			public INativeEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/nativeads/BaseNativeAd_NativeEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnAdClickedHandler;
#pragma warning restore 0649

			public void OnAdClicked ()
			{
				var __h = OnAdClickedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnAdImpressedHandler;
#pragma warning restore 0649

			public void OnAdImpressed ()
			{
				var __h = OnAdImpressedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (INativeEventListenerImplementor value)
			{
				return value.OnAdClickedHandler == null && value.OnAdImpressedHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/nativeads/BaseNativeAd", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseNativeAd); }
		}

		protected BaseNativeAd (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='BaseNativeAd']/constructor[@name='BaseNativeAd' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe BaseNativeAd ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BaseNativeAd)) {
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

		static IntPtr id_addClickTracker_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='BaseNativeAd']/method[@name='addClickTracker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addClickTracker", "(Ljava/lang/String;)V", "")]
		public unsafe void AddClickTracker (string p0)
		{
			if (id_addClickTracker_Ljava_lang_String_ == IntPtr.Zero)
				id_addClickTracker_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addClickTracker", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addClickTracker_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_addClickTrackers_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='BaseNativeAd']/method[@name='addClickTrackers' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("addClickTrackers", "(Ljava/lang/Object;)V", "")]
		protected unsafe void AddClickTrackers (global::Java.Lang.Object p0)
		{
			if (id_addClickTrackers_Ljava_lang_Object_ == IntPtr.Zero)
				id_addClickTrackers_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "addClickTrackers", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addClickTrackers_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_addImpressionTracker_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='BaseNativeAd']/method[@name='addImpressionTracker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addImpressionTracker", "(Ljava/lang/String;)V", "")]
		public unsafe void AddImpressionTracker (string p0)
		{
			if (id_addImpressionTracker_Ljava_lang_String_ == IntPtr.Zero)
				id_addImpressionTracker_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addImpressionTracker", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addImpressionTracker_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_addImpressionTrackers_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='BaseNativeAd']/method[@name='addImpressionTrackers' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("addImpressionTrackers", "(Ljava/lang/Object;)V", "")]
		protected unsafe void AddImpressionTrackers (global::Java.Lang.Object p0)
		{
			if (id_addImpressionTrackers_Ljava_lang_Object_ == IntPtr.Zero)
				id_addImpressionTrackers_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "addImpressionTrackers", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addImpressionTrackers_Ljava_lang_Object_, __args);
			} finally {
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
			global::Com.Mopub.Nativeads.BaseNativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.BaseNativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Clear (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='BaseNativeAd']/method[@name='clear' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("clear", "(Landroid/view/View;)V", "GetClear_Landroid_view_View_Handler")]
		public abstract void Clear (global::Android.Views.View p0);

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
			global::Com.Mopub.Nativeads.BaseNativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.BaseNativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='BaseNativeAd']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public abstract void Destroy ();

		static IntPtr id_notifyAdClicked;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='BaseNativeAd']/method[@name='notifyAdClicked' and count(parameter)=0]"
		[Register ("notifyAdClicked", "()V", "")]
		protected unsafe void NotifyAdClicked ()
		{
			if (id_notifyAdClicked == IntPtr.Zero)
				id_notifyAdClicked = JNIEnv.GetMethodID (class_ref, "notifyAdClicked", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyAdClicked);
			} finally {
			}
		}

		static IntPtr id_notifyAdImpressed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='BaseNativeAd']/method[@name='notifyAdImpressed' and count(parameter)=0]"
		[Register ("notifyAdImpressed", "()V", "")]
		protected unsafe void NotifyAdImpressed ()
		{
			if (id_notifyAdImpressed == IntPtr.Zero)
				id_notifyAdImpressed = JNIEnv.GetMethodID (class_ref, "notifyAdImpressed", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyAdImpressed);
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
			global::Com.Mopub.Nativeads.BaseNativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.BaseNativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Prepare (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='BaseNativeAd']/method[@name='prepare' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("prepare", "(Landroid/view/View;)V", "GetPrepare_Landroid_view_View_Handler")]
		public abstract void Prepare (global::Android.Views.View p0);

		static Delegate cb_setNativeEventListener_Lcom_mopub_nativeads_BaseNativeAd_NativeEventListener_;
#pragma warning disable 0169
		static Delegate GetSetNativeEventListener_Lcom_mopub_nativeads_BaseNativeAd_NativeEventListener_Handler ()
		{
			if (cb_setNativeEventListener_Lcom_mopub_nativeads_BaseNativeAd_NativeEventListener_ == null)
				cb_setNativeEventListener_Lcom_mopub_nativeads_BaseNativeAd_NativeEventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNativeEventListener_Lcom_mopub_nativeads_BaseNativeAd_NativeEventListener_);
			return cb_setNativeEventListener_Lcom_mopub_nativeads_BaseNativeAd_NativeEventListener_;
		}

		static void n_SetNativeEventListener_Lcom_mopub_nativeads_BaseNativeAd_NativeEventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.BaseNativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.BaseNativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.BaseNativeAd.INativeEventListener p0 = (global::Com.Mopub.Nativeads.BaseNativeAd.INativeEventListener)global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.BaseNativeAd.INativeEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNativeEventListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setNativeEventListener_Lcom_mopub_nativeads_BaseNativeAd_NativeEventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='BaseNativeAd']/method[@name='setNativeEventListener' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.BaseNativeAd.NativeEventListener']]"
		[Register ("setNativeEventListener", "(Lcom/mopub/nativeads/BaseNativeAd$NativeEventListener;)V", "GetSetNativeEventListener_Lcom_mopub_nativeads_BaseNativeAd_NativeEventListener_Handler")]
		public virtual unsafe void SetNativeEventListener (global::Com.Mopub.Nativeads.BaseNativeAd.INativeEventListener p0)
		{
			if (id_setNativeEventListener_Lcom_mopub_nativeads_BaseNativeAd_NativeEventListener_ == IntPtr.Zero)
				id_setNativeEventListener_Lcom_mopub_nativeads_BaseNativeAd_NativeEventListener_ = JNIEnv.GetMethodID (class_ref, "setNativeEventListener", "(Lcom/mopub/nativeads/BaseNativeAd$NativeEventListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNativeEventListener_Lcom_mopub_nativeads_BaseNativeAd_NativeEventListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNativeEventListener", "(Lcom/mopub/nativeads/BaseNativeAd$NativeEventListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Mopub.Nativeads.BaseNativeAd.INativeEventListener"
		public event EventHandler AdClicked {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Nativeads.BaseNativeAd.INativeEventListener, global::Com.Mopub.Nativeads.BaseNativeAd.INativeEventListenerImplementor>(
						ref weak_implementor_SetNativeEventListener,
						__CreateINativeEventListenerImplementor,
						SetNativeEventListener,
						__h => __h.OnAdClickedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Nativeads.BaseNativeAd.INativeEventListener, global::Com.Mopub.Nativeads.BaseNativeAd.INativeEventListenerImplementor>(
						ref weak_implementor_SetNativeEventListener,
						global::Com.Mopub.Nativeads.BaseNativeAd.INativeEventListenerImplementor.__IsEmpty,
						__v => SetNativeEventListener (null),
						__h => __h.OnAdClickedHandler -= value);
			}
		}

		public event EventHandler AdImpressed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Nativeads.BaseNativeAd.INativeEventListener, global::Com.Mopub.Nativeads.BaseNativeAd.INativeEventListenerImplementor>(
						ref weak_implementor_SetNativeEventListener,
						__CreateINativeEventListenerImplementor,
						SetNativeEventListener,
						__h => __h.OnAdImpressedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Nativeads.BaseNativeAd.INativeEventListener, global::Com.Mopub.Nativeads.BaseNativeAd.INativeEventListenerImplementor>(
						ref weak_implementor_SetNativeEventListener,
						global::Com.Mopub.Nativeads.BaseNativeAd.INativeEventListenerImplementor.__IsEmpty,
						__v => SetNativeEventListener (null),
						__h => __h.OnAdImpressedHandler -= value);
			}
		}

		WeakReference weak_implementor_SetNativeEventListener;

		global::Com.Mopub.Nativeads.BaseNativeAd.INativeEventListenerImplementor __CreateINativeEventListenerImplementor ()
		{
			return new global::Com.Mopub.Nativeads.BaseNativeAd.INativeEventListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/mopub/nativeads/BaseNativeAd", DoNotGenerateAcw=true)]
	internal partial class BaseNativeAdInvoker : BaseNativeAd {

		public BaseNativeAdInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseNativeAdInvoker); }
		}

		static IntPtr id_clear_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='BaseNativeAd']/method[@name='clear' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("clear", "(Landroid/view/View;)V", "GetClear_Landroid_view_View_Handler")]
		public override unsafe void Clear (global::Android.Views.View p0)
		{
			if (id_clear_Landroid_view_View_ == IntPtr.Zero)
				id_clear_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "clear", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear_Landroid_view_View_, __args);
			} finally {
			}
		}

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='BaseNativeAd']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public override unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
			} finally {
			}
		}

		static IntPtr id_prepare_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='BaseNativeAd']/method[@name='prepare' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("prepare", "(Landroid/view/View;)V", "GetPrepare_Landroid_view_View_Handler")]
		public override unsafe void Prepare (global::Android.Views.View p0)
		{
			if (id_prepare_Landroid_view_View_ == IntPtr.Zero)
				id_prepare_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "prepare", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepare_Landroid_view_View_, __args);
			} finally {
			}
		}

	}

}
