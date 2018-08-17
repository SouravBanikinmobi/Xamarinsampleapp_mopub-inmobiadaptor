using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Integralads.Avid.Library.Inmobi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.integralads.avid.library.inmobi']/class[@name='DownloadAvidTask']"
	[global::Android.Runtime.Register ("com/integralads/avid/library/inmobi/DownloadAvidTask", DoNotGenerateAcw=true)]
	public partial class DownloadAvidTask : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.integralads.avid.library.inmobi']/interface[@name='DownloadAvidTask.DownloadAvidTaskListener']"
		[Register ("com/integralads/avid/library/inmobi/DownloadAvidTask$DownloadAvidTaskListener", "", "Com.Integralads.Avid.Library.Inmobi.DownloadAvidTask/IDownloadAvidTaskListenerInvoker")]
		public partial interface IDownloadAvidTaskListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi']/interface[@name='DownloadAvidTask.DownloadAvidTaskListener']/method[@name='failedToLoadAvid' and count(parameter)=0]"
			[Register ("failedToLoadAvid", "()V", "GetFailedToLoadAvidHandler:Com.Integralads.Avid.Library.Inmobi.DownloadAvidTask/IDownloadAvidTaskListenerInvoker, Jars")]
			void FailedToLoadAvid ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi']/interface[@name='DownloadAvidTask.DownloadAvidTaskListener']/method[@name='onLoadAvid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onLoadAvid", "(Ljava/lang/String;)V", "GetOnLoadAvid_Ljava_lang_String_Handler:Com.Integralads.Avid.Library.Inmobi.DownloadAvidTask/IDownloadAvidTaskListenerInvoker, Jars")]
			void OnLoadAvid (string p0);

		}

		[global::Android.Runtime.Register ("com/integralads/avid/library/inmobi/DownloadAvidTask$DownloadAvidTaskListener", DoNotGenerateAcw=true)]
		internal class IDownloadAvidTaskListenerInvoker : global::Java.Lang.Object, IDownloadAvidTaskListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/integralads/avid/library/inmobi/DownloadAvidTask$DownloadAvidTaskListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IDownloadAvidTaskListenerInvoker); }
			}

			IntPtr class_ref;

			public static IDownloadAvidTaskListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDownloadAvidTaskListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.integralads.avid.library.inmobi.DownloadAvidTask.DownloadAvidTaskListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDownloadAvidTaskListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_failedToLoadAvid;
#pragma warning disable 0169
			static Delegate GetFailedToLoadAvidHandler ()
			{
				if (cb_failedToLoadAvid == null)
					cb_failedToLoadAvid = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FailedToLoadAvid);
				return cb_failedToLoadAvid;
			}

			static void n_FailedToLoadAvid (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Integralads.Avid.Library.Inmobi.DownloadAvidTask.IDownloadAvidTaskListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.DownloadAvidTask.IDownloadAvidTaskListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.FailedToLoadAvid ();
			}
#pragma warning restore 0169

			IntPtr id_failedToLoadAvid;
			public unsafe void FailedToLoadAvid ()
			{
				if (id_failedToLoadAvid == IntPtr.Zero)
					id_failedToLoadAvid = JNIEnv.GetMethodID (class_ref, "failedToLoadAvid", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_failedToLoadAvid);
			}

			static Delegate cb_onLoadAvid_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnLoadAvid_Ljava_lang_String_Handler ()
			{
				if (cb_onLoadAvid_Ljava_lang_String_ == null)
					cb_onLoadAvid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLoadAvid_Ljava_lang_String_);
				return cb_onLoadAvid_Ljava_lang_String_;
			}

			static void n_OnLoadAvid_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Integralads.Avid.Library.Inmobi.DownloadAvidTask.IDownloadAvidTaskListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.DownloadAvidTask.IDownloadAvidTaskListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLoadAvid (p0);
			}
#pragma warning restore 0169

			IntPtr id_onLoadAvid_Ljava_lang_String_;
			public unsafe void OnLoadAvid (string p0)
			{
				if (id_onLoadAvid_Ljava_lang_String_ == IntPtr.Zero)
					id_onLoadAvid_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onLoadAvid", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoadAvid_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		// event args for com.integralads.avid.library.inmobi.DownloadAvidTask.DownloadAvidTaskListener.onLoadAvid
		public partial class LoadAvidEventArgs : global::System.EventArgs {

			public LoadAvidEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/integralads/avid/library/inmobi/DownloadAvidTask_DownloadAvidTaskListenerImplementor")]
		internal sealed partial class IDownloadAvidTaskListenerImplementor : global::Java.Lang.Object, IDownloadAvidTaskListener {

			object sender;

			public IDownloadAvidTaskListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/integralads/avid/library/inmobi/DownloadAvidTask_DownloadAvidTaskListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler FailedToLoadAvidHandler;
#pragma warning restore 0649

			public void FailedToLoadAvid ()
			{
				var __h = FailedToLoadAvidHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<LoadAvidEventArgs> OnLoadAvidHandler;
#pragma warning restore 0649

			public void OnLoadAvid (string p0)
			{
				var __h = OnLoadAvidHandler;
				if (__h != null)
					__h (sender, new LoadAvidEventArgs (p0));
			}

			internal static bool __IsEmpty (IDownloadAvidTaskListenerImplementor value)
			{
				return value.FailedToLoadAvidHandler == null && value.OnLoadAvidHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/integralads/avid/library/inmobi/DownloadAvidTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DownloadAvidTask); }
		}

		protected DownloadAvidTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
