using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeImageHelper']"
	[global::Android.Runtime.Register ("com/mopub/nativeads/NativeImageHelper", DoNotGenerateAcw=true)]
	public partial class NativeImageHelper : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='NativeImageHelper.ImageListener']"
		[Register ("com/mopub/nativeads/NativeImageHelper$ImageListener", "", "Com.Mopub.Nativeads.NativeImageHelper/IImageListenerInvoker")]
		public partial interface IImageListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='NativeImageHelper.ImageListener']/method[@name='onImagesCached' and count(parameter)=0]"
			[Register ("onImagesCached", "()V", "GetOnImagesCachedHandler:Com.Mopub.Nativeads.NativeImageHelper/IImageListenerInvoker, MopubSdk")]
			void OnImagesCached ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/interface[@name='NativeImageHelper.ImageListener']/method[@name='onImagesFailedToCache' and count(parameter)=1 and parameter[1][@type='com.mopub.nativeads.NativeErrorCode']]"
			[Register ("onImagesFailedToCache", "(Lcom/mopub/nativeads/NativeErrorCode;)V", "GetOnImagesFailedToCache_Lcom_mopub_nativeads_NativeErrorCode_Handler:Com.Mopub.Nativeads.NativeImageHelper/IImageListenerInvoker, MopubSdk")]
			void OnImagesFailedToCache (global::Com.Mopub.Nativeads.NativeErrorCode p0);

		}

		[global::Android.Runtime.Register ("com/mopub/nativeads/NativeImageHelper$ImageListener", DoNotGenerateAcw=true)]
		internal class IImageListenerInvoker : global::Java.Lang.Object, IImageListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/nativeads/NativeImageHelper$ImageListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IImageListenerInvoker); }
			}

			IntPtr class_ref;

			public static IImageListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IImageListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.nativeads.NativeImageHelper.ImageListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IImageListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onImagesCached;
#pragma warning disable 0169
			static Delegate GetOnImagesCachedHandler ()
			{
				if (cb_onImagesCached == null)
					cb_onImagesCached = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnImagesCached);
				return cb_onImagesCached;
			}

			static void n_OnImagesCached (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Mopub.Nativeads.NativeImageHelper.IImageListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeImageHelper.IImageListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnImagesCached ();
			}
#pragma warning restore 0169

			IntPtr id_onImagesCached;
			public unsafe void OnImagesCached ()
			{
				if (id_onImagesCached == IntPtr.Zero)
					id_onImagesCached = JNIEnv.GetMethodID (class_ref, "onImagesCached", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onImagesCached);
			}

			static Delegate cb_onImagesFailedToCache_Lcom_mopub_nativeads_NativeErrorCode_;
#pragma warning disable 0169
			static Delegate GetOnImagesFailedToCache_Lcom_mopub_nativeads_NativeErrorCode_Handler ()
			{
				if (cb_onImagesFailedToCache_Lcom_mopub_nativeads_NativeErrorCode_ == null)
					cb_onImagesFailedToCache_Lcom_mopub_nativeads_NativeErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnImagesFailedToCache_Lcom_mopub_nativeads_NativeErrorCode_);
				return cb_onImagesFailedToCache_Lcom_mopub_nativeads_NativeErrorCode_;
			}

			static void n_OnImagesFailedToCache_Lcom_mopub_nativeads_NativeErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Nativeads.NativeImageHelper.IImageListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeImageHelper.IImageListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Nativeads.NativeErrorCode p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.NativeErrorCode> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnImagesFailedToCache (p0);
			}
