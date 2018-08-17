using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='AdapterHelper']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/mopub/nativeads/AdapterHelper", DoNotGenerateAcw=true)]
	public sealed partial class AdapterHelper : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/nativeads/AdapterHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdapterHelper); }
		}

		internal AdapterHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='AdapterHelper']/constructor[@name='AdapterHelper' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;II)V", "")]
		public unsafe AdapterHelper (global::Android.Content.Context p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (AdapterHelper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;II)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_II == IntPtr.Zero)
					id_ctor_Landroid_content_Context_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_II, __args);
			} finally {
			}
		}

		static IntPtr id_getAdView_Landroid_view_View_Landroid_view_ViewGroup_Lcom_mopub_nativeads_NativeAd_Lcom_mopub_nativeads_ViewBinder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='AdapterHelper']/method[@name='getAdView' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.ViewGroup'] and parameter[3][@type='com.mopub.nativeads.NativeAd'] and parameter[4][@type='com.mopub.nativeads.ViewBinder']]"
		[Obsolete (@"deprecated")]
		[Register ("getAdView", "(Landroid/view/View;Landroid/view/ViewGroup;Lcom/mopub/nativeads/NativeAd;Lcom/mopub/nativeads/ViewBinder;)Landroid/view/View;", "")]
		public unsafe global::Android.Views.View GetAdView (global::Android.Views.View p0, global::Android.Views.ViewGroup p1, global::Com.Mopub.Nativeads.NativeAd p2, global::Com.Mopub.Nativeads.ViewBinder p3)
		{
			if (id_getAdView_Landroid_view_View_Landroid_view_ViewGroup_Lcom_mopub_nativeads_NativeAd_Lcom_mopub_nativeads_ViewBinder_ == IntPtr.Zero)
				id_getAdView_Landroid_view_View_Landroid_view_ViewGroup_Lcom_mopub_nativeads_NativeAd_Lcom_mopub_nativeads_ViewBinder_ = JNIEnv.GetMethodID (class_ref, "getAdView", "(Landroid/view/View;Landroid/view/ViewGroup;Lcom/mopub/nativeads/NativeAd;Lcom/mopub/nativeads/ViewBinder;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Android.Views.View __ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdView_Landroid_view_View_Landroid_view_ViewGroup_Lcom_mopub_nativeads_NativeAd_Lcom_mopub_nativeads_ViewBinder_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isAdPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='AdapterHelper']/method[@name='isAdPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("isAdPosition", "(I)Z", "")]
		public unsafe bool IsAdPosition (int p0)
		{
			if (id_isAdPosition_I == IntPtr.Zero)
				id_isAdPosition_I = JNIEnv.GetMethodID (class_ref, "isAdPosition", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAdPosition_I, __args);
			} finally {
			}
		}

		static IntPtr id_shiftedCount_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='AdapterHelper']/method[@name='shiftedCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("shiftedCount", "(I)I", "")]
		public unsafe int ShiftedCount (int p0)
		{
			if (id_shiftedCount_I == IntPtr.Zero)
				id_shiftedCount_I = JNIEnv.GetMethodID (class_ref, "shiftedCount", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_shiftedCount_I, __args);
			} finally {
			}
		}

		static IntPtr id_shiftedPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='AdapterHelper']/method[@name='shiftedPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("shiftedPosition", "(I)I", "")]
		public unsafe int ShiftedPosition (int p0)
		{
			if (id_shiftedPosition_I == IntPtr.Zero)
				id_shiftedPosition_I = JNIEnv.GetMethodID (class_ref, "shiftedPosition", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_shiftedPosition_I, __args);
			} finally {
			}
		}

	}
}
