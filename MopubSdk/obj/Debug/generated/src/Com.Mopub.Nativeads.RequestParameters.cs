using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='RequestParameters']"
	[global::Android.Runtime.Register ("com/mopub/nativeads/RequestParameters", DoNotGenerateAcw=true)]
	public partial class RequestParameters : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='RequestParameters.Builder']"
		[global::Android.Runtime.Register ("com/mopub/nativeads/RequestParameters$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/nativeads/RequestParameters$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='RequestParameters.Builder']/constructor[@name='RequestParameters.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='RequestParameters.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/mopub/nativeads/RequestParameters;", "")]
			public unsafe global::Com.Mopub.Nativeads.RequestParameters Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/mopub/nativeads/RequestParameters;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.RequestParameters> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_desiredAssets_Ljava_util_EnumSet_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='RequestParameters.Builder']/method[@name='desiredAssets' and count(parameter)=1 and parameter[1][@type='java.util.EnumSet&lt;com.mopub.nativeads.RequestParameters.NativeAdAsset&gt;']]"
			[Register ("desiredAssets", "(Ljava/util/EnumSet;)Lcom/mopub/nativeads/RequestParameters$Builder;", "")]
			public unsafe global::Com.Mopub.Nativeads.RequestParameters.Builder DesiredAssets (global::Java.Util.EnumSet p0)
			{
				if (id_desiredAssets_Ljava_util_EnumSet_ == IntPtr.Zero)
					id_desiredAssets_Ljava_util_EnumSet_ = JNIEnv.GetMethodID (class_ref, "desiredAssets", "(Ljava/util/EnumSet;)Lcom/mopub/nativeads/RequestParameters$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Mopub.Nativeads.RequestParameters.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.RequestParameters.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_desiredAssets_Ljava_util_EnumSet_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_keywords_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='RequestParameters.Builder']/method[@name='keywords' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("keywords", "(Ljava/lang/String;)Lcom/mopub/nativeads/RequestParameters$Builder;", "")]
			public unsafe global::Com.Mopub.Nativeads.RequestParameters.Builder Keywords (string p0)
			{
				if (id_keywords_Ljava_lang_String_ == IntPtr.Zero)
					id_keywords_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "keywords", "(Ljava/lang/String;)Lcom/mopub/nativeads/RequestParameters$Builder;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Nativeads.RequestParameters.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.RequestParameters.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_keywords_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_location_Landroid_location_Location_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='RequestParameters.Builder']/method[@name='location' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
			[Register ("location", "(Landroid/location/Location;)Lcom/mopub/nativeads/RequestParameters$Builder;", "")]
			public unsafe global::Com.Mopub.Nativeads.RequestParameters.Builder Location (global::Android.Locations.Location p0)
			{
				if (id_location_Landroid_location_Location_ == IntPtr.Zero)
					id_location_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "location", "(Landroid/location/Location;)Lcom/mopub/nativeads/RequestParameters$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Com.Mopub.Nativeads.RequestParameters.Builder __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.RequestParameters.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_location_Landroid_location_Location_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='RequestParameters.NativeAdAsset']"
		[global::Android.Runtime.Register ("com/mopub/nativeads/RequestParameters$NativeAdAsset", DoNotGenerateAcw=true)]
		public sealed partial class NativeAdAsset : global::Java.Lang.Enum {


			static IntPtr CALL_TO_ACTION_TEXT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='RequestParameters.NativeAdAsset']/field[@name='CALL_TO_ACTION_TEXT']"
			[Register ("CALL_TO_ACTION_TEXT")]
			public static global::Com.Mopub.Nativeads.RequestParameters.NativeAdAsset CallToActionText {
				get {
					if (CALL_TO_ACTION_TEXT_jfieldId == IntPtr.Zero)
						CALL_TO_ACTION_TEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CALL_TO_ACTION_TEXT", "Lcom/mopub/nativeads/RequestParameters$NativeAdAsset;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CALL_TO_ACTION_TEXT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.RequestParameters.NativeAdAsset> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ICON_IMAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='RequestParameters.NativeAdAsset']/field[@name='ICON_IMAGE']"
			[Register ("ICON_IMAGE")]
			public static global::Com.Mopub.Nativeads.RequestParameters.NativeAdAsset IconImage {
				get {
					if (ICON_IMAGE_jfieldId == IntPtr.Zero)
						ICON_IMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ICON_IMAGE", "Lcom/mopub/nativeads/RequestParameters$NativeAdAsset;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ICON_IMAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.RequestParameters.NativeAdAsset> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MAIN_IMAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='RequestParameters.NativeAdAsset']/field[@name='MAIN_IMAGE']"
			[Register ("MAIN_IMAGE")]
			public static global::Com.Mopub.Nativeads.RequestParameters.NativeAdAsset MainImage {
				get {
					if (MAIN_IMAGE_jfieldId == IntPtr.Zero)
						MAIN_IMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAIN_IMAGE", "Lcom/mopub/nativeads/RequestParameters$NativeAdAsset;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAIN_IMAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.RequestParameters.NativeAdAsset> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STAR_RATING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='RequestParameters.NativeAdAsset']/field[@name='STAR_RATING']"
			[Register ("STAR_RATING")]
			public static global::Com.Mopub.Nativeads.RequestParameters.NativeAdAsset StarRating {
				get {
					if (STAR_RATING_jfieldId == IntPtr.Zero)
						STAR_RATING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STAR_RATING", "Lcom/mopub/nativeads/RequestParameters$NativeAdAsset;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STAR_RATING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.RequestParameters.NativeAdAsset> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TEXT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='RequestParameters.NativeAdAsset']/field[@name='TEXT']"
			[Register ("TEXT")]
			public static global::Com.Mopub.Nativeads.RequestParameters.NativeAdAsset Text {
				get {
					if (TEXT_jfieldId == IntPtr.Zero)
						TEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT", "Lcom/mopub/nativeads/RequestParameters$NativeAdAsset;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.RequestParameters.NativeAdAsset> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TITLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='RequestParameters.NativeAdAsset']/field[@name='TITLE']"
			[Register ("TITLE")]
			public static global::Com.Mopub.Nativeads.RequestParameters.NativeAdAsset Title {
				get {
					if (TITLE_jfieldId == IntPtr.Zero)
						TITLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TITLE", "Lcom/mopub/nativeads/RequestParameters$NativeAdAsset;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TITLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.RequestParameters.NativeAdAsset> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/nativeads/RequestParameters$NativeAdAsset", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NativeAdAsset); }
			}

			internal NativeAdAsset (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='RequestParameters.NativeAdAsset']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/nativeads/RequestParameters$NativeAdAsset;", "")]
			public static unsafe global::Com.Mopub.Nativeads.RequestParameters.NativeAdAsset ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/nativeads/RequestParameters$NativeAdAsset;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Nativeads.RequestParameters.NativeAdAsset __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.RequestParameters.NativeAdAsset> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='RequestParameters.NativeAdAsset']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/nativeads/RequestParameters$NativeAdAsset;", "")]
			public static unsafe global::Com.Mopub.Nativeads.RequestParameters.NativeAdAsset[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/nativeads/RequestParameters$NativeAdAsset;");
				try {
					return (global::Com.Mopub.Nativeads.RequestParameters.NativeAdAsset[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Nativeads.RequestParameters.NativeAdAsset));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/nativeads/RequestParameters", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestParameters); }
		}

		protected RequestParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDesiredAssets;
		public unsafe string DesiredAssets {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='RequestParameters']/method[@name='getDesiredAssets' and count(parameter)=0]"
			[Register ("getDesiredAssets", "()Ljava/lang/String;", "GetGetDesiredAssetsHandler")]
			get {
				if (id_getDesiredAssets == IntPtr.Zero)
					id_getDesiredAssets = JNIEnv.GetMethodID (class_ref, "getDesiredAssets", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDesiredAssets), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getKeywords;
		public unsafe string Keywords {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='RequestParameters']/method[@name='getKeywords' and count(parameter)=0]"
			[Register ("getKeywords", "()Ljava/lang/String;", "GetGetKeywordsHandler")]
			get {
				if (id_getKeywords == IntPtr.Zero)
					id_getKeywords = JNIEnv.GetMethodID (class_ref, "getKeywords", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKeywords), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getLocation;
		public unsafe global::Android.Locations.Location Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='RequestParameters']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Landroid/location/Location;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Landroid/location/Location;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
