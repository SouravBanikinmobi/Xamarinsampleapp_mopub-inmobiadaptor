using System;
using System.Collections.Generic;
using Android.Runtime;

namespace com.mopub.mobileads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubView", DoNotGenerateAcw=true)]
	public partial class MoPubView : global::Android.Widget.FrameLayout {


		static IntPtr mAdViewController_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/field[@name='mAdViewController']"
		[Register ("mAdViewController")]
		protected global::com.mopub.mobileads.AdViewController MAdViewController {
			get {
				if (mAdViewController_jfieldId == IntPtr.Zero)
					mAdViewController_jfieldId = JNIEnv.GetFieldID (class_ref, "mAdViewController", "Lcom/mopub/mobileads/AdViewController;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAdViewController_jfieldId);
				return global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.AdViewController> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAdViewController_jfieldId == IntPtr.Zero)
					mAdViewController_jfieldId = JNIEnv.GetFieldID (class_ref, "mAdViewController", "Lcom/mopub/mobileads/AdViewController;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAdViewController_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCustomEventBannerAdapter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/field[@name='mCustomEventBannerAdapter']"
		[Register ("mCustomEventBannerAdapter")]
		protected global::com.mopub.mobileads.CustomEventBannerAdapter MCustomEventBannerAdapter {
			get {
				if (mCustomEventBannerAdapter_jfieldId == IntPtr.Zero)
					mCustomEventBannerAdapter_jfieldId = JNIEnv.GetFieldID (class_ref, "mCustomEventBannerAdapter", "Lcom/mopub/mobileads/CustomEventBannerAdapter;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCustomEventBannerAdapter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.CustomEventBannerAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCustomEventBannerAdapter_jfieldId == IntPtr.Zero)
					mCustomEventBannerAdapter_jfieldId = JNIEnv.GetFieldID (class_ref, "mCustomEventBannerAdapter", "Lcom/mopub/mobileads/CustomEventBannerAdapter;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCustomEventBannerAdapter_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.BannerAdListener']"
		[Register ("com/mopub/mobileads/MoPubView$BannerAdListener", "", "com.mopub.mobileads.MoPubView/IBannerAdListenerInvoker")]
		public partial interface IBannerAdListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.BannerAdListener']/method[@name='onBannerClicked' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView']]"
			[Register ("onBannerClicked", "(Lcom/mopub/mobileads/MoPubView;)V", "GetOnBannerClicked_Lcom_mopub_mobileads_MoPubView_Handler:com.mopub.mobileads.MoPubView/IBannerAdListenerInvoker, MopubSdk")]
			void OnBannerClicked (global::com.mopub.mobileads.MoPubView p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.BannerAdListener']/method[@name='onBannerCollapsed' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView']]"
			[Register ("onBannerCollapsed", "(Lcom/mopub/mobileads/MoPubView;)V", "GetOnBannerCollapsed_Lcom_mopub_mobileads_MoPubView_Handler:com.mopub.mobileads.MoPubView/IBannerAdListenerInvoker, MopubSdk")]
			void OnBannerCollapsed (global::com.mopub.mobileads.MoPubView p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.BannerAdListener']/method[@name='onBannerExpanded' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView']]"
			[Register ("onBannerExpanded", "(Lcom/mopub/mobileads/MoPubView;)V", "GetOnBannerExpanded_Lcom_mopub_mobileads_MoPubView_Handler:com.mopub.mobileads.MoPubView/IBannerAdListenerInvoker, MopubSdk")]
			void OnBannerExpanded (global::com.mopub.mobileads.MoPubView p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.BannerAdListener']/method[@name='onBannerFailed' and count(parameter)=2 and parameter[1][@type='com.mopub.mobileads.MoPubView'] and parameter[2][@type='com.mopub.mobileads.MoPubErrorCode']]"
			[Register ("onBannerFailed", "(Lcom/mopub/mobileads/MoPubView;Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetOnBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_Handler:com.mopub.mobileads.MoPubView/IBannerAdListenerInvoker, MopubSdk")]
			void OnBannerFailed (global::com.mopub.mobileads.MoPubView p0, global::com.mopub.mobileads.MoPubErrorCode p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubView.BannerAdListener']/method[@name='onBannerLoaded' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView']]"
			[Register ("onBannerLoaded", "(Lcom/mopub/mobileads/MoPubView;)V", "GetOnBannerLoaded_Lcom_mopub_mobileads_MoPubView_Handler:com.mopub.mobileads.MoPubView/IBannerAdListenerInvoker, MopubSdk")]
			void OnBannerLoaded (global::com.mopub.mobileads.MoPubView p0);

		}

		[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubView$BannerAdListener", DoNotGenerateAcw=true)]
		internal class IBannerAdListenerInvoker : global::Java.Lang.Object, IBannerAdListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/MoPubView$BannerAdListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IBannerAdListenerInvoker); }
			}

			IntPtr class_ref;

			public static IBannerAdListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBannerAdListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.MoPubView.BannerAdListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBannerAdListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onBannerClicked_Lcom_mopub_mobileads_MoPubView_;
#pragma warning disable 0169
			static Delegate GetOnBannerClicked_Lcom_mopub_mobileads_MoPubView_Handler ()
			{
				if (cb_onBannerClicked_Lcom_mopub_mobileads_MoPubView_ == null)
					cb_onBannerClicked_Lcom_mopub_mobileads_MoPubView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBannerClicked_Lcom_mopub_mobileads_MoPubView_);
				return cb_onBannerClicked_Lcom_mopub_mobileads_MoPubView_;
			}

			static void n_OnBannerClicked_Lcom_mopub_mobileads_MoPubView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::com.mopub.mobileads.MoPubView.IBannerAdListener __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView.IBannerAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::com.mopub.mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnBannerClicked (p0);
			}
