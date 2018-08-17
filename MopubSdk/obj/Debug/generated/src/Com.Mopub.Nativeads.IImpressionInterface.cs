using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='ImpressionInterface']"
	[Register ("com/mopub/nativeads/ImpressionInterface", "", "Com.Mopub.Nativeads.IImpressionInterfaceInvoker")]
	public partial interface IImpressionInterface : IJavaObject {

		int ImpressionMinPercentageViewed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='ImpressionInterface']/method[@name='getImpressionMinPercentageViewed' and count(parameter)=0]"
			[Register ("getImpressionMinPercentageViewed", "()I", "GetGetImpressionMinPercentageViewedHandler:Com.Mopub.Nativeads.IImpressionInterfaceInvoker, MopubSdk")] get;
		}

		int ImpressionMinTimeViewed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='ImpressionInterface']/method[@name='getImpressionMinTimeViewed' and count(parameter)=0]"
			[Register ("getImpressionMinTimeViewed", "()I", "GetGetImpressionMinTimeViewedHandler:Com.Mopub.Nativeads.IImpressionInterfaceInvoker, MopubSdk")] get;
		}

		bool IsImpressionRecorded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='ImpressionInterface']/method[@name='isImpressionRecorded' and count(parameter)=0]"
			[Register ("isImpressionRecorded", "()Z", "GetIsImpressionRecordedHandler:Com.Mopub.Nativeads.IImpressionInterfaceInvoker, MopubSdk")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='ImpressionInterface']/method[@name='recordImpression' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("recordImpression", "(Landroid/view/View;)V", "GetRecordImpression_Landroid_view_View_Handler:Com.Mopub.Nativeads.IImpressionInterfaceInvoker, MopubSdk")]
		void RecordImpression (global::Android.Views.View p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='ImpressionInterface']/method[@name='setImpressionRecorded' and count(parameter)=0]"
		[Register ("setImpressionRecorded", "()V", "GetSetImpressionRecordedHandler:Com.Mopub.Nativeads.IImpressionInterfaceInvoker, MopubSdk")]
		void SetImpressionRecorded ();

	}

	[global::Android.Runtime.Register ("com/mopub/nativeads/ImpressionInterface", DoNotGenerateAcw=true)]
	internal class IImpressionInterfaceInvoker : global::Java.Lang.Object, IImpressionInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/nativeads/ImpressionInterface");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IImpressionInterfaceInvoker); }
		}

		IntPtr class_ref;

		public static IImpressionInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IImpressionInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mopub.nativeads.ImpressionInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IImpressionInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getImpressionMinPercentageViewed;
#pragma warning disable 0169
		static Delegate GetGetImpressionMinPercentageViewedHandler ()
		{
			if (cb_getImpressionMinPercentageViewed == null)
				cb_getImpressionMinPercentageViewed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetImpressionMinPercentageViewed);
			return cb_getImpressionMinPercentageViewed;
		}

		static int n_GetImpressionMinPercentageViewed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.IImpressionInterface __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IImpressionInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImpressionMinPercentageViewed;
		}
#pragma warning restore 0169

		IntPtr id_getImpressionMinPercentageViewed;
		public unsafe int ImpressionMinPercentageViewed {
			get {
				if (id_getImpressionMinPercentageViewed == IntPtr.Zero)
					id_getImpressionMinPercentageViewed = JNIEnv.GetMethodID (class_ref, "getImpressionMinPercentageViewed", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getImpressionMinPercentageViewed);
			}
		}

		static Delegate cb_getImpressionMinTimeViewed;
#pragma warning disable 0169
		static Delegate GetGetImpressionMinTimeViewedHandler ()
		{
			if (cb_getImpressionMinTimeViewed == null)
				cb_getImpressionMinTimeViewed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetImpressionMinTimeViewed);
			return cb_getImpressionMinTimeViewed;
		}

		static int n_GetImpressionMinTimeViewed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.IImpressionInterface __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IImpressionInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImpressionMinTimeViewed;
		}
#pragma warning restore 0169

		IntPtr id_getImpressionMinTimeViewed;
		public unsafe int ImpressionMinTimeViewed {
			get {
				if (id_getImpressionMinTimeViewed == IntPtr.Zero)
					id_getImpressionMinTimeViewed = JNIEnv.GetMethodID (class_ref, "getImpressionMinTimeViewed", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getImpressionMinTimeViewed);
			}
		}

		static Delegate cb_isImpressionRecorded;
#pragma warning disable 0169
		static Delegate GetIsImpressionRecordedHandler ()
		{
			if (cb_isImpressionRecorded == null)
				cb_isImpressionRecorded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsImpressionRecorded);
			return cb_isImpressionRecorded;
		}

		static bool n_IsImpressionRecorded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.IImpressionInterface __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IImpressionInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsImpressionRecorded;
		}
#pragma warning restore 0169

		IntPtr id_isImpressionRecorded;
		public unsafe bool IsImpressionRecorded {
			get {
				if (id_isImpressionRecorded == IntPtr.Zero)
					id_isImpressionRecorded = JNIEnv.GetMethodID (class_ref, "isImpressionRecorded", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isImpressionRecorded);
			}
		}

		static Delegate cb_recordImpression_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetRecordImpression_Landroid_view_View_Handler ()
		{
			if (cb_recordImpression_Landroid_view_View_ == null)
				cb_recordImpression_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RecordImpression_Landroid_view_View_);
			return cb_recordImpression_Landroid_view_View_;
		}

		static void n_RecordImpression_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.IImpressionInterface __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IImpressionInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RecordImpression (p0);
		}
#pragma warning restore 0169

		IntPtr id_recordImpression_Landroid_view_View_;
		public unsafe void RecordImpression (global::Android.Views.View p0)
		{
			if (id_recordImpression_Landroid_view_View_ == IntPtr.Zero)
				id_recordImpression_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "recordImpression", "(Landroid/view/View;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordImpression_Landroid_view_View_, __args);
		}

		static Delegate cb_setImpressionRecorded;
#pragma warning disable 0169
		static Delegate GetSetImpressionRecordedHandler ()
		{
			if (cb_setImpressionRecorded == null)
				cb_setImpressionRecorded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetImpressionRecorded);
			return cb_setImpressionRecorded;
		}

		static void n_SetImpressionRecorded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.IImpressionInterface __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.IImpressionInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetImpressionRecorded ();
		}
#pragma warning restore 0169

		IntPtr id_setImpressionRecorded;
		public unsafe void SetImpressionRecorded ()
		{
			if (id_setImpressionRecorded == IntPtr.Zero)
				id_setImpressionRecorded = JNIEnv.GetMethodID (class_ref, "setImpressionRecorded", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImpressionRecorded);
		}

	}

}
