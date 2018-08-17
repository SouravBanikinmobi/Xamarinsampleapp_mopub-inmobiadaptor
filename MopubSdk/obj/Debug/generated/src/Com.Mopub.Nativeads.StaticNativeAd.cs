using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']"
	[global::Android.Runtime.Register ("com/mopub/nativeads/StaticNativeAd", DoNotGenerateAcw=true)]
	public abstract partial class StaticNativeAd : global::Com.Mopub.Nativeads.BaseNativeAd, global::Com.Mopub.Nativeads.IClickInterface, global::Com.Mopub.Nativeads.IImpressionInterface {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/nativeads/StaticNativeAd", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StaticNativeAd); }
		}

		protected StaticNativeAd (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/constructor[@name='StaticNativeAd' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StaticNativeAd ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (StaticNativeAd)) {
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

		static IntPtr id_getCallToAction;
		static IntPtr id_setCallToAction_Ljava_lang_String_;
		public unsafe string CallToAction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='getCallToAction' and count(parameter)=0]"
			[Register ("getCallToAction", "()Ljava/lang/String;", "GetGetCallToActionHandler")]
			get {
				if (id_getCallToAction == IntPtr.Zero)
					id_getCallToAction = JNIEnv.GetMethodID (class_ref, "getCallToAction", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCallToAction), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='setCallToAction' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCallToAction", "(Ljava/lang/String;)V", "GetSetCallToAction_Ljava_lang_String_Handler")]
			set {
				if (id_setCallToAction_Ljava_lang_String_ == IntPtr.Zero)
					id_setCallToAction_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCallToAction", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallToAction_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getClickDestinationUrl;
		static IntPtr id_setClickDestinationUrl_Ljava_lang_String_;
		public unsafe string ClickDestinationUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='getClickDestinationUrl' and count(parameter)=0]"
			[Register ("getClickDestinationUrl", "()Ljava/lang/String;", "GetGetClickDestinationUrlHandler")]
			get {
				if (id_getClickDestinationUrl == IntPtr.Zero)
					id_getClickDestinationUrl = JNIEnv.GetMethodID (class_ref, "getClickDestinationUrl", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClickDestinationUrl), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='setClickDestinationUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClickDestinationUrl", "(Ljava/lang/String;)V", "GetSetClickDestinationUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setClickDestinationUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setClickDestinationUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setClickDestinationUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setClickDestinationUrl_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getExtras;
		public unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Extras {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='getExtras' and count(parameter)=0]"
			[Register ("getExtras", "()Ljava/util/Map;", "GetGetExtrasHandler")]
			get {
				if (id_getExtras == IntPtr.Zero)
					id_getExtras = JNIEnv.GetMethodID (class_ref, "getExtras", "()Ljava/util/Map;");
				try {
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExtras), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getIconImageUrl;
		static IntPtr id_setIconImageUrl_Ljava_lang_String_;
		public unsafe string IconImageUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='getIconImageUrl' and count(parameter)=0]"
			[Register ("getIconImageUrl", "()Ljava/lang/String;", "GetGetIconImageUrlHandler")]
			get {
				if (id_getIconImageUrl == IntPtr.Zero)
					id_getIconImageUrl = JNIEnv.GetMethodID (class_ref, "getIconImageUrl", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIconImageUrl), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='setIconImageUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIconImageUrl", "(Ljava/lang/String;)V", "GetSetIconImageUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setIconImageUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setIconImageUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIconImageUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIconImageUrl_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getImpressionMinPercentageViewed;
		public unsafe int ImpressionMinPercentageViewed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='getImpressionMinPercentageViewed' and count(parameter)=0]"
			[Register ("getImpressionMinPercentageViewed", "()I", "GetGetImpressionMinPercentageViewedHandler")]
			get {
				if (id_getImpressionMinPercentageViewed == IntPtr.Zero)
					id_getImpressionMinPercentageViewed = JNIEnv.GetMethodID (class_ref, "getImpressionMinPercentageViewed", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getImpressionMinPercentageViewed);
				} finally {
				}
			}
		}

		static IntPtr id_getImpressionMinTimeViewed;
		static IntPtr id_setImpressionMinTimeViewed_I;
		public unsafe int ImpressionMinTimeViewed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='getImpressionMinTimeViewed' and count(parameter)=0]"
			[Register ("getImpressionMinTimeViewed", "()I", "GetGetImpressionMinTimeViewedHandler")]
			get {
				if (id_getImpressionMinTimeViewed == IntPtr.Zero)
					id_getImpressionMinTimeViewed = JNIEnv.GetMethodID (class_ref, "getImpressionMinTimeViewed", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getImpressionMinTimeViewed);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='setImpressionMinTimeViewed' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setImpressionMinTimeViewed", "(I)V", "GetSetImpressionMinTimeViewed_IHandler")]
			set {
				if (id_setImpressionMinTimeViewed_I == IntPtr.Zero)
					id_setImpressionMinTimeViewed_I = JNIEnv.GetMethodID (class_ref, "setImpressionMinTimeViewed", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImpressionMinTimeViewed_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isImpressionRecorded;
		public unsafe bool IsImpressionRecorded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='isImpressionRecorded' and count(parameter)=0]"
			[Register ("isImpressionRecorded", "()Z", "GetIsImpressionRecordedHandler")]
			get {
				if (id_isImpressionRecorded == IntPtr.Zero)
					id_isImpressionRecorded = JNIEnv.GetMethodID (class_ref, "isImpressionRecorded", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isImpressionRecorded);
				} finally {
				}
			}
		}

		static IntPtr id_getMainImageUrl;
		static IntPtr id_setMainImageUrl_Ljava_lang_String_;
		public unsafe string MainImageUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='getMainImageUrl' and count(parameter)=0]"
			[Register ("getMainImageUrl", "()Ljava/lang/String;", "GetGetMainImageUrlHandler")]
			get {
				if (id_getMainImageUrl == IntPtr.Zero)
					id_getMainImageUrl = JNIEnv.GetMethodID (class_ref, "getMainImageUrl", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMainImageUrl), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='setMainImageUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMainImageUrl", "(Ljava/lang/String;)V", "GetSetMainImageUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setMainImageUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setMainImageUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMainImageUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMainImageUrl_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getPrivacyInformationIconClickThroughUrl;
		static IntPtr id_setPrivacyInformationIconClickThroughUrl_Ljava_lang_String_;
		public unsafe string PrivacyInformationIconClickThroughUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='getPrivacyInformationIconClickThroughUrl' and count(parameter)=0]"
			[Register ("getPrivacyInformationIconClickThroughUrl", "()Ljava/lang/String;", "GetGetPrivacyInformationIconClickThroughUrlHandler")]
			get {
				if (id_getPrivacyInformationIconClickThroughUrl == IntPtr.Zero)
					id_getPrivacyInformationIconClickThroughUrl = JNIEnv.GetMethodID (class_ref, "getPrivacyInformationIconClickThroughUrl", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrivacyInformationIconClickThroughUrl), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='setPrivacyInformationIconClickThroughUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPrivacyInformationIconClickThroughUrl", "(Ljava/lang/String;)V", "GetSetPrivacyInformationIconClickThroughUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setPrivacyInformationIconClickThroughUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setPrivacyInformationIconClickThroughUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPrivacyInformationIconClickThroughUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPrivacyInformationIconClickThroughUrl_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getPrivacyInformationIconImageUrl;
		static IntPtr id_setPrivacyInformationIconImageUrl_Ljava_lang_String_;
		public unsafe string PrivacyInformationIconImageUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='getPrivacyInformationIconImageUrl' and count(parameter)=0]"
			[Register ("getPrivacyInformationIconImageUrl", "()Ljava/lang/String;", "GetGetPrivacyInformationIconImageUrlHandler")]
			get {
				if (id_getPrivacyInformationIconImageUrl == IntPtr.Zero)
					id_getPrivacyInformationIconImageUrl = JNIEnv.GetMethodID (class_ref, "getPrivacyInformationIconImageUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrivacyInformationIconImageUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrivacyInformationIconImageUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='setPrivacyInformationIconImageUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPrivacyInformationIconImageUrl", "(Ljava/lang/String;)V", "GetSetPrivacyInformationIconImageUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setPrivacyInformationIconImageUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setPrivacyInformationIconImageUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPrivacyInformationIconImageUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPrivacyInformationIconImageUrl_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getStarRating;
		static IntPtr id_setStarRating_Ljava_lang_Double_;
		public unsafe global::Java.Lang.Double StarRating {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='getStarRating' and count(parameter)=0]"
			[Register ("getStarRating", "()Ljava/lang/Double;", "GetGetStarRatingHandler")]
			get {
				if (id_getStarRating == IntPtr.Zero)
					id_getStarRating = JNIEnv.GetMethodID (class_ref, "getStarRating", "()Ljava/lang/Double;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStarRating), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='setStarRating' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setStarRating", "(Ljava/lang/Double;)V", "GetSetStarRating_Ljava_lang_Double_Handler")]
			set {
				if (id_setStarRating_Ljava_lang_Double_ == IntPtr.Zero)
					id_setStarRating_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setStarRating", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStarRating_Ljava_lang_Double_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getText;
		static IntPtr id_setText_Ljava_lang_String_;
		public unsafe string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler")]
			get {
				if (id_getText == IntPtr.Zero)
					id_getText = JNIEnv.GetMethodID (class_ref, "getText", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getText), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setText", "(Ljava/lang/String;)V", "GetSetText_Ljava_lang_String_Handler")]
			set {
				if (id_setText_Ljava_lang_String_ == IntPtr.Zero)
					id_setText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setText_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_String_;
		public unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTitle_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_addExtra_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='addExtra' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("addExtra", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public unsafe void AddExtra (string p0, global::Java.Lang.Object p1)
		{
			if (id_addExtra_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_addExtra_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "addExtra", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addExtra_Ljava_lang_String_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_clear_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetClear_Landroid_view_View_Handler ()
		{
			if (cb_clear_Landroid_view_View_ == null)
				cb_clear_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Clear_Landroid_view_View_);
			return cb_clear_Landroid_view_View_;
		}

		static void n_Clear_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.StaticNativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.StaticNativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Clear (p0);
		}
#pragma warning restore 0169

		static IntPtr id_clear_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='clear' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("clear", "(Landroid/view/View;)V", "GetClear_Landroid_view_View_Handler")]
		public override unsafe void Clear (global::Android.Views.View p0)
		{
			if (id_clear_Landroid_view_View_ == IntPtr.Zero)
				id_clear_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "clear", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "(Landroid/view/View;)V"), __args);
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
			global::Com.Mopub.Nativeads.StaticNativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.StaticNativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public override unsafe void Destroy ()
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

		static IntPtr id_getExtra_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='getExtra' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getExtra", "(Ljava/lang/String;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object GetExtra (string p0)
		{
			if (id_getExtra_Ljava_lang_String_ == IntPtr.Zero)
				id_getExtra_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getExtra", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExtra_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Mopub.Nativeads.StaticNativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.StaticNativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_handleClick_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='handleClick' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("handleClick", "(Landroid/view/View;)V", "GetHandleClick_Landroid_view_View_Handler")]
		public virtual unsafe void HandleClick (global::Android.Views.View p0)
		{
			if (id_handleClick_Landroid_view_View_ == IntPtr.Zero)
				id_handleClick_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "handleClick", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleClick_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleClick", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_prepare_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetPrepare_Landroid_view_View_Handler ()
		{
			if (cb_prepare_Landroid_view_View_ == null)
				cb_prepare_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Prepare_Landroid_view_View_);
			return cb_prepare_Landroid_view_View_;
		}

		static void n_Prepare_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Nativeads.StaticNativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.StaticNativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Prepare (p0);
		}
#pragma warning restore 0169

		static IntPtr id_prepare_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='prepare' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("prepare", "(Landroid/view/View;)V", "GetPrepare_Landroid_view_View_Handler")]
		public override unsafe void Prepare (global::Android.Views.View p0)
		{
			if (id_prepare_Landroid_view_View_ == IntPtr.Zero)
				id_prepare_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "prepare", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepare_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepare", "(Landroid/view/View;)V"), __args);
			} finally {
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
			global::Com.Mopub.Nativeads.StaticNativeAd __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.StaticNativeAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RecordImpression (p0);
		}
#pragma warning restore 0169

		static IntPtr id_recordImpression_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='recordImpression' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("recordImpression", "(Landroid/view/View;)V", "GetRecordImpression_Landroid_view_View_Handler")]
		public virtual unsafe void RecordImpression (global::Android.Views.View p0)
		{
			if (id_recordImpression_Landroid_view_View_ == IntPtr.Zero)
				id_recordImpression_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "recordImpression", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordImpression_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recordImpression", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setImpressionRecorded;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='StaticNativeAd']/method[@name='setImpressionRecorded' and count(parameter)=0]"
		[Register ("setImpressionRecorded", "()V", "")]
		public unsafe void SetImpressionRecorded ()
		{
			if (id_setImpressionRecorded == IntPtr.Zero)
				id_setImpressionRecorded = JNIEnv.GetMethodID (class_ref, "setImpressionRecorded", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImpressionRecorded);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mopub/nativeads/StaticNativeAd", DoNotGenerateAcw=true)]
	internal partial class StaticNativeAdInvoker : StaticNativeAd {

		public StaticNativeAdInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (StaticNativeAdInvoker); }
		}

	}

}
