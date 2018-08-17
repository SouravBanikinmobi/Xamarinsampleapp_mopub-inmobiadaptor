using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='ClickInterface']"
	[Register ("com/mopub/nativeads/ClickInterface", "", "Com.Mopub.Nativeads.IClickInterfaceInvoker")]
	public partial interface IClickInterface : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='ClickInterface']/method[@name='handleClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("handleClick", "(Landroid/view/View;)V", "GetHandleClick_Landroid_view_View_Handler:Com.Mopub.Nativeads.IClickInterfaceInvoker, MopubSdk")]
		void HandleClick (global::Android.Views.View p0);

	}

	[global::Android.Runtime.Register ("com/mopub/nativeads/ClickInterface", DoNotGenerateAcw=true)]
	internal class IClickInterfaceInvoker : global::Java.Lang.Object, IClickInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/nativeads/ClickInterface");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IClickInterfaceInvoker); }
		}

		IntPtr class_ref;

		public static IClickInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IClickInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mopub.nativeads.ClickInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IClickInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_handleClick_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetHandleClick_Landroid_view_View_Handler ()
		{
			if (cb_handleClick_Landroid_view_View_ == null)
				cb_handleClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleClick_Landroid_view_View_);
			return cb_handleClick_Landroid_view_View_;
		}

		static void n_HandleClick_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.IClickInterface __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IClickInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleClick (p0);
		}
#pragma warning restore 0169

		IntPtr id_handleClick_Landroid_view_View_;
		public unsafe void HandleClick (global::Android.Views.View p0)
		{
			if (id_handleClick_Landroid_view_View_ == IntPtr.Zero)
				id_handleClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "handleClick", "(Landroid/view/View;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleClick_Landroid_view_View_, __args);
		}

	}

}