#pragma warning restore 0169

			IntPtr id_onBannerClicked_Lcom_mopub_mobileads_MoPubView_;
			public unsafe void OnBannerClicked (global::com.mopub.mobileads.MoPubView p0)
			{
				if (id_onBannerClicked_Lcom_mopub_mobileads_MoPubView_ == IntPtr.Zero)
					id_onBannerClicked_Lcom_mopub_mobileads_MoPubView_ = JNIEnv.GetMethodID (class_ref, "onBannerClicked", "(Lcom/mopub/mobileads/MoPubView;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerClicked_Lcom_mopub_mobileads_MoPubView_, __args);
			}

			static Delegate cb_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_;
#pragma warning disable 0169
			static Delegate GetOnBannerCollapsed_Lcom_mopub_mobileads_MoPubView_Handler ()
			{
				if (cb_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_ == null)
					cb_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBannerCollapsed_Lcom_mopub_mobileads_MoPubView_);
				return cb_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_;
			}

			static void n_OnBannerCollapsed_Lcom_mopub_mobileads_MoPubView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::com.mopub.mobileads.MoPubView.IBannerAdListener __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView.IBannerAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::com.mopub.mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnBannerCollapsed (p0);
			}
#pragma warning restore 0169

			IntPtr id_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_;
			public unsafe void OnBannerCollapsed (global::com.mopub.mobileads.MoPubView p0)
			{
				if (id_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_ == IntPtr.Zero)
					id_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_ = JNIEnv.GetMethodID (class_ref, "onBannerCollapsed", "(Lcom/mopub/mobileads/MoPubView;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerCollapsed_Lcom_mopub_mobileads_MoPubView_, __args);
			}

			static Delegate cb_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_;
#pragma warning disable 0169
			static Delegate GetOnBannerExpanded_Lcom_mopub_mobileads_MoPubView_Handler ()
			{
				if (cb_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_ == null)
					cb_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBannerExpanded_Lcom_mopub_mobileads_MoPubView_);
				return cb_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_;
			}

			static void n_OnBannerExpanded_Lcom_mopub_mobileads_MoPubView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::com.mopub.mobileads.MoPubView.IBannerAdListener __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView.IBannerAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::com.mopub.mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnBannerExpanded (p0);
			}
#pragma warning restore 0169

			IntPtr id_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_;
			public unsafe void OnBannerExpanded (global::com.mopub.mobileads.MoPubView p0)
			{
				if (id_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_ == IntPtr.Zero)
					id_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_ = JNIEnv.GetMethodID (class_ref, "onBannerExpanded", "(Lcom/mopub/mobileads/MoPubView;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerExpanded_Lcom_mopub_mobileads_MoPubView_, __args);
			}

			static Delegate cb_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_;
#pragma warning disable 0169
			static Delegate GetOnBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_Handler ()
			{
				if (cb_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_ == null)
					cb_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_);
				return cb_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_;
			}

			static void n_OnBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::com.mopub.mobileads.MoPubView.IBannerAdListener __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView.IBannerAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::com.mopub.mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::com.mopub.mobileads.MoPubErrorCode p1 = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubErrorCode> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnBannerFailed (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_;
			public unsafe void OnBannerFailed (global::com.mopub.mobileads.MoPubView p0, global::com.mopub.mobileads.MoPubErrorCode p1)
			{
				if (id_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
					id_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "onBannerFailed", "(Lcom/mopub/mobileads/MoPubView;Lcom/mopub/mobileads/MoPubErrorCode;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerFailed_Lcom_mopub_mobileads_MoPubView_Lcom_mopub_mobileads_MoPubErrorCode_, __args);
			}

			static Delegate cb_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_;
#pragma warning disable 0169
			static Delegate GetOnBannerLoaded_Lcom_mopub_mobileads_MoPubView_Handler ()
			{
				if (cb_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_ == null)
					cb_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBannerLoaded_Lcom_mopub_mobileads_MoPubView_);
				return cb_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_;
			}

			static void n_OnBannerLoaded_Lcom_mopub_mobileads_MoPubView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::com.mopub.mobileads.MoPubView.IBannerAdListener __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView.IBannerAdListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::com.mopub.mobileads.MoPubView p0 = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnBannerLoaded (p0);
			}
