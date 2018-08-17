using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']"
	[global::Android.Runtime.Register ("com/mopub/nativeads/MoPubAdAdapter", DoNotGenerateAcw=true)]
	public partial class MoPubAdAdapter : global::Android.Widget.BaseAdapter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/nativeads/MoPubAdAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubAdAdapter); }
		}

		protected MoPubAdAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_Landroid_widget_Adapter_Lcom_mopub_nativeads_MoPubNativeAdPositioning_MoPubClientPositioning_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/constructor[@name='MoPubAdAdapter' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.widget.Adapter'] and parameter[3][@type='com.mopub.nativeads.MoPubNativeAdPositioning.MoPubClientPositioning']]"
		[Register (".ctor", "(Landroid/app/Activity;Landroid/widget/Adapter;Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubClientPositioning;)V", "")]
		public unsafe MoPubAdAdapter (global::Android.App.Activity p0, global::Android.Widget.IAdapter p1, global::Com.Mopub.Nativeads.MoPubNativeAdPositioning.MoPubClientPositioning p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (MoPubAdAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/app/Activity;Landroid/widget/Adapter;Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubClientPositioning;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;Landroid/widget/Adapter;Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubClientPositioning;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_Landroid_widget_Adapter_Lcom_mopub_nativeads_MoPubNativeAdPositioning_MoPubClientPositioning_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_Landroid_widget_Adapter_Lcom_mopub_nativeads_MoPubNativeAdPositioning_MoPubClientPositioning_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Landroid/widget/Adapter;Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubClientPositioning;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_Landroid_widget_Adapter_Lcom_mopub_nativeads_MoPubNativeAdPositioning_MoPubClientPositioning_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_Landroid_widget_Adapter_Lcom_mopub_nativeads_MoPubNativeAdPositioning_MoPubClientPositioning_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_app_Activity_Landroid_widget_Adapter_Lcom_mopub_nativeads_MoPubNativeAdPositioning_MoPubServerPositioning_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/constructor[@name='MoPubAdAdapter' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.widget.Adapter'] and parameter[3][@type='com.mopub.nativeads.MoPubNativeAdPositioning.MoPubServerPositioning']]"
		[Register (".ctor", "(Landroid/app/Activity;Landroid/widget/Adapter;Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubServerPositioning;)V", "")]
		public unsafe MoPubAdAdapter (global::Android.App.Activity p0, global::Android.Widget.IAdapter p1, global::Com.Mopub.Nativeads.MoPubNativeAdPositioning.MoPubServerPositioning p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (MoPubAdAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/app/Activity;Landroid/widget/Adapter;Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubServerPositioning;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;Landroid/widget/Adapter;Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubServerPositioning;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_Landroid_widget_Adapter_Lcom_mopub_nativeads_MoPubNativeAdPositioning_MoPubServerPositioning_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_Landroid_widget_Adapter_Lcom_mopub_nativeads_MoPubNativeAdPositioning_MoPubServerPositioning_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Landroid/widget/Adapter;Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubServerPositioning;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_Landroid_widget_Adapter_Lcom_mopub_nativeads_MoPubNativeAdPositioning_MoPubServerPositioning_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_Landroid_widget_Adapter_Lcom_mopub_nativeads_MoPubNativeAdPositioning_MoPubServerPositioning_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_app_Activity_Landroid_widget_Adapter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/constructor[@name='MoPubAdAdapter' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.widget.Adapter']]"
		[Register (".ctor", "(Landroid/app/Activity;Landroid/widget/Adapter;)V", "")]
		public unsafe MoPubAdAdapter (global::Android.App.Activity p0, global::Android.Widget.IAdapter p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MoPubAdAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/app/Activity;Landroid/widget/Adapter;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;Landroid/widget/Adapter;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_Landroid_widget_Adapter_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_Landroid_widget_Adapter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Landroid/widget/Adapter;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_Landroid_widget_Adapter_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_Landroid_widget_Adapter_, __args);
			} finally {
			}
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.MoPubAdAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubAdAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		public override unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_clearAds;
#pragma warning disable 0169
		static Delegate GetClearAdsHandler ()
		{
			if (cb_clearAds == null)
				cb_clearAds = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearAds);
			return cb_clearAds;
		}

		static void n_ClearAds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Nativeads.MoPubAdAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubAdAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAds ();
		}
#pragma warning restore 0169

		static IntPtr id_clearAds;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='clearAds' and count(parameter)=0]"
		[Register ("clearAds", "()V", "GetClearAdsHandler")]
		public virtual unsafe void ClearAds ()
		{
			if (id_clearAds == IntPtr.Zero)
				id_clearAds = JNIEnv.GetMethodID (class_ref, "clearAds", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearAds);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearAds", "()V"));
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
			global::Com.Mopub.Nativeads.MoPubAdAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubAdAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='destroy' and count(parameter)=0]"
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

		static Delegate cb_getAdjustedPosition_I;
#pragma warning disable 0169
		static Delegate GetGetAdjustedPosition_IHandler ()
		{
			if (cb_getAdjustedPosition_I == null)
				cb_getAdjustedPosition_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetAdjustedPosition_I);
			return cb_getAdjustedPosition_I;
		}

		static int n_GetAdjustedPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.MoPubAdAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubAdAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetAdjustedPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getAdjustedPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='getAdjustedPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAdjustedPosition", "(I)I", "GetGetAdjustedPosition_IHandler")]
		public virtual unsafe int GetAdjustedPosition (int p0)
		{
			if (id_getAdjustedPosition_I == IntPtr.Zero)
				id_getAdjustedPosition_I = JNIEnv.GetMethodID (class_ref, "getAdjustedPosition", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdjustedPosition_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdjustedPosition", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getItem_I;
#pragma warning disable 0169
		static Delegate GetGetItem_IHandler ()
		{
			if (cb_getItem_I == null)
				cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
			return cb_getItem_I;
		}

		static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.MoPubAdAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubAdAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Ljava/lang/Object;", "GetGetItem_IHandler")]
		public override unsafe global::Java.Lang.Object GetItem (int p0)
		{
			if (id_getItem_I == IntPtr.Zero)
				id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItem_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItem", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getItemId_I;
#pragma warning disable 0169
		static Delegate GetGetItemId_IHandler ()
		{
			if (cb_getItemId_I == null)
				cb_getItemId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetItemId_I);
			return cb_getItemId_I;
		}

		static long n_GetItemId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.MoPubAdAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubAdAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetItemId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getItemId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='getItemId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItemId", "(I)J", "GetGetItemId_IHandler")]
		public override unsafe long GetItemId (int p0)
		{
			if (id_getItemId_I == IntPtr.Zero)
				id_getItemId_I = JNIEnv.GetMethodID (class_ref, "getItemId", "(I)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getItemId_I, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemId", "(I)J"), __args);
			} finally {
			}
		}

		static Delegate cb_getOriginalPosition_I;
#pragma warning disable 0169
		static Delegate GetGetOriginalPosition_IHandler ()
		{
			if (cb_getOriginalPosition_I == null)
				cb_getOriginalPosition_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetOriginalPosition_I);
			return cb_getOriginalPosition_I;
		}

		static int n_GetOriginalPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.MoPubAdAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubAdAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetOriginalPosition (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getOriginalPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='getOriginalPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getOriginalPosition", "(I)I", "GetGetOriginalPosition_IHandler")]
		public virtual unsafe int GetOriginalPosition (int p0)
		{
			if (id_getOriginalPosition_I == IntPtr.Zero)
				id_getOriginalPosition_I = JNIEnv.GetMethodID (class_ref, "getOriginalPosition", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOriginalPosition_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOriginalPosition", "(I)I"), __args);
			} finally {
			}
		}

		static Delegate cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
				cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_);
			return cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mopub.Nativeads.MoPubAdAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubAdAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetView (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
		public override unsafe global::Android.Views.View GetView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2)
		{
			if (id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Android.Views.View __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView_ILandroid_view_View_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_insertItem_I;
#pragma warning disable 0169
		static Delegate GetInsertItem_IHandler ()
		{
			if (cb_insertItem_I == null)
				cb_insertItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_InsertItem_I);
			return cb_insertItem_I;
		}

		static void n_InsertItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.MoPubAdAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubAdAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InsertItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_insertItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='insertItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("insertItem", "(I)V", "GetInsertItem_IHandler")]
		public virtual unsafe void InsertItem (int p0)
		{
			if (id_insertItem_I == IntPtr.Zero)
				id_insertItem_I = JNIEnv.GetMethodID (class_ref, "insertItem", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_insertItem_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insertItem", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_isAd_I;
#pragma warning disable 0169
		static Delegate GetIsAd_IHandler ()
		{
			if (cb_isAd_I == null)
				cb_isAd_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsAd_I);
			return cb_isAd_I;
		}

		static bool n_IsAd_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.MoPubAdAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubAdAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAd (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isAd_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='isAd' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isAd", "(I)Z", "GetIsAd_IHandler")]
		public virtual unsafe bool IsAd (int p0)
		{
			if (id_isAd_I == IntPtr.Zero)
				id_isAd_I = JNIEnv.GetMethodID (class_ref, "isAd", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAd_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAd", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_loadAds_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadAds_Ljava_lang_String_Handler ()
		{
			if (cb_loadAds_Ljava_lang_String_ == null)
				cb_loadAds_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadAds_Ljava_lang_String_);
			return cb_loadAds_Ljava_lang_String_;
		}

		static void n_LoadAds_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.MoPubAdAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubAdAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadAds (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadAds_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='loadAds' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadAds", "(Ljava/lang/String;)V", "GetLoadAds_Ljava_lang_String_Handler")]
		public virtual unsafe void LoadAds (string p0)
		{
			if (id_loadAds_Ljava_lang_String_ == IntPtr.Zero)
				id_loadAds_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadAds", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadAds_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadAds", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_;
#pragma warning disable 0169
		static Delegate GetLoadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_Handler ()
		{
			if (cb_loadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_ == null)
				cb_loadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_);
			return cb_loadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_;
		}

		static void n_LoadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Nativeads.MoPubAdAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubAdAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.RequestParameters p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.RequestParameters> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.LoadAds (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_loadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='loadAds' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.nativeads.RequestParameters']]"
		[Register ("loadAds", "(Ljava/lang/String;Lcom/mopub/nativeads/RequestParameters;)V", "GetLoadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_Handler")]
		public virtual unsafe void LoadAds (string p0, global::Com.Mopub.Nativeads.RequestParameters p1)
		{
			if (id_loadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_ == IntPtr.Zero)
				id_loadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_ = JNIEnv.GetMethodID (class_ref, "loadAds", "(Ljava/lang/String;Lcom/mopub/nativeads/RequestParameters;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadAds_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadAds", "(Ljava/lang/String;Lcom/mopub/nativeads/RequestParameters;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_refreshAds_Landroid_widget_ListView_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRefreshAds_Landroid_widget_ListView_Ljava_lang_String_Handler ()
		{
			if (cb_refreshAds_Landroid_widget_ListView_Ljava_lang_String_ == null)
				cb_refreshAds_Landroid_widget_ListView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RefreshAds_Landroid_widget_ListView_Ljava_lang_String_);
			return cb_refreshAds_Landroid_widget_ListView_Ljava_lang_String_;
		}

		static void n_RefreshAds_Landroid_widget_ListView_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Nativeads.MoPubAdAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubAdAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ListView> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RefreshAds (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_refreshAds_Landroid_widget_ListView_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='refreshAds' and count(parameter)=2 and parameter[1][@type='android.widget.ListView'] and parameter[2][@type='java.lang.String']]"
		[Register ("refreshAds", "(Landroid/widget/ListView;Ljava/lang/String;)V", "GetRefreshAds_Landroid_widget_ListView_Ljava_lang_String_Handler")]
		public virtual unsafe void RefreshAds (global::Android.Widget.ListView p0, string p1)
		{
			if (id_refreshAds_Landroid_widget_ListView_Ljava_lang_String_ == IntPtr.Zero)
				id_refreshAds_Landroid_widget_ListView_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "refreshAds", "(Landroid/widget/ListView;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_refreshAds_Landroid_widget_ListView_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "refreshAds", "(Landroid/widget/ListView;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_refreshAds_Landroid_widget_ListView_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_;
#pragma warning disable 0169
		static Delegate GetRefreshAds_Landroid_widget_ListView_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_Handler ()
		{
			if (cb_refreshAds_Landroid_widget_ListView_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_ == null)
				cb_refreshAds_Landroid_widget_ListView_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RefreshAds_Landroid_widget_ListView_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_);
			return cb_refreshAds_Landroid_widget_ListView_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_;
		}

		static void n_RefreshAds_Landroid_widget_ListView_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Mopub.Nativeads.MoPubAdAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubAdAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ListView> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Nativeads.RequestParameters p2 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.RequestParameters> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.RefreshAds (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_refreshAds_Landroid_widget_ListView_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='refreshAds' and count(parameter)=3 and parameter[1][@type='android.widget.ListView'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.mopub.nativeads.RequestParameters']]"
		[Register ("refreshAds", "(Landroid/widget/ListView;Ljava/lang/String;Lcom/mopub/nativeads/RequestParameters;)V", "GetRefreshAds_Landroid_widget_ListView_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_Handler")]
		public virtual unsafe void RefreshAds (global::Android.Widget.ListView p0, string p1, global::Com.Mopub.Nativeads.RequestParameters p2)
		{
			if (id_refreshAds_Landroid_widget_ListView_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_ == IntPtr.Zero)
				id_refreshAds_Landroid_widget_ListView_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_ = JNIEnv.GetMethodID (class_ref, "refreshAds", "(Landroid/widget/ListView;Ljava/lang/String;Lcom/mopub/nativeads/RequestParameters;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_refreshAds_Landroid_widget_ListView_Ljava_lang_String_Lcom_mopub_nativeads_RequestParameters_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "refreshAds", "(Landroid/widget/ListView;Ljava/lang/String;Lcom/mopub/nativeads/RequestParameters;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='registerAdRenderer' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.MoPubAdRenderer']]"
		[Register ("registerAdRenderer", "(Lcom/mopub/nativeads/MoPubAdRenderer;)V", "")]
		public unsafe void RegisterAdRenderer (global::Com.Mopub.Nativeads.IMoPubAdRenderer p0)
		{
			if (id_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_ == IntPtr.Zero)
				id_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_ = JNIEnv.GetMethodID (class_ref, "registerAdRenderer", "(Lcom/mopub/nativeads/MoPubAdRenderer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerAdRenderer_Lcom_mopub_nativeads_MoPubAdRenderer_, __args);
			} finally {
			}
		}

		static Delegate cb_removeItem_I;
#pragma warning disable 0169
		static Delegate GetRemoveItem_IHandler ()
		{
			if (cb_removeItem_I == null)
				cb_removeItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveItem_I);
			return cb_removeItem_I;
		}

		static void n_RemoveItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Nativeads.MoPubAdAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubAdAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='removeItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeItem", "(I)V", "GetRemoveItem_IHandler")]
		public virtual unsafe void RemoveItem (int p0)
		{
			if (id_removeItem_I == IntPtr.Zero)
				id_removeItem_I = JNIEnv.GetMethodID (class_ref, "removeItem", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeItem_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeItem", "(I)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setAdLoadedListener_Lcom_mopub_nativeads_MoPubNativeAdLoadedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='setAdLoadedListener' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.MoPubNativeAdLoadedListener']]"
		[Register ("setAdLoadedListener", "(Lcom/mopub/nativeads/MoPubNativeAdLoadedListener;)V", "")]
		public unsafe void SetAdLoadedListener (global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListener p0)
		{
			if (id_setAdLoadedListener_Lcom_mopub_nativeads_MoPubNativeAdLoadedListener_ == IntPtr.Zero)
				id_setAdLoadedListener_Lcom_mopub_nativeads_MoPubNativeAdLoadedListener_ = JNIEnv.GetMethodID (class_ref, "setAdLoadedListener", "(Lcom/mopub/nativeads/MoPubNativeAdLoadedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdLoadedListener_Lcom_mopub_nativeads_MoPubNativeAdLoadedListener_, __args);
			} finally {
			}
		}

		static Delegate cb_setOnClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemClickListener_Handler ()
		{
			if (cb_setOnClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemClickListener_ == null)
				cb_setOnClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemClickListener_);
			return cb_setOnClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemClickListener_;
		}

		static void n_SetOnClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Nativeads.MoPubAdAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubAdAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ListView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AdapterView.IOnItemClickListener p1 = (global::Android.Widget.AdapterView.IOnItemClickListener)global::Java.Lang.Object.GetObject<global::Android.Widget.AdapterView.IOnItemClickListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetOnClickListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setOnClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='setOnClickListener' and count(parameter)=2 and parameter[1][@type='android.widget.ListView'] and parameter[2][@type='android.widget.AdapterView.OnItemClickListener']]"
		[Register ("setOnClickListener", "(Landroid/widget/ListView;Landroid/widget/AdapterView$OnItemClickListener;)V", "GetSetOnClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemClickListener_Handler")]
		public virtual unsafe void SetOnClickListener (global::Android.Widget.ListView p0, global::Android.Widget.AdapterView.IOnItemClickListener p1)
		{
			if (id_setOnClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemClickListener_ == IntPtr.Zero)
				id_setOnClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnClickListener", "(Landroid/widget/ListView;Landroid/widget/AdapterView$OnItemClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnClickListener", "(Landroid/widget/ListView;Landroid/widget/AdapterView$OnItemClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnItemLongClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemLongClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnItemLongClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemLongClickListener_Handler ()
		{
			if (cb_setOnItemLongClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemLongClickListener_ == null)
				cb_setOnItemLongClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemLongClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnItemLongClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemLongClickListener_);
			return cb_setOnItemLongClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemLongClickListener_;
		}

		static void n_SetOnItemLongClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemLongClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Nativeads.MoPubAdAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubAdAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ListView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AdapterView.IOnItemLongClickListener p1 = (global::Android.Widget.AdapterView.IOnItemLongClickListener)global::Java.Lang.Object.GetObject<global::Android.Widget.AdapterView.IOnItemLongClickListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetOnItemLongClickListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setOnItemLongClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemLongClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='setOnItemLongClickListener' and count(parameter)=2 and parameter[1][@type='android.widget.ListView'] and parameter[2][@type='android.widget.AdapterView.OnItemLongClickListener']]"
		[Register ("setOnItemLongClickListener", "(Landroid/widget/ListView;Landroid/widget/AdapterView$OnItemLongClickListener;)V", "GetSetOnItemLongClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemLongClickListener_Handler")]
		public virtual unsafe void SetOnItemLongClickListener (global::Android.Widget.ListView p0, global::Android.Widget.AdapterView.IOnItemLongClickListener p1)
		{
			if (id_setOnItemLongClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemLongClickListener_ == IntPtr.Zero)
				id_setOnItemLongClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemLongClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnItemLongClickListener", "(Landroid/widget/ListView;Landroid/widget/AdapterView$OnItemLongClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnItemLongClickListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemLongClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnItemLongClickListener", "(Landroid/widget/ListView;Landroid/widget/AdapterView$OnItemLongClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnItemSelectedListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemSelectedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnItemSelectedListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemSelectedListener_Handler ()
		{
			if (cb_setOnItemSelectedListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemSelectedListener_ == null)
				cb_setOnItemSelectedListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemSelectedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnItemSelectedListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemSelectedListener_);
			return cb_setOnItemSelectedListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemSelectedListener_;
		}

		static void n_SetOnItemSelectedListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemSelectedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Nativeads.MoPubAdAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubAdAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ListView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AdapterView.IOnItemSelectedListener p1 = (global::Android.Widget.AdapterView.IOnItemSelectedListener)global::Java.Lang.Object.GetObject<global::Android.Widget.AdapterView.IOnItemSelectedListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetOnItemSelectedListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setOnItemSelectedListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemSelectedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='setOnItemSelectedListener' and count(parameter)=2 and parameter[1][@type='android.widget.ListView'] and parameter[2][@type='android.widget.AdapterView.OnItemSelectedListener']]"
		[Register ("setOnItemSelectedListener", "(Landroid/widget/ListView;Landroid/widget/AdapterView$OnItemSelectedListener;)V", "GetSetOnItemSelectedListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemSelectedListener_Handler")]
		public virtual unsafe void SetOnItemSelectedListener (global::Android.Widget.ListView p0, global::Android.Widget.AdapterView.IOnItemSelectedListener p1)
		{
			if (id_setOnItemSelectedListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemSelectedListener_ == IntPtr.Zero)
				id_setOnItemSelectedListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemSelectedListener_ = JNIEnv.GetMethodID (class_ref, "setOnItemSelectedListener", "(Landroid/widget/ListView;Landroid/widget/AdapterView$OnItemSelectedListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnItemSelectedListener_Landroid_widget_ListView_Landroid_widget_AdapterView_OnItemSelectedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnItemSelectedListener", "(Landroid/widget/ListView;Landroid/widget/AdapterView$OnItemSelectedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSelection_Landroid_widget_ListView_I;
#pragma warning disable 0169
		static Delegate GetSetSelection_Landroid_widget_ListView_IHandler ()
		{
			if (cb_setSelection_Landroid_widget_ListView_I == null)
				cb_setSelection_Landroid_widget_ListView_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetSelection_Landroid_widget_ListView_I);
			return cb_setSelection_Landroid_widget_ListView_I;
		}

		static void n_SetSelection_Landroid_widget_ListView_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Mopub.Nativeads.MoPubAdAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubAdAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ListView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSelection (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setSelection_Landroid_widget_ListView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='setSelection' and count(parameter)=2 and parameter[1][@type='android.widget.ListView'] and parameter[2][@type='int']]"
		[Register ("setSelection", "(Landroid/widget/ListView;I)V", "GetSetSelection_Landroid_widget_ListView_IHandler")]
		public virtual unsafe void SetSelection (global::Android.Widget.ListView p0, int p1)
		{
			if (id_setSelection_Landroid_widget_ListView_I == IntPtr.Zero)
				id_setSelection_Landroid_widget_ListView_I = JNIEnv.GetMethodID (class_ref, "setSelection", "(Landroid/widget/ListView;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelection_Landroid_widget_ListView_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelection", "(Landroid/widget/ListView;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_smoothScrollToPosition_Landroid_widget_ListView_I;
#pragma warning disable 0169
		static Delegate GetSmoothScrollToPosition_Landroid_widget_ListView_IHandler ()
		{
			if (cb_smoothScrollToPosition_Landroid_widget_ListView_I == null)
				cb_smoothScrollToPosition_Landroid_widget_ListView_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SmoothScrollToPosition_Landroid_widget_ListView_I);
			return cb_smoothScrollToPosition_Landroid_widget_ListView_I;
		}

		static void n_SmoothScrollToPosition_Landroid_widget_ListView_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Mopub.Nativeads.MoPubAdAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubAdAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ListView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ListView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SmoothScrollToPosition (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_smoothScrollToPosition_Landroid_widget_ListView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubAdAdapter']/method[@name='smoothScrollToPosition' and count(parameter)=2 and parameter[1][@type='android.widget.ListView'] and parameter[2][@type='int']]"
		[Register ("smoothScrollToPosition", "(Landroid/widget/ListView;I)V", "GetSmoothScrollToPosition_Landroid_widget_ListView_IHandler")]
		public virtual unsafe void SmoothScrollToPosition (global::Android.Widget.ListView p0, int p1)
		{
			if (id_smoothScrollToPosition_Landroid_widget_ListView_I == IntPtr.Zero)
				id_smoothScrollToPosition_Landroid_widget_ListView_I = JNIEnv.GetMethodID (class_ref, "smoothScrollToPosition", "(Landroid/widget/ListView;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_smoothScrollToPosition_Landroid_widget_ListView_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "smoothScrollToPosition", "(Landroid/widget/ListView;I)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Mopub.Nativeads.IMoPubNativeAdLoadedListener"
		public event EventHandler<global::Com.Mopub.Nativeads.AdLoadedEventArgs> AdLoaded {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListener, global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerImplementor>(
						ref weak_implementor_SetAdLoadedListener,
						__CreateIMoPubNativeAdLoadedListenerImplementor,
						SetAdLoadedListener,
						__h => __h.OnAdLoadedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListener, global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerImplementor>(
						ref weak_implementor_SetAdLoadedListener,
						global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerImplementor.__IsEmpty,
						__v => SetAdLoadedListener (null),
						__h => __h.OnAdLoadedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Mopub.Nativeads.AdRemovedEventArgs> AdRemoved {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListener, global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerImplementor>(
						ref weak_implementor_SetAdLoadedListener,
						__CreateIMoPubNativeAdLoadedListenerImplementor,
						SetAdLoadedListener,
						__h => __h.OnAdRemovedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListener, global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerImplementor>(
						ref weak_implementor_SetAdLoadedListener,
						global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerImplementor.__IsEmpty,
						__v => SetAdLoadedListener (null),
						__h => __h.OnAdRemovedHandler -= value);
			}
		}

		WeakReference weak_implementor_SetAdLoadedListener;

		global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerImplementor __CreateIMoPubNativeAdLoadedListenerImplementor ()
		{
			return new global::Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerImplementor (this);
		}
#endregion
	}
}
