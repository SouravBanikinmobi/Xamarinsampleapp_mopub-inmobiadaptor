using System;
using System.Collections.Generic;
using Android.Runtime;

namespace MoPub.Volley {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley']/class[@name='NetworkDispatcher']"
	[global::Android.Runtime.Register ("com/mopub/volley/NetworkDispatcher", DoNotGenerateAcw=true)]
	public partial class NetworkDispatcher : global::Java.Lang.Thread {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/NetworkDispatcher", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkDispatcher); }
		}

		protected NetworkDispatcher (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_concurrent_BlockingQueue_Lcom_mopub_volley_Network_Lcom_mopub_volley_Cache_Lcom_mopub_volley_ResponseDelivery_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='NetworkDispatcher']/constructor[@name='NetworkDispatcher' and count(parameter)=4 and parameter[1][@type='java.util.concurrent.BlockingQueue&lt;com.mopub.volley.Request&lt;?&gt;&gt;'] and parameter[2][@type='com.mopub.volley.Network'] and parameter[3][@type='com.mopub.volley.Cache'] and parameter[4][@type='com.mopub.volley.ResponseDelivery']]"
		[Register (".ctor", "(Ljava/util/concurrent/BlockingQueue;Lcom/mopub/volley/Network;Lcom/mopub/volley/Cache;Lcom/mopub/volley/ResponseDelivery;)V", "")]
		public unsafe NetworkDispatcher (global::Java.Util.Concurrent.IBlockingQueue p0, global::MoPub.Volley.INetwork p1, global::MoPub.Volley.ICache p2, global::MoPub.Volley.IResponseDelivery p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (NetworkDispatcher)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/concurrent/BlockingQueue;Lcom/mopub/volley/Network;Lcom/mopub/volley/Cache;Lcom/mopub/volley/ResponseDelivery;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/concurrent/BlockingQueue;Lcom/mopub/volley/Network;Lcom/mopub/volley/Cache;Lcom/mopub/volley/ResponseDelivery;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_concurrent_BlockingQueue_Lcom_mopub_volley_Network_Lcom_mopub_volley_Cache_Lcom_mopub_volley_ResponseDelivery_ == IntPtr.Zero)
					id_ctor_Ljava_util_concurrent_BlockingQueue_Lcom_mopub_volley_Network_Lcom_mopub_volley_Cache_Lcom_mopub_volley_ResponseDelivery_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/BlockingQueue;Lcom/mopub/volley/Network;Lcom/mopub/volley/Cache;Lcom/mopub/volley/ResponseDelivery;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_BlockingQueue_Lcom_mopub_volley_Network_Lcom_mopub_volley_Cache_Lcom_mopub_volley_ResponseDelivery_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_concurrent_BlockingQueue_Lcom_mopub_volley_Network_Lcom_mopub_volley_Cache_Lcom_mopub_volley_ResponseDelivery_, __args);
			} finally {
			}
		}

		static Delegate cb_quit;
#pragma warning disable 0169
		static Delegate GetQuitHandler ()
		{
			if (cb_quit == null)
				cb_quit = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Quit);
			return cb_quit;
		}

		static void n_Quit (IntPtr jnienv, IntPtr native__this)
		{
			global::MoPub.Volley.NetworkDispatcher __this = global::Java.Lang.Object.GetObject<global::MoPub.Volley.NetworkDispatcher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Quit ();
		}
#pragma warning restore 0169

		static IntPtr id_quit;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='NetworkDispatcher']/method[@name='quit' and count(parameter)=0]"
		[Register ("quit", "()V", "GetQuitHandler")]
		public virtual unsafe void Quit ()
		{
			if (id_quit == IntPtr.Zero)
				id_quit = JNIEnv.GetMethodID (class_ref, "quit", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_quit);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "quit", "()V"));
			} finally {
			}
		}

	}
}