#pragma warning restore 0169

			IntPtr id_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_;
			public unsafe void OnBannerLoaded (global::com.mopub.mobileads.MoPubView p0)
			{
				if (id_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_ == IntPtr.Zero)
					id_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_ = JNIEnv.GetMethodID (class_ref, "onBannerLoaded", "(Lcom/mopub/mobileads/MoPubView;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBannerLoaded_Lcom_mopub_mobileads_MoPubView_, __args);
			}

		}

		// event args for com.mopub.mobileads.MoPubView.BannerAdListener.onBannerClicked
		public partial class BannerClickedEventArgs : global::System.EventArgs {

			public BannerClickedEventArgs (global::com.mopub.mobileads.MoPubView p0)
			{
				this.p0 = p0;
			}

			global::com.mopub.mobileads.MoPubView p0;
			public global::com.mopub.mobileads.MoPubView P0 {
				get { return p0; }
			}
		}

		// event args for com.mopub.mobileads.MoPubView.BannerAdListener.onBannerCollapsed
		public partial class BannerCollapsedEventArgs : global::System.EventArgs {

			public BannerCollapsedEventArgs (global::com.mopub.mobileads.MoPubView p0)
			{
				this.p0 = p0;
			}

			global::com.mopub.mobileads.MoPubView p0;
			public global::com.mopub.mobileads.MoPubView P0 {
				get { return p0; }
			}
		}

		// event args for com.mopub.mobileads.MoPubView.BannerAdListener.onBannerExpanded
		public partial class BannerExpandedEventArgs : global::System.EventArgs {

			public BannerExpandedEventArgs (global::com.mopub.mobileads.MoPubView p0)
			{
				this.p0 = p0;
			}

			global::com.mopub.mobileads.MoPubView p0;
			public global::com.mopub.mobileads.MoPubView P0 {
				get { return p0; }
			}
		}

		// event args for com.mopub.mobileads.MoPubView.BannerAdListener.onBannerFailed
		public partial class BannerFailedEventArgs : global::System.EventArgs {

			public BannerFailedEventArgs (global::com.mopub.mobileads.MoPubView p0, global::com.mopub.mobileads.MoPubErrorCode p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::com.mopub.mobileads.MoPubView p0;
			public global::com.mopub.mobileads.MoPubView P0 {
				get { return p0; }
			}

			global::com.mopub.mobileads.MoPubErrorCode p1;
			public global::com.mopub.mobileads.MoPubErrorCode P1 {
				get { return p1; }
			}
		}

		// event args for com.mopub.mobileads.MoPubView.BannerAdListener.onBannerLoaded
		public partial class BannerLoadedEventArgs : global::System.EventArgs {

			public BannerLoadedEventArgs (global::com.mopub.mobileads.MoPubView p0)
			{
				this.p0 = p0;
			}

			global::com.mopub.mobileads.MoPubView p0;
			public global::com.mopub.mobileads.MoPubView P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/mobileads/MoPubView_BannerAdListenerImplementor")]
		internal sealed partial class IBannerAdListenerImplementor : global::Java.Lang.Object, IBannerAdListener {

			object sender;

			public IBannerAdListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/mobileads/MoPubView_BannerAdListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<BannerClickedEventArgs> OnBannerClickedHandler;
#pragma warning restore 0649

			public void OnBannerClicked (global::com.mopub.mobileads.MoPubView p0)
			{
				var __h = OnBannerClickedHandler;
				if (__h != null)
					__h (sender, new BannerClickedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<BannerCollapsedEventArgs> OnBannerCollapsedHandler;
#pragma warning restore 0649

			public void OnBannerCollapsed (global::com.mopub.mobileads.MoPubView p0)
			{
				var __h = OnBannerCollapsedHandler;
				if (__h != null)
					__h (sender, new BannerCollapsedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<BannerExpandedEventArgs> OnBannerExpandedHandler;
#pragma warning restore 0649

			public void OnBannerExpanded (global::com.mopub.mobileads.MoPubView p0)
			{
				var __h = OnBannerExpandedHandler;
				if (__h != null)
					__h (sender, new BannerExpandedEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<BannerFailedEventArgs> OnBannerFailedHandler;
#pragma warning restore 0649

			public void OnBannerFailed (global::com.mopub.mobileads.MoPubView p0, global::com.mopub.mobileads.MoPubErrorCode p1)
			{
				var __h = OnBannerFailedHandler;
				if (__h != null)
					__h (sender, new BannerFailedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<BannerLoadedEventArgs> OnBannerLoadedHandler;
#pragma warning restore 0649

			public void OnBannerLoaded (global::com.mopub.mobileads.MoPubView p0)
			{
				var __h = OnBannerLoadedHandler;
				if (__h != null)
					__h (sender, new BannerLoadedEventArgs (p0));
			}

			internal static bool __IsEmpty (IBannerAdListenerImplementor value)
			{
				return value.OnBannerClickedHandler == null && value.OnBannerCollapsedHandler == null && value.OnBannerExpandedHandler == null && value.OnBannerFailedHandler == null && value.OnBannerLoadedHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/MoPubView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubView); }
		}

		protected MoPubView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/constructor[@name='MoPubView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MoPubView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MoPubView)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/constructor[@name='MoPubView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe MoPubView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MoPubView)) {
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

		static Delegate cb_getActivity;
#pragma warning disable 0169
		static Delegate GetGetActivityHandler ()
		{
			if (cb_getActivity == null)
				cb_getActivity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActivity);
			return cb_getActivity;
		}

		static IntPtr n_GetActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Activity);
		}
#pragma warning restore 0169

		static IntPtr id_getActivity;
		public virtual unsafe global::Android.App.Activity Activity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getActivity' and count(parameter)=0]"
			[Register ("getActivity", "()Landroid/app/Activity;", "GetGetActivityHandler")]
			get {
				if (id_getActivity == IntPtr.Zero)
					id_getActivity = JNIEnv.GetMethodID (class_ref, "getActivity", "()Landroid/app/Activity;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActivity), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActivity", "()Landroid/app/Activity;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdFormat;
#pragma warning disable 0169
		static Delegate GetGetAdFormatHandler ()
		{
			if (cb_getAdFormat == null)
				cb_getAdFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdFormat);
			return cb_getAdFormat;
		}

		static IntPtr n_GetAdFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdFormat);
		}
#pragma warning restore 0169

		static IntPtr id_getAdFormat;
		public virtual unsafe global::com.mopub.common.AdFormat AdFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getAdFormat' and count(parameter)=0]"
			[Register ("getAdFormat", "()Lcom/mopub/common/AdFormat;", "GetGetAdFormatHandler")]
			get {
				if (id_getAdFormat == IntPtr.Zero)
					id_getAdFormat = JNIEnv.GetMethodID (class_ref, "getAdFormat", "()Lcom/mopub/common/AdFormat;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::com.mopub.common.AdFormat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdFormat), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::com.mopub.common.AdFormat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdFormat", "()Lcom/mopub/common/AdFormat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdHeight;
#pragma warning disable 0169
		static Delegate GetGetAdHeightHandler ()
		{
			if (cb_getAdHeight == null)
				cb_getAdHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAdHeight);
			return cb_getAdHeight;
		}

		static int n_GetAdHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getAdHeight;
		public virtual unsafe int AdHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getAdHeight' and count(parameter)=0]"
			[Register ("getAdHeight", "()I", "GetGetAdHeightHandler")]
			get {
				if (id_getAdHeight == IntPtr.Zero)
					id_getAdHeight = JNIEnv.GetMethodID (class_ref, "getAdHeight", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdHeight", "()I"));
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
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdUnitId);
		}
#pragma warning restore 0169

		static Delegate cb_setAdUnitId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAdUnitId_Ljava_lang_String_Handler ()
		{
			if (cb_setAdUnitId_Ljava_lang_String_ == null)
				cb_setAdUnitId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdUnitId_Ljava_lang_String_);
			return cb_setAdUnitId_Ljava_lang_String_;
		}

		static void n_SetAdUnitId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AdUnitId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAdUnitId;
		static IntPtr id_setAdUnitId_Ljava_lang_String_;
		public virtual unsafe string AdUnitId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getAdUnitId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setAdUnitId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAdUnitId", "(Ljava/lang/String;)V", "GetSetAdUnitId_Ljava_lang_String_Handler")]
			set {
				if (id_setAdUnitId_Ljava_lang_String_ == IntPtr.Zero)
					id_setAdUnitId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAdUnitId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdUnitId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdUnitId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAdWidth;
#pragma warning disable 0169
		static Delegate GetGetAdWidthHandler ()
		{
			if (cb_getAdWidth == null)
				cb_getAdWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAdWidth);
			return cb_getAdWidth;
		}

		static int n_GetAdWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getAdWidth;
		public virtual unsafe int AdWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getAdWidth' and count(parameter)=0]"
			[Register ("getAdWidth", "()I", "GetGetAdWidthHandler")]
			get {
				if (id_getAdWidth == IntPtr.Zero)
					id_getAdWidth = JNIEnv.GetMethodID (class_ref, "getAdWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getAutorefreshEnabled;
#pragma warning disable 0169
		static Delegate GetGetAutorefreshEnabledHandler ()
		{
			if (cb_getAutorefreshEnabled == null)
				cb_getAutorefreshEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAutorefreshEnabled);
			return cb_getAutorefreshEnabled;
		}

		static bool n_GetAutorefreshEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutorefreshEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setAutorefreshEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetAutorefreshEnabled_ZHandler ()
		{
			if (cb_setAutorefreshEnabled_Z == null)
				cb_setAutorefreshEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAutorefreshEnabled_Z);
			return cb_setAutorefreshEnabled_Z;
		}

		static void n_SetAutorefreshEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutorefreshEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAutorefreshEnabled;
		static IntPtr id_setAutorefreshEnabled_Z;
		public virtual unsafe bool AutorefreshEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getAutorefreshEnabled' and count(parameter)=0]"
			[Register ("getAutorefreshEnabled", "()Z", "GetGetAutorefreshEnabledHandler")]
			get {
				if (id_getAutorefreshEnabled == IntPtr.Zero)
					id_getAutorefreshEnabled = JNIEnv.GetMethodID (class_ref, "getAutorefreshEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getAutorefreshEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAutorefreshEnabled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setAutorefreshEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutorefreshEnabled", "(Z)V", "GetSetAutorefreshEnabled_ZHandler")]
			set {
				if (id_setAutorefreshEnabled_Z == IntPtr.Zero)
					id_setAutorefreshEnabled_Z = JNIEnv.GetMethodID (class_ref, "setAutorefreshEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAutorefreshEnabled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAutorefreshEnabled", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBannerAdListener;
#pragma warning disable 0169
		static Delegate GetGetBannerAdListenerHandler ()
		{
			if (cb_getBannerAdListener == null)
				cb_getBannerAdListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBannerAdListener);
			return cb_getBannerAdListener;
		}

		static IntPtr n_GetBannerAdListener (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BannerAdListener);
		}
#pragma warning restore 0169

		static Delegate cb_setBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_;
#pragma warning disable 0169
		static Delegate GetSetBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_Handler ()
		{
			if (cb_setBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_ == null)
				cb_setBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_);
			return cb_setBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_;
		}

		static void n_SetBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::com.mopub.mobileads.MoPubView.IBannerAdListener p0 = (global::com.mopub.mobileads.MoPubView.IBannerAdListener)global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView.IBannerAdListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BannerAdListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBannerAdListener;
		static IntPtr id_setBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_;
		public virtual unsafe global::com.mopub.mobileads.MoPubView.IBannerAdListener BannerAdListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getBannerAdListener' and count(parameter)=0]"
			[Register ("getBannerAdListener", "()Lcom/mopub/mobileads/MoPubView$BannerAdListener;", "GetGetBannerAdListenerHandler")]
			get {
				if (id_getBannerAdListener == IntPtr.Zero)
					id_getBannerAdListener = JNIEnv.GetMethodID (class_ref, "getBannerAdListener", "()Lcom/mopub/mobileads/MoPubView$BannerAdListener;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView.IBannerAdListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBannerAdListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView.IBannerAdListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBannerAdListener", "()Lcom/mopub/mobileads/MoPubView$BannerAdListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setBannerAdListener' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubView.BannerAdListener']]"
			[Register ("setBannerAdListener", "(Lcom/mopub/mobileads/MoPubView$BannerAdListener;)V", "GetSetBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_Handler")]
			set {
				if (id_setBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_ == IntPtr.Zero)
					id_setBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_ = JNIEnv.GetMethodID (class_ref, "setBannerAdListener", "(Lcom/mopub/mobileads/MoPubView$BannerAdListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBannerAdListener_Lcom_mopub_mobileads_MoPubView_BannerAdListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBannerAdListener", "(Lcom/mopub/mobileads/MoPubView$BannerAdListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getClickTrackingUrl;
#pragma warning disable 0169
		static Delegate GetGetClickTrackingUrlHandler ()
		{
			if (cb_getClickTrackingUrl == null)
				cb_getClickTrackingUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClickTrackingUrl);
			return cb_getClickTrackingUrl;
		}

		static IntPtr n_GetClickTrackingUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClickTrackingUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getClickTrackingUrl;
		[Obsolete (@"deprecated")]
		public virtual unsafe string ClickTrackingUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getClickTrackingUrl' and count(parameter)=0]"
			[Register ("getClickTrackingUrl", "()Ljava/lang/String;", "GetGetClickTrackingUrlHandler")]
			get {
				if (id_getClickTrackingUrl == IntPtr.Zero)
					id_getClickTrackingUrl = JNIEnv.GetMethodID (class_ref, "getClickTrackingUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClickTrackingUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClickTrackingUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getKeywords;
#pragma warning disable 0169
		static Delegate GetGetKeywordsHandler ()
		{
			if (cb_getKeywords == null)
				cb_getKeywords = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKeywords);
			return cb_getKeywords;
		}

		static IntPtr n_GetKeywords (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Keywords);
		}
#pragma warning restore 0169

		static Delegate cb_setKeywords_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetKeywords_Ljava_lang_String_Handler ()
		{
			if (cb_setKeywords_Ljava_lang_String_ == null)
				cb_setKeywords_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKeywords_Ljava_lang_String_);
			return cb_setKeywords_Ljava_lang_String_;
		}

		static void n_SetKeywords_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Keywords = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getKeywords;
		static IntPtr id_setKeywords_Ljava_lang_String_;
		public virtual unsafe string Keywords {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getKeywords' and count(parameter)=0]"
			[Register ("getKeywords", "()Ljava/lang/String;", "GetGetKeywordsHandler")]
			get {
				if (id_getKeywords == IntPtr.Zero)
					id_getKeywords = JNIEnv.GetMethodID (class_ref, "getKeywords", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKeywords), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeywords", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setKeywords' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setKeywords", "(Ljava/lang/String;)V", "GetSetKeywords_Ljava_lang_String_Handler")]
			set {
				if (id_setKeywords_Ljava_lang_String_ == IntPtr.Zero)
					id_setKeywords_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setKeywords", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKeywords_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKeywords", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLocalExtras;
#pragma warning disable 0169
		static Delegate GetGetLocalExtrasHandler ()
		{
			if (cb_getLocalExtras == null)
				cb_getLocalExtras = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalExtras);
			return cb_getLocalExtras;
		}

		static IntPtr n_GetLocalExtras (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.LocalExtras);
		}
#pragma warning restore 0169

		static Delegate cb_setLocalExtras_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetLocalExtras_Ljava_util_Map_Handler ()
		{
			if (cb_setLocalExtras_Ljava_util_Map_ == null)
				cb_setLocalExtras_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocalExtras_Ljava_util_Map_);
			return cb_setLocalExtras_Ljava_util_Map_;
		}

		static void n_SetLocalExtras_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocalExtras = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocalExtras;
		static IntPtr id_setLocalExtras_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> LocalExtras {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getLocalExtras' and count(parameter)=0]"
			[Register ("getLocalExtras", "()Ljava/util/Map;", "GetGetLocalExtrasHandler")]
			get {
				if (id_getLocalExtras == IntPtr.Zero)
					id_getLocalExtras = JNIEnv.GetMethodID (class_ref, "getLocalExtras", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocalExtras), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocalExtras", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setLocalExtras' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
			[Register ("setLocalExtras", "(Ljava/util/Map;)V", "GetSetLocalExtras_Ljava_util_Map_Handler")]
			set {
				if (id_setLocalExtras_Ljava_util_Map_ == IntPtr.Zero)
					id_setLocalExtras_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setLocalExtras", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocalExtras_Ljava_util_Map_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocalExtras", "(Ljava/util/Map;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocation);
			return cb_getLocation;
		}

		static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Location);
		}
#pragma warning restore 0169

		static Delegate cb_setLocation_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetSetLocation_Landroid_location_Location_Handler ()
		{
			if (cb_setLocation_Landroid_location_Location_ == null)
				cb_setLocation_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocation_Landroid_location_Location_);
			return cb_setLocation_Landroid_location_Location_;
		}

		static void n_SetLocation_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Location = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		static IntPtr id_setLocation_Landroid_location_Location_;
		public virtual unsafe global::Android.Locations.Location Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Landroid/location/Location;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Landroid/location/Location;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocation", "()Landroid/location/Location;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
			[Register ("setLocation", "(Landroid/location/Location;)V", "GetSetLocation_Landroid_location_Location_Handler")]
			set {
				if (id_setLocation_Landroid_location_Location_ == IntPtr.Zero)
					id_setLocation_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "setLocation", "(Landroid/location/Location;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocation_Landroid_location_Location_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocation", "(Landroid/location/Location;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getResponseString;
#pragma warning disable 0169
		static Delegate GetGetResponseStringHandler ()
		{
			if (cb_getResponseString == null)
				cb_getResponseString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseString);
			return cb_getResponseString;
		}

		static IntPtr n_GetResponseString (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResponseString);
		}
#pragma warning restore 0169

		static IntPtr id_getResponseString;
		[Obsolete (@"deprecated")]
		public virtual unsafe string ResponseString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getResponseString' and count(parameter)=0]"
			[Register ("getResponseString", "()Ljava/lang/String;", "GetGetResponseStringHandler")]
			get {
				if (id_getResponseString == IntPtr.Zero)
					id_getResponseString = JNIEnv.GetMethodID (class_ref, "getResponseString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTesting;
#pragma warning disable 0169
		static Delegate GetGetTestingHandler ()
		{
			if (cb_getTesting == null)
				cb_getTesting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetTesting);
			return cb_getTesting;
		}

		static bool n_GetTesting (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Testing;
		}
#pragma warning restore 0169

		static Delegate cb_setTesting_Z;
#pragma warning disable 0169
		static Delegate GetSetTesting_ZHandler ()
		{
			if (cb_setTesting_Z == null)
				cb_setTesting_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTesting_Z);
			return cb_setTesting_Z;
		}

		static void n_SetTesting_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Testing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTesting;
		static IntPtr id_setTesting_Z;
		public virtual unsafe bool Testing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='getTesting' and count(parameter)=0]"
			[Register ("getTesting", "()Z", "GetGetTestingHandler")]
			get {
				if (id_getTesting == IntPtr.Zero)
					id_getTesting = JNIEnv.GetMethodID (class_ref, "getTesting", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getTesting);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTesting", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setTesting' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTesting", "(Z)V", "GetSetTesting_ZHandler")]
			set {
				if (id_setTesting_Z == IntPtr.Zero)
					id_setTesting_Z = JNIEnv.GetMethodID (class_ref, "setTesting", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTesting_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTesting", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_adClicked;
#pragma warning disable 0169
		static Delegate GetAdClickedHandler ()
		{
			if (cb_adClicked == null)
				cb_adClicked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AdClicked);
			return cb_adClicked;
		}

		static void n_AdClicked (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdClicked ();
		}
#pragma warning restore 0169

		static IntPtr id_adClicked;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='adClicked' and count(parameter)=0]"
		[Register ("adClicked", "()V", "GetAdClickedHandler")]
		protected virtual unsafe void AdClicked ()
		{
			if (id_adClicked == IntPtr.Zero)
				id_adClicked = JNIEnv.GetMethodID (class_ref, "adClicked", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_adClicked);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "adClicked", "()V"));
			} finally {
			}
		}

		static Delegate cb_adClosed;
