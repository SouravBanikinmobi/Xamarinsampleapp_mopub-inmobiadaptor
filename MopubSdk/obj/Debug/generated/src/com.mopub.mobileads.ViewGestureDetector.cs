using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.mopub.mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='ViewGestureDetector']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/ViewGestureDetector", DoNotGenerateAcw=true)]
	public partial class ViewGestureDetector : global::Android.Views.GestureDetector {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='ViewGestureDetector.UserClickListener']"
		[Register ("com/mopub/mobileads/ViewGestureDetector$UserClickListener", "", "com.mopub.mobileads.ViewGestureDetector/IUserClickListenerInvoker")]
		public partial interface IUserClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='ViewGestureDetector.UserClickListener']/method[@name='onResetUserClick' and count(parameter)=0]"
			[Register ("onResetUserClick", "()V", "GetOnResetUserClickHandler:com.mopub.mobileads.ViewGestureDetector/IUserClickListenerInvoker, MopubSdk")]
			void OnResetUserClick ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='ViewGestureDetector.UserClickListener']/method[@name='onUserClick' and count(parameter)=0]"
			[Register ("onUserClick", "()V", "GetOnUserClickHandler:com.mopub.mobileads.ViewGestureDetector/IUserClickListenerInvoker, MopubSdk")]
			void OnUserClick ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='ViewGestureDetector.UserClickListener']/method[@name='wasClicked' and count(parameter)=0]"
			[Register ("wasClicked", "()Z", "GetWasClickedHandler:com.mopub.mobileads.ViewGestureDetector/IUserClickListenerInvoker, MopubSdk")]
			bool WasClicked ();

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/ViewGestureDetector$UserClickListener", DoNotGenerateAcw=true)]
		internal class IUserClickListenerInvoker : global::Java.Lang.Object, IUserClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/ViewGestureDetector$UserClickListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IUserClickListenerInvoker); }
			}

			IntPtr class_ref;

			public static IUserClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IUserClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.ViewGestureDetector.UserClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IUserClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onResetUserClick;
#pragma warning disable 0169
			static Delegate GetOnResetUserClickHandler ()
			{
				if (cb_onResetUserClick == null)
					cb_onResetUserClick = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResetUserClick);
				return cb_onResetUserClick;
			}

			static void n_OnResetUserClick (IntPtr jnienv, IntPtr native__this)
			{
				global::com.mopub.mobileads.ViewGestureDetector.IUserClickListener __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.ViewGestureDetector.IUserClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnResetUserClick ();
			}
#pragma warning restore 0169

			IntPtr id_onResetUserClick;
			public unsafe void OnResetUserClick ()
			{
				if (id_onResetUserClick == IntPtr.Zero)
					id_onResetUserClick = JNIEnv.GetMethodID (class_ref, "onResetUserClick", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResetUserClick);
			}

			static Delegate cb_onUserClick;
#pragma warning disable 0169
			static Delegate GetOnUserClickHandler ()
			{
				if (cb_onUserClick == null)
					cb_onUserClick = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnUserClick);
				return cb_onUserClick;
			}

			static void n_OnUserClick (IntPtr jnienv, IntPtr native__this)
			{
				global::com.mopub.mobileads.ViewGestureDetector.IUserClickListener __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.ViewGestureDetector.IUserClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnUserClick ();
			}
#pragma warning restore 0169

			IntPtr id_onUserClick;
			public unsafe void OnUserClick ()
			{
				if (id_onUserClick == IntPtr.Zero)
					id_onUserClick = JNIEnv.GetMethodID (class_ref, "onUserClick", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUserClick);
			}

			static Delegate cb_wasClicked;
#pragma warning disable 0169
			static Delegate GetWasClickedHandler ()
			{
				if (cb_wasClicked == null)
					cb_wasClicked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_WasClicked);
				return cb_wasClicked;
			}

			static bool n_WasClicked (IntPtr jnienv, IntPtr native__this)
			{
				global::com.mopub.mobileads.ViewGestureDetector.IUserClickListener __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.ViewGestureDetector.IUserClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.WasClicked ();
			}
