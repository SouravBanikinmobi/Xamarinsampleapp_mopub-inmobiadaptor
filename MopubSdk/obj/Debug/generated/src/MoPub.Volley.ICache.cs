using System;
using System.Collections.Generic;
using Android.Runtime;

namespace MoPub.Volley {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley']/class[@name='Cache.Entry']"
	[global::Android.Runtime.Register ("com/mopub/volley/Cache$Entry", DoNotGenerateAcw=true)]
	public partial class CacheEntry : global::Java.Lang.Object {


		static IntPtr data_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='Cache.Entry']/field[@name='data']"
		[Register ("data")]
		public IList<byte> Data {
			get {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, data_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, data_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr etag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='Cache.Entry']/field[@name='etag']"
		[Register ("etag")]
		public string Etag {
			get {
				if (etag_jfieldId == IntPtr.Zero)
					etag_jfieldId = JNIEnv.GetFieldID (class_ref, "etag", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, etag_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (etag_jfieldId == IntPtr.Zero)
					etag_jfieldId = JNIEnv.GetFieldID (class_ref, "etag", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, etag_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr responseHeaders_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='Cache.Entry']/field[@name='responseHeaders']"
		[Register ("responseHeaders")]
		public global::System.Collections.IDictionary ResponseHeaders {
			get {
				if (responseHeaders_jfieldId == IntPtr.Zero)
					responseHeaders_jfieldId = JNIEnv.GetFieldID (class_ref, "responseHeaders", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, responseHeaders_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (responseHeaders_jfieldId == IntPtr.Zero)
					responseHeaders_jfieldId = JNIEnv.GetFieldID (class_ref, "responseHeaders", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, responseHeaders_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr serverDate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='Cache.Entry']/field[@name='serverDate']"
		[Register ("serverDate")]
		public long ServerDate {
			get {
				if (serverDate_jfieldId == IntPtr.Zero)
					serverDate_jfieldId = JNIEnv.GetFieldID (class_ref, "serverDate", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, serverDate_jfieldId);
			}
			set {
				if (serverDate_jfieldId == IntPtr.Zero)
					serverDate_jfieldId = JNIEnv.GetFieldID (class_ref, "serverDate", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, serverDate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr softTtl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='Cache.Entry']/field[@name='softTtl']"
		[Register ("softTtl")]
		public long SoftTtl {
			get {
				if (softTtl_jfieldId == IntPtr.Zero)
					softTtl_jfieldId = JNIEnv.GetFieldID (class_ref, "softTtl", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, softTtl_jfieldId);
			}
			set {
				if (softTtl_jfieldId == IntPtr.Zero)
					softTtl_jfieldId = JNIEnv.GetFieldID (class_ref, "softTtl", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, softTtl_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr ttl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='Cache.Entry']/field[@name='ttl']"
		[Register ("ttl")]
		public long Ttl {
			get {
				if (ttl_jfieldId == IntPtr.Zero)
					ttl_jfieldId = JNIEnv.GetFieldID (class_ref, "ttl", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, ttl_jfieldId);
			}
			set {
				if (ttl_jfieldId == IntPtr.Zero)
					ttl_jfieldId = JNIEnv.GetFieldID (class_ref, "ttl", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ttl_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/Cache$Entry", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CacheEntry); }
		}

		protected CacheEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='Cache.Entry']/constructor[@name='Cache.Entry' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CacheEntry ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CacheEntry)) {
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

		static Delegate cb_isExpired;
#pragma warning disable 0169
		static Delegate GetIsExpiredHandler ()
		{
			if (cb_isExpired == null)
				cb_isExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExpired);
			return cb_isExpired;
		}

		static bool n_IsExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::MoPub.Volley.CacheEntry __this = global::Java.Lang.Object.GetObject<global::MoPub.Volley.CacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExpired;
		}
#pragma warning restore 0169

		static IntPtr id_isExpired;
		public virtual unsafe bool IsExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Cache.Entry']/method[@name='isExpired' and count(parameter)=0]"
			[Register ("isExpired", "()Z", "GetIsExpiredHandler")]
			get {
				if (id_isExpired == IntPtr.Zero)
					id_isExpired = JNIEnv.GetMethodID (class_ref, "isExpired", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExpired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isExpired", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_refreshNeeded;
#pragma warning disable 0169
		static Delegate GetRefreshNeededHandler ()
		{
			if (cb_refreshNeeded == null)
				cb_refreshNeeded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_RefreshNeeded);
			return cb_refreshNeeded;
		}

		static bool n_RefreshNeeded (IntPtr jnienv, IntPtr native__this)
		{
			global::MoPub.Volley.CacheEntry __this = global::Java.Lang.Object.GetObject<global::MoPub.Volley.CacheEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RefreshNeeded ();
		}
#pragma warning restore 0169

		static IntPtr id_refreshNeeded;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Cache.Entry']/method[@name='refreshNeeded' and count(parameter)=0]"
		[Register ("refreshNeeded", "()Z", "GetRefreshNeededHandler")]
		public virtual unsafe bool RefreshNeeded ()
		{
			if (id_refreshNeeded == IntPtr.Zero)
				id_refreshNeeded = JNIEnv.GetMethodID (class_ref, "refreshNeeded", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_refreshNeeded);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "refreshNeeded", "()Z"));
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Cache']"
	[Register ("com/mopub/volley/Cache", "", "MoPub.Volley.ICacheInvoker")]
	public partial interface ICache : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Cache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:MoPub.Volley.ICacheInvoker, MopubSdk")]
		void Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Cache']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lcom/mopub/volley/Cache$Entry;", "GetGet_Ljava_lang_String_Handler:MoPub.Volley.ICacheInvoker, MopubSdk")]
		global::MoPub.Volley.CacheEntry Get (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Cache']/method[@name='initialize' and count(parameter)=0]"
		[Register ("initialize", "()V", "GetInitializeHandler:MoPub.Volley.ICacheInvoker, MopubSdk")]
		void Initialize ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Cache']/method[@name='invalidate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("invalidate", "(Ljava/lang/String;Z)V", "GetInvalidate_Ljava_lang_String_ZHandler:MoPub.Volley.ICacheInvoker, MopubSdk")]
		void Invalidate (string p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Cache']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.volley.Cache.Entry']]"
		[Register ("put", "(Ljava/lang/String;Lcom/mopub/volley/Cache$Entry;)V", "GetPut_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_Handler:MoPub.Volley.ICacheInvoker, MopubSdk")]
		void Put (string p0, global::MoPub.Volley.CacheEntry p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Cache']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Handler:MoPub.Volley.ICacheInvoker, MopubSdk")]
		void Remove (string p0);

	}

	[global::Android.Runtime.Register ("com/mopub/volley/Cache", DoNotGenerateAcw=true)]
	internal class ICacheInvoker : global::Java.Lang.Object, ICache {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/volley/Cache");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICacheInvoker); }
		}

		IntPtr class_ref;

		public static ICache GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICache> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mopub.volley.Cache"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::MoPub.Volley.ICache __this = global::Java.Lang.Object.GetObject<global::MoPub.Volley.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MoPub.Volley.ICache __this = global::Java.Lang.Object.GetObject<global::MoPub.Volley.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_;
		public unsafe global::MoPub.Volley.CacheEntry Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Lcom/mopub/volley/Cache$Entry;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::MoPub.Volley.CacheEntry __ret = global::Java.Lang.Object.GetObject<global::MoPub.Volley.CacheEntry> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_initialize;
#pragma warning disable 0169
		static Delegate GetInitializeHandler ()
		{
			if (cb_initialize == null)
				cb_initialize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Initialize);
			return cb_initialize;
		}

		static void n_Initialize (IntPtr jnienv, IntPtr native__this)
		{
			global::MoPub.Volley.ICache __this = global::Java.Lang.Object.GetObject<global::MoPub.Volley.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Initialize ();
		}
#pragma warning restore 0169

		IntPtr id_initialize;
		public unsafe void Initialize ()
		{
			if (id_initialize == IntPtr.Zero)
				id_initialize = JNIEnv.GetMethodID (class_ref, "initialize", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initialize);
		}

		static Delegate cb_invalidate_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetInvalidate_Ljava_lang_String_ZHandler ()
		{
			if (cb_invalidate_Ljava_lang_String_Z == null)
				cb_invalidate_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_Invalidate_Ljava_lang_String_Z);
			return cb_invalidate_Ljava_lang_String_Z;
		}

		static void n_Invalidate_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::MoPub.Volley.ICache __this = global::Java.Lang.Object.GetObject<global::MoPub.Volley.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Invalidate (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_invalidate_Ljava_lang_String_Z;
		public unsafe void Invalidate (string p0, bool p1)
		{
			if (id_invalidate_Ljava_lang_String_Z == IntPtr.Zero)
				id_invalidate_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "invalidate", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_invalidate_Ljava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_put_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_Handler ()
		{
			if (cb_put_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_ == null)
				cb_put_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_);
			return cb_put_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_;
		}

		static void n_Put_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::MoPub.Volley.ICache __this = global::Java.Lang.Object.GetObject<global::MoPub.Volley.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::MoPub.Volley.CacheEntry p1 = global::Java.Lang.Object.GetObject<global::MoPub.Volley.CacheEntry> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_put_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_;
		public unsafe void Put (string p0, global::MoPub.Volley.CacheEntry p1)
		{
			if (id_put_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Lcom/mopub/volley/Cache$Entry;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_lang_String_Lcom_mopub_volley_Cache_Entry_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static void n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MoPub.Volley.ICache __this = global::Java.Lang.Object.GetObject<global::MoPub.Volley.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		IntPtr id_remove_Ljava_lang_String_;
		public unsafe void Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