#pragma warning disable 0169
		static Delegate GetAdClosedHandler ()
		{
			if (cb_adClosed == null)
				cb_adClosed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AdClosed);
			return cb_adClosed;
		}

		static void n_AdClosed (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdClosed ();
		}
#pragma warning restore 0169

		static IntPtr id_adClosed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='adClosed' and count(parameter)=0]"
		[Register ("adClosed", "()V", "GetAdClosedHandler")]
		protected virtual unsafe void AdClosed ()
		{
			if (id_adClosed == IntPtr.Zero)
				id_adClosed = JNIEnv.GetMethodID (class_ref, "adClosed", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_adClosed);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "adClosed", "()V"));
			} finally {
			}
		}

		static Delegate cb_adFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
#pragma warning disable 0169
		static Delegate GetAdFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler ()
		{
			if (cb_adFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == null)
				cb_adFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AdFailed_Lcom_mopub_mobileads_MoPubErrorCode_);
			return cb_adFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
		}

		static void n_AdFailed_Lcom_mopub_mobileads_MoPubErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::com.mopub.mobileads.MoPubErrorCode p0 = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AdFailed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_adFailed_Lcom_mopub_mobileads_MoPubErrorCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='adFailed' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubErrorCode']]"
		[Register ("adFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetAdFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler")]
		protected virtual unsafe void AdFailed (global::com.mopub.mobileads.MoPubErrorCode p0)
		{
			if (id_adFailed_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
				id_adFailed_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "adFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_adFailed_Lcom_mopub_mobileads_MoPubErrorCode_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "adFailed", "(Lcom/mopub/mobileads/MoPubErrorCode;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_adLoaded;
#pragma warning disable 0169
		static Delegate GetAdLoadedHandler ()
		{
			if (cb_adLoaded == null)
				cb_adLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AdLoaded);
			return cb_adLoaded;
		}

		static void n_AdLoaded (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdLoaded ();
		}
#pragma warning restore 0169

		static IntPtr id_adLoaded;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='adLoaded' and count(parameter)=0]"
		[Register ("adLoaded", "()V", "GetAdLoadedHandler")]
		protected virtual unsafe void AdLoaded ()
		{
			if (id_adLoaded == IntPtr.Zero)
				id_adLoaded = JNIEnv.GetMethodID (class_ref, "adLoaded", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_adLoaded);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "adLoaded", "()V"));
			} finally {
			}
		}

		static Delegate cb_adPresentedOverlay;