#pragma warning restore 0169

			IntPtr id_wasClicked;
			public unsafe bool WasClicked ()
			{
				if (id_wasClicked == IntPtr.Zero)
					id_wasClicked = JNIEnv.GetMethodID (class_ref, "wasClicked", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_wasClicked);
			}

		}

		// event args for com.mopub.mobileads.ViewGestureDetector.UserClickListener.wasClicked
		public partial class WasClickedEventArgs : global::System.EventArgs {

			public WasClickedEventArgs (bool handled)
			{
				this.handled = handled;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/ViewGestureDetector_UserClickListenerImplementor")]
		internal sealed partial class IUserClickListenerImplementor : global::Java.Lang.Object, IUserClickListener {

			object sender;

			public IUserClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/mobileads/ViewGestureDetector_UserClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnResetUserClickHandler;
#pragma warning restore 0649

			public void OnResetUserClick ()
			{
				var __h = OnResetUserClickHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnUserClickHandler;
#pragma warning restore 0649

			public void OnUserClick ()
			{
				var __h = OnUserClickHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<WasClickedEventArgs> WasClickedHandler;
#pragma warning restore 0649

			public bool WasClicked ()
			{
				var __h = WasClickedHandler;
				if (__h == null)
					return false;
				var __e = new WasClickedEventArgs (true);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IUserClickListenerImplementor value)
			{
				return value.OnResetUserClickHandler == null && value.OnUserClickHandler == null && value.WasClickedHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/ViewGestureDetector", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewGestureDetector); }
		}

		protected ViewGestureDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_view_View_Lcom_mopub_common_AdReport_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='ViewGestureDetector']/constructor[@name='ViewGestureDetector' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.view.View'] and parameter[3][@type='com.mopub.common.AdReport']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/view/View;Lcom/mopub/common/AdReport;)V", "")]
		public unsafe ViewGestureDetector (global::Android.Content.Context p0, global::Android.Views.View p1, global::com.mopub.common.AdReport p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (ViewGestureDetector)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/view/View;Lcom/mopub/common/AdReport;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/view/View;Lcom/mopub/common/AdReport;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_view_View_Lcom_mopub_common_AdReport_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_view_View_Lcom_mopub_common_AdReport_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/view/View;Lcom/mopub/common/AdReport;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_view_View_Lcom_mopub_common_AdReport_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_view_View_Lcom_mopub_common_AdReport_, __args);
			} finally {
			}
		}

		static Delegate cb_sendTouchEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetSendTouchEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_sendTouchEvent_Landroid_view_MotionEvent_ == null)
				cb_sendTouchEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendTouchEvent_Landroid_view_MotionEvent_);
			return cb_sendTouchEvent_Landroid_view_MotionEvent_;
		}

		static void n_SendTouchEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::com.mopub.mobileads.ViewGestureDetector __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.ViewGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendTouchEvent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendTouchEvent_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='ViewGestureDetector']/method[@name='sendTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("sendTouchEvent", "(Landroid/view/MotionEvent;)V", "GetSendTouchEvent_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe void SendTouchEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_sendTouchEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_sendTouchEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "sendTouchEvent", "(Landroid/view/MotionEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendTouchEvent_Landroid_view_MotionEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendTouchEvent", "(Landroid/view/MotionEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setUserClickListener_Lcom_mopub_mobileads_ViewGestureDetector_UserClickListener_;
#pragma warning disable 0169
		static Delegate GetSetUserClickListener_Lcom_mopub_mobileads_ViewGestureDetector_UserClickListener_Handler ()
		{
			if (cb_setUserClickListener_Lcom_mopub_mobileads_ViewGestureDetector_UserClickListener_ == null)
				cb_setUserClickListener_Lcom_mopub_mobileads_ViewGestureDetector_UserClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserClickListener_Lcom_mopub_mobileads_ViewGestureDetector_UserClickListener_);
			return cb_setUserClickListener_Lcom_mopub_mobileads_ViewGestureDetector_UserClickListener_;
		}

		static void n_SetUserClickListener_Lcom_mopub_mobileads_ViewGestureDetector_UserClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::com.mopub.mobileads.ViewGestureDetector __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.ViewGestureDetector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::com.mopub.mobileads.ViewGestureDetector.IUserClickListener p0 = (global::com.mopub.mobileads.ViewGestureDetector.IUserClickListener)global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.ViewGestureDetector.IUserClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetUserClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setUserClickListener_Lcom_mopub_mobileads_ViewGestureDetector_UserClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='ViewGestureDetector']/method[@name='setUserClickListener' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.ViewGestureDetector.UserClickListener']]"
		[Register ("setUserClickListener", "(Lcom/mopub/mobileads/ViewGestureDetector$UserClickListener;)V", "GetSetUserClickListener_Lcom_mopub_mobileads_ViewGestureDetector_UserClickListener_Handler")]
		public virtual unsafe void SetUserClickListener (global::com.mopub.mobileads.ViewGestureDetector.IUserClickListener p0)
		{
			if (id_setUserClickListener_Lcom_mopub_mobileads_ViewGestureDetector_UserClickListener_ == IntPtr.Zero)
				id_setUserClickListener_Lcom_mopub_mobileads_ViewGestureDetector_UserClickListener_ = JNIEnv.GetMethodID (class_ref, "setUserClickListener", "(Lcom/mopub/mobileads/ViewGestureDetector$UserClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserClickListener_Lcom_mopub_mobileads_ViewGestureDetector_UserClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserClickListener", "(Lcom/mopub/mobileads/ViewGestureDetector$UserClickListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for com.mopub.mobileads.ViewGestureDetector.IUserClickListener"
		public event EventHandler ResetUserClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::com.mopub.mobileads.ViewGestureDetector.IUserClickListener, global::com.mopub.mobileads.ViewGestureDetector.IUserClickListenerImplementor>(
						ref weak_implementor_SetUserClickListener,
						__CreateIUserClickListenerImplementor,
						SetUserClickListener,
						__h => __h.OnResetUserClickHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::com.mopub.mobileads.ViewGestureDetector.IUserClickListener, global::com.mopub.mobileads.ViewGestureDetector.IUserClickListenerImplementor>(
						ref weak_implementor_SetUserClickListener,
						global::com.mopub.mobileads.ViewGestureDetector.IUserClickListenerImplementor.__IsEmpty,
						__v => SetUserClickListener (null),
						__h => __h.OnResetUserClickHandler -= value);
			}
		}

		public event EventHandler UserClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::com.mopub.mobileads.ViewGestureDetector.IUserClickListener, global::com.mopub.mobileads.ViewGestureDetector.IUserClickListenerImplementor>(
						ref weak_implementor_SetUserClickListener,
						__CreateIUserClickListenerImplementor,
						SetUserClickListener,
						__h => __h.OnUserClickHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::com.mopub.mobileads.ViewGestureDetector.IUserClickListener, global::com.mopub.mobileads.ViewGestureDetector.IUserClickListenerImplementor>(
						ref weak_implementor_SetUserClickListener,
						global::com.mopub.mobileads.ViewGestureDetector.IUserClickListenerImplementor.__IsEmpty,
						__v => SetUserClickListener (null),
						__h => __h.OnUserClickHandler -= value);
			}
		}

		public event EventHandler<global::com.mopub.mobileads.ViewGestureDetector.WasClickedEventArgs> WasClicked {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::com.mopub.mobileads.ViewGestureDetector.IUserClickListener, global::com.mopub.mobileads.ViewGestureDetector.IUserClickListenerImplementor>(
						ref weak_implementor_SetUserClickListener,
						__CreateIUserClickListenerImplementor,
						SetUserClickListener,
						__h => __h.WasClickedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::com.mopub.mobileads.ViewGestureDetector.IUserClickListener, global::com.mopub.mobileads.ViewGestureDetector.IUserClickListenerImplementor>(
						ref weak_implementor_SetUserClickListener,
						global::com.mopub.mobileads.ViewGestureDetector.IUserClickListenerImplementor.__IsEmpty,
						__v => SetUserClickListener (null),
						__h => __h.WasClickedHandler -= value);
			}
		}

		WeakReference weak_implementor_SetUserClickListener;

		global::com.mopub.mobileads.ViewGestureDetector.IUserClickListenerImplementor __CreateIUserClickListenerImplementor ()
		{
			return new global::com.mopub.mobileads.ViewGestureDetector.IUserClickListenerImplementor (this);
		}
#endregion
	}
}