#pragma warning restore 0169

			IntPtr id_onImagesFailedToCache_Lcom_mopub_nativeads_NativeErrorCode_;
			public unsafe void OnImagesFailedToCache (global::Com.Mopub.Nativeads.NativeErrorCode p0)
			{
				if (id_onImagesFailedToCache_Lcom_mopub_nativeads_NativeErrorCode_ == IntPtr.Zero)
					id_onImagesFailedToCache_Lcom_mopub_nativeads_NativeErrorCode_ = JNIEnv.GetMethodID (class_ref, "onImagesFailedToCache", "(Lcom/mopub/nativeads/NativeErrorCode;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onImagesFailedToCache_Lcom_mopub_nativeads_NativeErrorCode_, __args);
			}

		}

		// event args for com.mopub.nativeads.NativeImageHelper.ImageListener.onImagesFailedToCache
		public partial class ImagesFailedToCacheEventArgs : global::System.EventArgs {

			public ImagesFailedToCacheEventArgs (global::Com.Mopub.Nativeads.NativeErrorCode p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Nativeads.NativeErrorCode p0;
			public global::Com.Mopub.Nativeads.NativeErrorCode P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/nativeads/NativeImageHelper_ImageListenerImplementor")]
		internal sealed partial class IImageListenerImplementor : global::Java.Lang.Object, IImageListener {

			object sender;

			public IImageListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/nativeads/NativeImageHelper_ImageListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnImagesCachedHandler;
#pragma warning restore 0649

			public void OnImagesCached ()
			{
				var __h = OnImagesCachedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<ImagesFailedToCacheEventArgs> OnImagesFailedToCacheHandler;
#pragma warning restore 0649

			public void OnImagesFailedToCache (global::Com.Mopub.Nativeads.NativeErrorCode p0)
			{
				var __h = OnImagesFailedToCacheHandler;
				if (__h != null)
					__h (sender, new ImagesFailedToCacheEventArgs (p0));
			}

			internal static bool __IsEmpty (IImageListenerImplementor value)
			{
				return value.OnImagesCachedHandler == null && value.OnImagesFailedToCacheHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/nativeads/NativeImageHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeImageHelper); }
		}

		protected NativeImageHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeImageHelper']/constructor[@name='NativeImageHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NativeImageHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (NativeImageHelper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_loadImageView_Ljava_lang_String_Landroid_widget_ImageView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeImageHelper']/method[@name='loadImageView' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.widget.ImageView']]"
		[Register ("loadImageView", "(Ljava/lang/String;Landroid/widget/ImageView;)V", "")]
		public static unsafe void LoadImageView (string p0, global::Android.Widget.ImageView p1)
		{
			if (id_loadImageView_Ljava_lang_String_Landroid_widget_ImageView_ == IntPtr.Zero)
				id_loadImageView_Ljava_lang_String_Landroid_widget_ImageView_ = JNIEnv.GetStaticMethodID (class_ref, "loadImageView", "(Ljava/lang/String;Landroid/widget/ImageView;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_loadImageView_Ljava_lang_String_Landroid_widget_ImageView_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_preCacheImages_Landroid_content_Context_Ljava_util_List_Lcom_mopub_nativeads_NativeImageHelper_ImageListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='NativeImageHelper']/method[@name='preCacheImages' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[3][@type='com.mopub.nativeads.NativeImageHelper.ImageListener']]"
		[Register ("preCacheImages", "(Landroid/content/Context;Ljava/util/List;Lcom/mopub/nativeads/NativeImageHelper$ImageListener;)V", "")]
		public static unsafe void PreCacheImages (global::Android.Content.Context p0, global::System.Collections.Generic.IList<string> p1, global::Com.Mopub.Nativeads.NativeImageHelper.IImageListener p2)
		{
			if (id_preCacheImages_Landroid_content_Context_Ljava_util_List_Lcom_mopub_nativeads_NativeImageHelper_ImageListener_ == IntPtr.Zero)
				id_preCacheImages_Landroid_content_Context_Ljava_util_List_Lcom_mopub_nativeads_NativeImageHelper_ImageListener_ = JNIEnv.GetStaticMethodID (class_ref, "preCacheImages", "(Landroid/content/Context;Ljava/util/List;Lcom/mopub/nativeads/NativeImageHelper$ImageListener;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_preCacheImages_Landroid_content_Context_Ljava_util_List_Lcom_mopub_nativeads_NativeImageHelper_ImageListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