#pragma warning disable 0169
		static Delegate GetAdPresentedOverlayHandler ()
		{
			if (cb_adPresentedOverlay == null)
				cb_adPresentedOverlay = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AdPresentedOverlay);
			return cb_adPresentedOverlay;
		}

		static void n_AdPresentedOverlay (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdPresentedOverlay ();
		}
#pragma warning restore 0169

		static IntPtr id_adPresentedOverlay;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='adPresentedOverlay' and count(parameter)=0]"
		[Register ("adPresentedOverlay", "()V", "GetAdPresentedOverlayHandler")]
		protected virtual unsafe void AdPresentedOverlay ()
		{
			if (id_adPresentedOverlay == IntPtr.Zero)
				id_adPresentedOverlay = JNIEnv.GetMethodID (class_ref, "adPresentedOverlay", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_adPresentedOverlay);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "adPresentedOverlay", "()V"));
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
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='destroy' and count(parameter)=0]"
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

		static Delegate cb_forceRefresh;
#pragma warning disable 0169
		static Delegate GetForceRefreshHandler ()
		{
			if (cb_forceRefresh == null)
				cb_forceRefresh = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ForceRefresh);
			return cb_forceRefresh;
		}

		static void n_ForceRefresh (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ForceRefresh ();
		}
#pragma warning restore 0169

		static IntPtr id_forceRefresh;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='forceRefresh' and count(parameter)=0]"
		[Register ("forceRefresh", "()V", "GetForceRefreshHandler")]
		public virtual unsafe void ForceRefresh ()
		{
			if (id_forceRefresh == IntPtr.Zero)
				id_forceRefresh = JNIEnv.GetMethodID (class_ref, "forceRefresh", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_forceRefresh);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "forceRefresh", "()V"));
			} finally {
			}
		}

		static Delegate cb_loadAd;
