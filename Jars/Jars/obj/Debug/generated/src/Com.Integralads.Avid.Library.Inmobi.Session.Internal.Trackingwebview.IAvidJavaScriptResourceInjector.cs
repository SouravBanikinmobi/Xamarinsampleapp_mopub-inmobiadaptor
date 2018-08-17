using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Integralads.Avid.Library.Inmobi.Session.Internal.Trackingwebview {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal.trackingwebview']/interface[@name='AvidJavaScriptResourceInjector']"
	[Register ("com/integralads/avid/library/inmobi/session/internal/trackingwebview/AvidJavaScriptResourceInjector", "", "Com.Integralads.Avid.Library.Inmobi.Session.Internal.Trackingwebview.IAvidJavaScriptResourceInjectorInvoker")]
	public partial interface IAvidJavaScriptResourceInjector : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.session.internal.trackingwebview']/interface[@name='AvidJavaScriptResourceInjector']/method[@name='injectJavaScriptResource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("injectJavaScriptResource", "(Ljava/lang/String;)V", "GetInjectJavaScriptResource_Ljava_lang_String_Handler:Com.Integralads.Avid.Library.Inmobi.Session.Internal.Trackingwebview.IAvidJavaScriptResourceInjectorInvoker, Jars")]
		void InjectJavaScriptResource (string p0);

	}

	[global::Android.Runtime.Register ("com/integralads/avid/library/inmobi/session/internal/trackingwebview/AvidJavaScriptResourceInjector", DoNotGenerateAcw=true)]
	internal class IAvidJavaScriptResourceInjectorInvoker : global::Java.Lang.Object, IAvidJavaScriptResourceInjector {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/integralads/avid/library/inmobi/session/internal/trackingwebview/AvidJavaScriptResourceInjector");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAvidJavaScriptResourceInjectorInvoker); }
		}

		IntPtr class_ref;

		public static IAvidJavaScriptResourceInjector GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAvidJavaScriptResourceInjector> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.integralads.avid.library.inmobi.session.internal.trackingwebview.AvidJavaScriptResourceInjector"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAvidJavaScriptResourceInjectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_injectJavaScriptResource_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInjectJavaScriptResource_Ljava_lang_String_Handler ()
		{
			if (cb_injectJavaScriptResource_Ljava_lang_String_ == null)
				cb_injectJavaScriptResource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InjectJavaScriptResource_Ljava_lang_String_);
			return cb_injectJavaScriptResource_Ljava_lang_String_;
		}

		static void n_InjectJavaScriptResource_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Trackingwebview.IAvidJavaScriptResourceInjector __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Session.Internal.Trackingwebview.IAvidJavaScriptResourceInjector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InjectJavaScriptResource (p0);
		}
#pragma warning restore 0169

		IntPtr id_injectJavaScriptResource_Ljava_lang_String_;
		public unsafe void InjectJavaScriptResource (string p0)
		{
			if (id_injectJavaScriptResource_Ljava_lang_String_ == IntPtr.Zero)
				id_injectJavaScriptResource_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "injectJavaScriptResource", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_injectJavaScriptResource_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
