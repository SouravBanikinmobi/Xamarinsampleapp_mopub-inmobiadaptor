using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='MoPubNativeAdLoadedListener']"
	[Register ("com/mopub/nativeads/MoPubNativeAdLoadedListener", "", "Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerInvoker")]
	public partial interface IMoPubNativeAdLoadedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='MoPubNativeAdLoadedListener']/method[@name='onAdLoaded' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onAdLoaded", "(I)V", "GetOnAdLoaded_IHandler:Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerInvoker, MopubSdk")]
		void OnAdLoaded (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='MoPubNativeAdLoadedListener']/method[@name='onAdRemoved' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onAdRemoved", "(I)V", "GetOnAdRemoved_IHandler:Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerInvoker, MopubSdk")]
		void OnAdRemoved (int p0);

	}

	[global::Android.Runtime.Register ("com/mopub/nativeads/MoPubNativeAdLoadedListener", DoNotGenerateAcw=true)]
	internal class IMoPubNativeAdLoadedListenerInvoker : global::Java.Lang.Object, IMoPubNativeAdLoadedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/nativeads/MoPubNativeAdLoadedListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMoPubNativeAdLoadedListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMoPubNativeAdLoadedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMoPubNativeAdLoadedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mopub.nativeads.MoPubNativeAdLoadedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMoPubNativeAdLoadedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdLoaded_I;
#pragma warning disable 0169
		static Delegate GetOnAdLoaded_IHandler ()
		{
			if (cb_onAdLoaded_I == null)
				cb_onAdLoaded_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnAdLoaded_I);
			return cb_onAdLoaded_I;
		}

		static void n_OnAdLoaded_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdLoaded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdLoaded_I;
		public unsafe void OnAdLoaded (int p0)
		{
			if (id_onAdLoaded_I == IntPtr.Zero)
				id_onAdLoaded_I = JNIEnv.GetMethodID (class_ref, "onAdLoaded", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdLoaded_I, __args);
		}

		static Delegate cb_onAdRemoved_I;
#pragma warning disable 0169
		static Delegate GetOnAdRemoved_IHandler ()
		{
			if (cb_onAdRemoved_I == null)
				cb_onAdRemoved_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnAdRemoved_I);
			return cb_onAdRemoved_I;
		}

		static void n_OnAdRemoved_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdRemoved (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdRemoved_I;
		public unsafe void OnAdRemoved (int p0)
		{
			if (id_onAdRemoved_I == IntPtr.Zero)
				id_onAdRemoved_I = JNIEnv.GetMethodID (class_ref, "onAdRemoved", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdRemoved_I, __args);
		}

	}

	// event args for com.mopub.nativeads.MoPubNativeAdLoadedListener.onAdLoaded
	public partial class AdLoadedEventArgs : global::System.EventArgs {

		public AdLoadedEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	// event args for com.mopub.nativeads.MoPubNativeAdLoadedListener.onAdRemoved
	public partial class AdRemovedEventArgs : global::System.EventArgs {

		public AdRemovedEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mopub/nativeads/MoPubNativeAdLoadedListenerImplementor")]
	internal sealed partial class IMoPubNativeAdLoadedListenerImplementor : global::Java.Lang.Object, IMoPubNativeAdLoadedListener {

		object sender;

		public IMoPubNativeAdLoadedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/nativeads/MoPubNativeAdLoadedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AdLoadedEventArgs> OnAdLoadedHandler;
#pragma warning restore 0649

		public void OnAdLoaded (int p0)
		{
			var __h = OnAdLoadedHandler;
			if (__h != null)
				__h (sender, new AdLoadedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<AdRemovedEventArgs> OnAdRemovedHandler;
#pragma warning restore 0649

		public void OnAdRemoved (int p0)
		{
			var __h = OnAdRemovedHandler;
			if (__h != null)
				__h (sender, new AdRemovedEventArgs (p0));
		}

		internal static bool __IsEmpty (IMoPubNativeAdLoadedListenerImplementor value)
		{
			return value.OnAdLoadedHandler == null && value.OnAdRemovedHandler == null;
		}
	}

}