#pragma warning disable 0169
		static Delegate GetLoadAdHandler ()
		{
			if (cb_loadAd == null)
				cb_loadAd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LoadAd);
			return cb_loadAd;
		}

		static void n_LoadAd (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadAd ();
		}
#pragma warning restore 0169

		static IntPtr id_loadAd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='loadAd' and count(parameter)=0]"
		[Register ("loadAd", "()V", "GetLoadAdHandler")]
		public virtual unsafe void LoadAd ()
		{
			if (id_loadAd == IntPtr.Zero)
				id_loadAd = JNIEnv.GetMethodID (class_ref, "loadAd", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadAd);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadAd", "()V"));
			} finally {
			}
		}

		static Delegate cb_loadCustomEvent_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetLoadCustomEvent_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_loadCustomEvent_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_loadCustomEvent_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadCustomEvent_Ljava_lang_String_Ljava_util_Map_);
			return cb_loadCustomEvent_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_LoadCustomEvent_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LoadCustomEvent (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_loadCustomEvent_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='loadCustomEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("loadCustomEvent", "(Ljava/lang/String;Ljava/util/Map;)V", "GetLoadCustomEvent_Ljava_lang_String_Ljava_util_Map_Handler")]
		protected virtual unsafe void LoadCustomEvent (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_loadCustomEvent_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_loadCustomEvent_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "loadCustomEvent", "(Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadCustomEvent_Ljava_lang_String_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadCustomEvent", "(Ljava/lang/String;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_loadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_;
#pragma warning disable 0169
		static Delegate GetLoadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_Handler ()
		{
			if (cb_loadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_ == null)
				cb_loadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_);
			return cb_loadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_;
		}

		static void n_LoadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::com.mopub.mobileads.MoPubErrorCode p0 = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadFailUrl (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='loadFailUrl' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.MoPubErrorCode']]"
		[Register ("loadFailUrl", "(Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetLoadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_Handler")]
		protected virtual unsafe void LoadFailUrl (global::com.mopub.mobileads.MoPubErrorCode p0)
		{
			if (id_loadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
				id_loadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "loadFailUrl", "(Lcom/mopub/mobileads/MoPubErrorCode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadFailUrl_Lcom_mopub_mobileads_MoPubErrorCode_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadFailUrl", "(Lcom/mopub/mobileads/MoPubErrorCode;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_nativeAdLoaded;
#pragma warning disable 0169
		static Delegate GetNativeAdLoadedHandler ()
		{
			if (cb_nativeAdLoaded == null)
				cb_nativeAdLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NativeAdLoaded);
			return cb_nativeAdLoaded;
		}

		static void n_NativeAdLoaded (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NativeAdLoaded ();
		}
#pragma warning restore 0169

		static IntPtr id_nativeAdLoaded;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='nativeAdLoaded' and count(parameter)=0]"
		[Register ("nativeAdLoaded", "()V", "GetNativeAdLoadedHandler")]
		protected virtual unsafe void NativeAdLoaded ()
		{
			if (id_nativeAdLoaded == IntPtr.Zero)
				id_nativeAdLoaded = JNIEnv.GetMethodID (class_ref, "nativeAdLoaded", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_nativeAdLoaded);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nativeAdLoaded", "()V"));
			} finally {
			}
		}

		static Delegate cb_registerClick;
#pragma warning disable 0169
		static Delegate GetRegisterClickHandler ()
		{
			if (cb_registerClick == null)
				cb_registerClick = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RegisterClick);
			return cb_registerClick;
		}

		static void n_RegisterClick (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegisterClick ();
		}
#pragma warning restore 0169

		static IntPtr id_registerClick;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='registerClick' and count(parameter)=0]"
		[Register ("registerClick", "()V", "GetRegisterClickHandler")]
		protected virtual unsafe void RegisterClick ()
		{
			if (id_registerClick == IntPtr.Zero)
				id_registerClick = JNIEnv.GetMethodID (class_ref, "registerClick", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerClick);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerClick", "()V"));
			} finally {
			}
		}

		static Delegate cb_setAdContentView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetAdContentView_Landroid_view_View_Handler ()
		{
			if (cb_setAdContentView_Landroid_view_View_ == null)
				cb_setAdContentView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdContentView_Landroid_view_View_);
			return cb_setAdContentView_Landroid_view_View_;
		}

		static void n_SetAdContentView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAdContentView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAdContentView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setAdContentView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setAdContentView", "(Landroid/view/View;)V", "GetSetAdContentView_Landroid_view_View_Handler")]
		public virtual unsafe void SetAdContentView (global::Android.Views.View p0)
		{
			if (id_setAdContentView_Landroid_view_View_ == IntPtr.Zero)
				id_setAdContentView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setAdContentView", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdContentView_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdContentView", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetTimeout_IHandler ()
		{
			if (cb_setTimeout_I == null)
				cb_setTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTimeout_I);
			return cb_setTimeout_I;
		}

		static void n_SetTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeout (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTimeout_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTimeout", "(I)V", "GetSetTimeout_IHandler")]
		public virtual unsafe void SetTimeout (int p0)
		{
			if (id_setTimeout_I == IntPtr.Zero)
				id_setTimeout_I = JNIEnv.GetMethodID (class_ref, "setTimeout", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimeout_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeout", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_trackNativeImpression;
#pragma warning disable 0169
		static Delegate GetTrackNativeImpressionHandler ()
		{
			if (cb_trackNativeImpression == null)
				cb_trackNativeImpression = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TrackNativeImpression);
			return cb_trackNativeImpression;
		}

		static void n_TrackNativeImpression (IntPtr jnienv, IntPtr native__this)
		{
			global::com.mopub.mobileads.MoPubView __this = global::Java.Lang.Object.GetObject<global::com.mopub.mobileads.MoPubView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrackNativeImpression ();
		}
#pragma warning restore 0169

		static IntPtr id_trackNativeImpression;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/class[@name='MoPubView']/method[@name='trackNativeImpression' and count(parameter)=0]"
		[Register ("trackNativeImpression", "()V", "GetTrackNativeImpressionHandler")]
		protected virtual unsafe void TrackNativeImpression ()
		{
			if (id_trackNativeImpression == IntPtr.Zero)
				id_trackNativeImpression = JNIEnv.GetMethodID (class_ref, "trackNativeImpression", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trackNativeImpression);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "trackNativeImpression", "()V"));
			} finally {
			}
		}

#region "Event implementation for com.mopub.mobileads.MoPubView.IBannerAdListener"
		public event EventHandler<global::com.mopub.mobileads.MoPubView.BannerClickedEventArgs> BannerClicked {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::com.mopub.mobileads.MoPubView.IBannerAdListener, global::com.mopub.mobileads.MoPubView.IBannerAdListenerImplementor>(
						ref weak_implementor___SetBannerAdListener,
						__CreateIBannerAdListenerImplementor,
						__v => BannerAdListener = __v,
						__h => __h.OnBannerClickedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::com.mopub.mobileads.MoPubView.IBannerAdListener, global::com.mopub.mobileads.MoPubView.IBannerAdListenerImplementor>(
						ref weak_implementor___SetBannerAdListener,
						global::com.mopub.mobileads.MoPubView.IBannerAdListenerImplementor.__IsEmpty,
						__v => BannerAdListener = null,
						__h => __h.OnBannerClickedHandler -= value);
			}
		}

		public event EventHandler<global::com.mopub.mobileads.MoPubView.BannerCollapsedEventArgs> BannerCollapsed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::com.mopub.mobileads.MoPubView.IBannerAdListener, global::com.mopub.mobileads.MoPubView.IBannerAdListenerImplementor>(
						ref weak_implementor___SetBannerAdListener,
						__CreateIBannerAdListenerImplementor,
						__v => BannerAdListener = __v,
						__h => __h.OnBannerCollapsedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::com.mopub.mobileads.MoPubView.IBannerAdListener, global::com.mopub.mobileads.MoPubView.IBannerAdListenerImplementor>(
						ref weak_implementor___SetBannerAdListener,
						global::com.mopub.mobileads.MoPubView.IBannerAdListenerImplementor.__IsEmpty,
						__v => BannerAdListener = null,
						__h => __h.OnBannerCollapsedHandler -= value);
			}
		}

		public event EventHandler<global::com.mopub.mobileads.MoPubView.BannerExpandedEventArgs> BannerExpanded {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::com.mopub.mobileads.MoPubView.IBannerAdListener, global::com.mopub.mobileads.MoPubView.IBannerAdListenerImplementor>(
						ref weak_implementor___SetBannerAdListener,
						__CreateIBannerAdListenerImplementor,
						__v => BannerAdListener = __v,
						__h => __h.OnBannerExpandedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::com.mopub.mobileads.MoPubView.IBannerAdListener, global::com.mopub.mobileads.MoPubView.IBannerAdListenerImplementor>(
						ref weak_implementor___SetBannerAdListener,
						global::com.mopub.mobileads.MoPubView.IBannerAdListenerImplementor.__IsEmpty,
						__v => BannerAdListener = null,
						__h => __h.OnBannerExpandedHandler -= value);
			}
		}

		public event EventHandler<global::com.mopub.mobileads.MoPubView.BannerFailedEventArgs> BannerFailed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::com.mopub.mobileads.MoPubView.IBannerAdListener, global::com.mopub.mobileads.MoPubView.IBannerAdListenerImplementor>(
						ref weak_implementor___SetBannerAdListener,
						__CreateIBannerAdListenerImplementor,
						__v => BannerAdListener = __v,
						__h => __h.OnBannerFailedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::com.mopub.mobileads.MoPubView.IBannerAdListener, global::com.mopub.mobileads.MoPubView.IBannerAdListenerImplementor>(
						ref weak_implementor___SetBannerAdListener,
						global::com.mopub.mobileads.MoPubView.IBannerAdListenerImplementor.__IsEmpty,
						__v => BannerAdListener = null,
						__h => __h.OnBannerFailedHandler -= value);
			}
		}

		public event EventHandler<global::com.mopub.mobileads.MoPubView.BannerLoadedEventArgs> BannerLoaded {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::com.mopub.mobileads.MoPubView.IBannerAdListener, global::com.mopub.mobileads.MoPubView.IBannerAdListenerImplementor>(
						ref weak_implementor___SetBannerAdListener,
						__CreateIBannerAdListenerImplementor,
						__v => BannerAdListener = __v,
						__h => __h.OnBannerLoadedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::com.mopub.mobileads.MoPubView.IBannerAdListener, global::com.mopub.mobileads.MoPubView.IBannerAdListenerImplementor>(
						ref weak_implementor___SetBannerAdListener,
						global::com.mopub.mobileads.MoPubView.IBannerAdListenerImplementor.__IsEmpty,
						__v => BannerAdListener = null,
						__h => __h.OnBannerLoadedHandler -= value);
			}
		}

		WeakReference weak_implementor___SetBannerAdListener;

		global::com.mopub.mobileads.MoPubView.IBannerAdListenerImplementor __CreateIBannerAdListenerImplementor ()
		{
			return new global::com.mopub.mobileads.MoPubView.IBannerAdListenerImplementor (this);
		}
#endregion
	}
}
