using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Integralads.Avid.Library.Inmobi.Video {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']"
	[Register ("com/integralads/avid/library/inmobi/video/AvidVideoPlaybackListener", "", "Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker")]
	public partial interface IAvidVideoPlaybackListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdClickThruEvent' and count(parameter)=0]"
		[Register ("recordAdClickThruEvent", "()V", "GetRecordAdClickThruEventHandler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdClickThruEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdCompleteEvent' and count(parameter)=0]"
		[Register ("recordAdCompleteEvent", "()V", "GetRecordAdCompleteEventHandler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdCompleteEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdDurationChangeEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("recordAdDurationChangeEvent", "(Ljava/lang/String;Ljava/lang/String;)V", "GetRecordAdDurationChangeEvent_Ljava_lang_String_Ljava_lang_String_Handler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdDurationChangeEvent (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdEnteredFullscreenEvent' and count(parameter)=0]"
		[Register ("recordAdEnteredFullscreenEvent", "()V", "GetRecordAdEnteredFullscreenEventHandler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdEnteredFullscreenEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("recordAdError", "(Ljava/lang/String;)V", "GetRecordAdError_Ljava_lang_String_Handler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdError (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdExitedFullscreenEvent' and count(parameter)=0]"
		[Register ("recordAdExitedFullscreenEvent", "()V", "GetRecordAdExitedFullscreenEventHandler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdExitedFullscreenEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdExpandedChangeEvent' and count(parameter)=0]"
		[Register ("recordAdExpandedChangeEvent", "()V", "GetRecordAdExpandedChangeEventHandler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdExpandedChangeEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdImpressionEvent' and count(parameter)=0]"
		[Register ("recordAdImpressionEvent", "()V", "GetRecordAdImpressionEventHandler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdImpressionEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdLoadedEvent' and count(parameter)=0]"
		[Register ("recordAdLoadedEvent", "()V", "GetRecordAdLoadedEventHandler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdLoadedEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdPausedEvent' and count(parameter)=0]"
		[Register ("recordAdPausedEvent", "()V", "GetRecordAdPausedEventHandler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdPausedEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdPlayingEvent' and count(parameter)=0]"
		[Register ("recordAdPlayingEvent", "()V", "GetRecordAdPlayingEventHandler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdPlayingEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdSkippedEvent' and count(parameter)=0]"
		[Register ("recordAdSkippedEvent", "()V", "GetRecordAdSkippedEventHandler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdSkippedEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdStartedEvent' and count(parameter)=0]"
		[Register ("recordAdStartedEvent", "()V", "GetRecordAdStartedEventHandler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdStartedEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdStoppedEvent' and count(parameter)=0]"
		[Register ("recordAdStoppedEvent", "()V", "GetRecordAdStoppedEventHandler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdStoppedEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdUserAcceptInvitationEvent' and count(parameter)=0]"
		[Register ("recordAdUserAcceptInvitationEvent", "()V", "GetRecordAdUserAcceptInvitationEventHandler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdUserAcceptInvitationEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdUserCloseEvent' and count(parameter)=0]"
		[Register ("recordAdUserCloseEvent", "()V", "GetRecordAdUserCloseEventHandler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdUserCloseEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdUserMinimizeEvent' and count(parameter)=0]"
		[Register ("recordAdUserMinimizeEvent", "()V", "GetRecordAdUserMinimizeEventHandler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdUserMinimizeEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdVideoFirstQuartileEvent' and count(parameter)=0]"
		[Register ("recordAdVideoFirstQuartileEvent", "()V", "GetRecordAdVideoFirstQuartileEventHandler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdVideoFirstQuartileEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdVideoMidpointEvent' and count(parameter)=0]"
		[Register ("recordAdVideoMidpointEvent", "()V", "GetRecordAdVideoMidpointEventHandler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdVideoMidpointEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdVideoStartEvent' and count(parameter)=0]"
		[Register ("recordAdVideoStartEvent", "()V", "GetRecordAdVideoStartEventHandler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdVideoStartEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdVideoThirdQuartileEvent' and count(parameter)=0]"
		[Register ("recordAdVideoThirdQuartileEvent", "()V", "GetRecordAdVideoThirdQuartileEventHandler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdVideoThirdQuartileEvent ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.integralads.avid.library.inmobi.video']/interface[@name='AvidVideoPlaybackListener']/method[@name='recordAdVolumeChangeEvent' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("recordAdVolumeChangeEvent", "(Ljava/lang/Integer;)V", "GetRecordAdVolumeChangeEvent_Ljava_lang_Integer_Handler:Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListenerInvoker, Jars")]
		void RecordAdVolumeChangeEvent (global::Java.Lang.Integer p0);

	}

	[global::Android.Runtime.Register ("com/integralads/avid/library/inmobi/video/AvidVideoPlaybackListener", DoNotGenerateAcw=true)]
	internal class IAvidVideoPlaybackListenerInvoker : global::Java.Lang.Object, IAvidVideoPlaybackListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/integralads/avid/library/inmobi/video/AvidVideoPlaybackListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAvidVideoPlaybackListenerInvoker); }
		}

		IntPtr class_ref;

		public static IAvidVideoPlaybackListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAvidVideoPlaybackListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.integralads.avid.library.inmobi.video.AvidVideoPlaybackListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAvidVideoPlaybackListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_recordAdClickThruEvent;
#pragma warning disable 0169
		static Delegate GetRecordAdClickThruEventHandler ()
		{
			if (cb_recordAdClickThruEvent == null)
				cb_recordAdClickThruEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordAdClickThruEvent);
			return cb_recordAdClickThruEvent;
		}

		static void n_RecordAdClickThruEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdClickThruEvent ();
		}
#pragma warning restore 0169

		IntPtr id_recordAdClickThruEvent;
		public unsafe void RecordAdClickThruEvent ()
		{
			if (id_recordAdClickThruEvent == IntPtr.Zero)
				id_recordAdClickThruEvent = JNIEnv.GetMethodID (class_ref, "recordAdClickThruEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdClickThruEvent);
		}

		static Delegate cb_recordAdCompleteEvent;
#pragma warning disable 0169
		static Delegate GetRecordAdCompleteEventHandler ()
		{
			if (cb_recordAdCompleteEvent == null)
				cb_recordAdCompleteEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordAdCompleteEvent);
			return cb_recordAdCompleteEvent;
		}

		static void n_RecordAdCompleteEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdCompleteEvent ();
		}
#pragma warning restore 0169

		IntPtr id_recordAdCompleteEvent;
		public unsafe void RecordAdCompleteEvent ()
		{
			if (id_recordAdCompleteEvent == IntPtr.Zero)
				id_recordAdCompleteEvent = JNIEnv.GetMethodID (class_ref, "recordAdCompleteEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdCompleteEvent);
		}

		static Delegate cb_recordAdDurationChangeEvent_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRecordAdDurationChangeEvent_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_recordAdDurationChangeEvent_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_recordAdDurationChangeEvent_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RecordAdDurationChangeEvent_Ljava_lang_String_Ljava_lang_String_);
			return cb_recordAdDurationChangeEvent_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_RecordAdDurationChangeEvent_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdDurationChangeEvent (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_recordAdDurationChangeEvent_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void RecordAdDurationChangeEvent (string p0, string p1)
		{
			if (id_recordAdDurationChangeEvent_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_recordAdDurationChangeEvent_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "recordAdDurationChangeEvent", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdDurationChangeEvent_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_recordAdEnteredFullscreenEvent;
#pragma warning disable 0169
		static Delegate GetRecordAdEnteredFullscreenEventHandler ()
		{
			if (cb_recordAdEnteredFullscreenEvent == null)
				cb_recordAdEnteredFullscreenEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordAdEnteredFullscreenEvent);
			return cb_recordAdEnteredFullscreenEvent;
		}

		static void n_RecordAdEnteredFullscreenEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdEnteredFullscreenEvent ();
		}
#pragma warning restore 0169

		IntPtr id_recordAdEnteredFullscreenEvent;
		public unsafe void RecordAdEnteredFullscreenEvent ()
		{
			if (id_recordAdEnteredFullscreenEvent == IntPtr.Zero)
				id_recordAdEnteredFullscreenEvent = JNIEnv.GetMethodID (class_ref, "recordAdEnteredFullscreenEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdEnteredFullscreenEvent);
		}

		static Delegate cb_recordAdError_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRecordAdError_Ljava_lang_String_Handler ()
		{
			if (cb_recordAdError_Ljava_lang_String_ == null)
				cb_recordAdError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RecordAdError_Ljava_lang_String_);
			return cb_recordAdError_Ljava_lang_String_;
		}

		static void n_RecordAdError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdError (p0);
		}
#pragma warning restore 0169

		IntPtr id_recordAdError_Ljava_lang_String_;
		public unsafe void RecordAdError (string p0)
		{
			if (id_recordAdError_Ljava_lang_String_ == IntPtr.Zero)
				id_recordAdError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "recordAdError", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdError_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_recordAdExitedFullscreenEvent;
#pragma warning disable 0169
		static Delegate GetRecordAdExitedFullscreenEventHandler ()
		{
			if (cb_recordAdExitedFullscreenEvent == null)
				cb_recordAdExitedFullscreenEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordAdExitedFullscreenEvent);
			return cb_recordAdExitedFullscreenEvent;
		}

		static void n_RecordAdExitedFullscreenEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdExitedFullscreenEvent ();
		}
#pragma warning restore 0169

		IntPtr id_recordAdExitedFullscreenEvent;
		public unsafe void RecordAdExitedFullscreenEvent ()
		{
			if (id_recordAdExitedFullscreenEvent == IntPtr.Zero)
				id_recordAdExitedFullscreenEvent = JNIEnv.GetMethodID (class_ref, "recordAdExitedFullscreenEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdExitedFullscreenEvent);
		}

		static Delegate cb_recordAdExpandedChangeEvent;
#pragma warning disable 0169
		static Delegate GetRecordAdExpandedChangeEventHandler ()
		{
			if (cb_recordAdExpandedChangeEvent == null)
				cb_recordAdExpandedChangeEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordAdExpandedChangeEvent);
			return cb_recordAdExpandedChangeEvent;
		}

		static void n_RecordAdExpandedChangeEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdExpandedChangeEvent ();
		}
#pragma warning restore 0169

		IntPtr id_recordAdExpandedChangeEvent;
		public unsafe void RecordAdExpandedChangeEvent ()
		{
			if (id_recordAdExpandedChangeEvent == IntPtr.Zero)
				id_recordAdExpandedChangeEvent = JNIEnv.GetMethodID (class_ref, "recordAdExpandedChangeEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdExpandedChangeEvent);
		}

		static Delegate cb_recordAdImpressionEvent;
#pragma warning disable 0169
		static Delegate GetRecordAdImpressionEventHandler ()
		{
			if (cb_recordAdImpressionEvent == null)
				cb_recordAdImpressionEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordAdImpressionEvent);
			return cb_recordAdImpressionEvent;
		}

		static void n_RecordAdImpressionEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdImpressionEvent ();
		}
#pragma warning restore 0169

		IntPtr id_recordAdImpressionEvent;
		public unsafe void RecordAdImpressionEvent ()
		{
			if (id_recordAdImpressionEvent == IntPtr.Zero)
				id_recordAdImpressionEvent = JNIEnv.GetMethodID (class_ref, "recordAdImpressionEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdImpressionEvent);
		}

		static Delegate cb_recordAdLoadedEvent;
#pragma warning disable 0169
		static Delegate GetRecordAdLoadedEventHandler ()
		{
			if (cb_recordAdLoadedEvent == null)
				cb_recordAdLoadedEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordAdLoadedEvent);
			return cb_recordAdLoadedEvent;
		}

		static void n_RecordAdLoadedEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdLoadedEvent ();
		}
#pragma warning restore 0169

		IntPtr id_recordAdLoadedEvent;
		public unsafe void RecordAdLoadedEvent ()
		{
			if (id_recordAdLoadedEvent == IntPtr.Zero)
				id_recordAdLoadedEvent = JNIEnv.GetMethodID (class_ref, "recordAdLoadedEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdLoadedEvent);
		}

		static Delegate cb_recordAdPausedEvent;
#pragma warning disable 0169
		static Delegate GetRecordAdPausedEventHandler ()
		{
			if (cb_recordAdPausedEvent == null)
				cb_recordAdPausedEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordAdPausedEvent);
			return cb_recordAdPausedEvent;
		}

		static void n_RecordAdPausedEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdPausedEvent ();
		}
#pragma warning restore 0169

		IntPtr id_recordAdPausedEvent;
		public unsafe void RecordAdPausedEvent ()
		{
			if (id_recordAdPausedEvent == IntPtr.Zero)
				id_recordAdPausedEvent = JNIEnv.GetMethodID (class_ref, "recordAdPausedEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdPausedEvent);
		}

		static Delegate cb_recordAdPlayingEvent;
#pragma warning disable 0169
		static Delegate GetRecordAdPlayingEventHandler ()
		{
			if (cb_recordAdPlayingEvent == null)
				cb_recordAdPlayingEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordAdPlayingEvent);
			return cb_recordAdPlayingEvent;
		}

		static void n_RecordAdPlayingEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdPlayingEvent ();
		}
#pragma warning restore 0169

		IntPtr id_recordAdPlayingEvent;
		public unsafe void RecordAdPlayingEvent ()
		{
			if (id_recordAdPlayingEvent == IntPtr.Zero)
				id_recordAdPlayingEvent = JNIEnv.GetMethodID (class_ref, "recordAdPlayingEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdPlayingEvent);
		}

		static Delegate cb_recordAdSkippedEvent;
#pragma warning disable 0169
		static Delegate GetRecordAdSkippedEventHandler ()
		{
			if (cb_recordAdSkippedEvent == null)
				cb_recordAdSkippedEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordAdSkippedEvent);
			return cb_recordAdSkippedEvent;
		}

		static void n_RecordAdSkippedEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdSkippedEvent ();
		}
#pragma warning restore 0169

		IntPtr id_recordAdSkippedEvent;
		public unsafe void RecordAdSkippedEvent ()
		{
			if (id_recordAdSkippedEvent == IntPtr.Zero)
				id_recordAdSkippedEvent = JNIEnv.GetMethodID (class_ref, "recordAdSkippedEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdSkippedEvent);
		}

		static Delegate cb_recordAdStartedEvent;
#pragma warning disable 0169
		static Delegate GetRecordAdStartedEventHandler ()
		{
			if (cb_recordAdStartedEvent == null)
				cb_recordAdStartedEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordAdStartedEvent);
			return cb_recordAdStartedEvent;
		}

		static void n_RecordAdStartedEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdStartedEvent ();
		}
#pragma warning restore 0169

		IntPtr id_recordAdStartedEvent;
		public unsafe void RecordAdStartedEvent ()
		{
			if (id_recordAdStartedEvent == IntPtr.Zero)
				id_recordAdStartedEvent = JNIEnv.GetMethodID (class_ref, "recordAdStartedEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdStartedEvent);
		}

		static Delegate cb_recordAdStoppedEvent;
#pragma warning disable 0169
		static Delegate GetRecordAdStoppedEventHandler ()
		{
			if (cb_recordAdStoppedEvent == null)
				cb_recordAdStoppedEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordAdStoppedEvent);
			return cb_recordAdStoppedEvent;
		}

		static void n_RecordAdStoppedEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdStoppedEvent ();
		}
#pragma warning restore 0169

		IntPtr id_recordAdStoppedEvent;
		public unsafe void RecordAdStoppedEvent ()
		{
			if (id_recordAdStoppedEvent == IntPtr.Zero)
				id_recordAdStoppedEvent = JNIEnv.GetMethodID (class_ref, "recordAdStoppedEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdStoppedEvent);
		}

		static Delegate cb_recordAdUserAcceptInvitationEvent;
#pragma warning disable 0169
		static Delegate GetRecordAdUserAcceptInvitationEventHandler ()
		{
			if (cb_recordAdUserAcceptInvitationEvent == null)
				cb_recordAdUserAcceptInvitationEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordAdUserAcceptInvitationEvent);
			return cb_recordAdUserAcceptInvitationEvent;
		}

		static void n_RecordAdUserAcceptInvitationEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdUserAcceptInvitationEvent ();
		}
#pragma warning restore 0169

		IntPtr id_recordAdUserAcceptInvitationEvent;
		public unsafe void RecordAdUserAcceptInvitationEvent ()
		{
			if (id_recordAdUserAcceptInvitationEvent == IntPtr.Zero)
				id_recordAdUserAcceptInvitationEvent = JNIEnv.GetMethodID (class_ref, "recordAdUserAcceptInvitationEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdUserAcceptInvitationEvent);
		}

		static Delegate cb_recordAdUserCloseEvent;
#pragma warning disable 0169
		static Delegate GetRecordAdUserCloseEventHandler ()
		{
			if (cb_recordAdUserCloseEvent == null)
				cb_recordAdUserCloseEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordAdUserCloseEvent);
			return cb_recordAdUserCloseEvent;
		}

		static void n_RecordAdUserCloseEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdUserCloseEvent ();
		}
#pragma warning restore 0169

		IntPtr id_recordAdUserCloseEvent;
		public unsafe void RecordAdUserCloseEvent ()
		{
			if (id_recordAdUserCloseEvent == IntPtr.Zero)
				id_recordAdUserCloseEvent = JNIEnv.GetMethodID (class_ref, "recordAdUserCloseEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdUserCloseEvent);
		}

		static Delegate cb_recordAdUserMinimizeEvent;
#pragma warning disable 0169
		static Delegate GetRecordAdUserMinimizeEventHandler ()
		{
			if (cb_recordAdUserMinimizeEvent == null)
				cb_recordAdUserMinimizeEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordAdUserMinimizeEvent);
			return cb_recordAdUserMinimizeEvent;
		}

		static void n_RecordAdUserMinimizeEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdUserMinimizeEvent ();
		}
#pragma warning restore 0169

		IntPtr id_recordAdUserMinimizeEvent;
		public unsafe void RecordAdUserMinimizeEvent ()
		{
			if (id_recordAdUserMinimizeEvent == IntPtr.Zero)
				id_recordAdUserMinimizeEvent = JNIEnv.GetMethodID (class_ref, "recordAdUserMinimizeEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdUserMinimizeEvent);
		}

		static Delegate cb_recordAdVideoFirstQuartileEvent;
#pragma warning disable 0169
		static Delegate GetRecordAdVideoFirstQuartileEventHandler ()
		{
			if (cb_recordAdVideoFirstQuartileEvent == null)
				cb_recordAdVideoFirstQuartileEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordAdVideoFirstQuartileEvent);
			return cb_recordAdVideoFirstQuartileEvent;
		}

		static void n_RecordAdVideoFirstQuartileEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdVideoFirstQuartileEvent ();
		}
#pragma warning restore 0169

		IntPtr id_recordAdVideoFirstQuartileEvent;
		public unsafe void RecordAdVideoFirstQuartileEvent ()
		{
			if (id_recordAdVideoFirstQuartileEvent == IntPtr.Zero)
				id_recordAdVideoFirstQuartileEvent = JNIEnv.GetMethodID (class_ref, "recordAdVideoFirstQuartileEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdVideoFirstQuartileEvent);
		}

		static Delegate cb_recordAdVideoMidpointEvent;
#pragma warning disable 0169
		static Delegate GetRecordAdVideoMidpointEventHandler ()
		{
			if (cb_recordAdVideoMidpointEvent == null)
				cb_recordAdVideoMidpointEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordAdVideoMidpointEvent);
			return cb_recordAdVideoMidpointEvent;
		}

		static void n_RecordAdVideoMidpointEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdVideoMidpointEvent ();
		}
#pragma warning restore 0169

		IntPtr id_recordAdVideoMidpointEvent;
		public unsafe void RecordAdVideoMidpointEvent ()
		{
			if (id_recordAdVideoMidpointEvent == IntPtr.Zero)
				id_recordAdVideoMidpointEvent = JNIEnv.GetMethodID (class_ref, "recordAdVideoMidpointEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdVideoMidpointEvent);
		}

		static Delegate cb_recordAdVideoStartEvent;
#pragma warning disable 0169
		static Delegate GetRecordAdVideoStartEventHandler ()
		{
			if (cb_recordAdVideoStartEvent == null)
				cb_recordAdVideoStartEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordAdVideoStartEvent);
			return cb_recordAdVideoStartEvent;
		}

		static void n_RecordAdVideoStartEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdVideoStartEvent ();
		}
#pragma warning restore 0169

		IntPtr id_recordAdVideoStartEvent;
		public unsafe void RecordAdVideoStartEvent ()
		{
			if (id_recordAdVideoStartEvent == IntPtr.Zero)
				id_recordAdVideoStartEvent = JNIEnv.GetMethodID (class_ref, "recordAdVideoStartEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdVideoStartEvent);
		}

		static Delegate cb_recordAdVideoThirdQuartileEvent;
#pragma warning disable 0169
		static Delegate GetRecordAdVideoThirdQuartileEventHandler ()
		{
			if (cb_recordAdVideoThirdQuartileEvent == null)
				cb_recordAdVideoThirdQuartileEvent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordAdVideoThirdQuartileEvent);
			return cb_recordAdVideoThirdQuartileEvent;
		}

		static void n_RecordAdVideoThirdQuartileEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdVideoThirdQuartileEvent ();
		}
#pragma warning restore 0169

		IntPtr id_recordAdVideoThirdQuartileEvent;
		public unsafe void RecordAdVideoThirdQuartileEvent ()
		{
			if (id_recordAdVideoThirdQuartileEvent == IntPtr.Zero)
				id_recordAdVideoThirdQuartileEvent = JNIEnv.GetMethodID (class_ref, "recordAdVideoThirdQuartileEvent", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdVideoThirdQuartileEvent);
		}

		static Delegate cb_recordAdVolumeChangeEvent_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetRecordAdVolumeChangeEvent_Ljava_lang_Integer_Handler ()
		{
			if (cb_recordAdVolumeChangeEvent_Ljava_lang_Integer_ == null)
				cb_recordAdVolumeChangeEvent_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RecordAdVolumeChangeEvent_Ljava_lang_Integer_);
			return cb_recordAdVolumeChangeEvent_Ljava_lang_Integer_;
		}

		static void n_RecordAdVolumeChangeEvent_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener __this = global::Java.Lang.Object.GetObject<global::Com.Integralads.Avid.Library.Inmobi.Video.IAvidVideoPlaybackListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RecordAdVolumeChangeEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_recordAdVolumeChangeEvent_Ljava_lang_Integer_;
		public unsafe void RecordAdVolumeChangeEvent (global::Java.Lang.Integer p0)
		{
			if (id_recordAdVolumeChangeEvent_Ljava_lang_Integer_ == IntPtr.Zero)
				id_recordAdVolumeChangeEvent_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "recordAdVolumeChangeEvent", "(Ljava/lang/Integer;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAdVolumeChangeEvent_Ljava_lang_Integer_, __args);
		}

	}

	// event args for com.integralads.avid.library.inmobi.video.AvidVideoPlaybackListener.recordAdDurationChangeEvent
	public partial class RecordAdDurationChangeEventEventArgs : global::System.EventArgs {

		public RecordAdDurationChangeEventEventArgs (string p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	// event args for com.integralads.avid.library.inmobi.video.AvidVideoPlaybackListener.recordAdError
	public partial class RecordAdErrorEventArgs : global::System.EventArgs {

		public RecordAdErrorEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	// event args for com.integralads.avid.library.inmobi.video.AvidVideoPlaybackListener.recordAdVolumeChangeEvent
	public partial class RecordAdVolumeChangeEventEventArgs : global::System.EventArgs {

		public RecordAdVolumeChangeEventEventArgs (global::Java.Lang.Integer p0)
		{
			this.p0 = p0;
		}

		global::Java.Lang.Integer p0;
		public global::Java.Lang.Integer P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/integralads/avid/library/inmobi/video/AvidVideoPlaybackListenerImplementor")]
	internal sealed partial class IAvidVideoPlaybackListenerImplementor : global::Java.Lang.Object, IAvidVideoPlaybackListener {

		object sender;

		public IAvidVideoPlaybackListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/integralads/avid/library/inmobi/video/AvidVideoPlaybackListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler RecordAdClickThruEventHandler;
#pragma warning restore 0649

		public void RecordAdClickThruEvent ()
		{
			var __h = RecordAdClickThruEventHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler RecordAdCompleteEventHandler;
#pragma warning restore 0649

		public void RecordAdCompleteEvent ()
		{
			var __h = RecordAdCompleteEventHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<RecordAdDurationChangeEventEventArgs> RecordAdDurationChangeEventHandler;
#pragma warning restore 0649

		public void RecordAdDurationChangeEvent (string p0, string p1)
		{
			var __h = RecordAdDurationChangeEventHandler;
			if (__h != null)
				__h (sender, new RecordAdDurationChangeEventEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler RecordAdEnteredFullscreenEventHandler;
#pragma warning restore 0649

		public void RecordAdEnteredFullscreenEvent ()
		{
			var __h = RecordAdEnteredFullscreenEventHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<RecordAdErrorEventArgs> RecordAdErrorHandler;
#pragma warning restore 0649

		public void RecordAdError (string p0)
		{
			var __h = RecordAdErrorHandler;
			if (__h != null)
				__h (sender, new RecordAdErrorEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler RecordAdExitedFullscreenEventHandler;
#pragma warning restore 0649

		public void RecordAdExitedFullscreenEvent ()
		{
			var __h = RecordAdExitedFullscreenEventHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler RecordAdExpandedChangeEventHandler;
#pragma warning restore 0649

		public void RecordAdExpandedChangeEvent ()
		{
			var __h = RecordAdExpandedChangeEventHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler RecordAdImpressionEventHandler;
#pragma warning restore 0649

		public void RecordAdImpressionEvent ()
		{
			var __h = RecordAdImpressionEventHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler RecordAdLoadedEventHandler;
#pragma warning restore 0649

		public void RecordAdLoadedEvent ()
		{
			var __h = RecordAdLoadedEventHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler RecordAdPausedEventHandler;
#pragma warning restore 0649

		public void RecordAdPausedEvent ()
		{
			var __h = RecordAdPausedEventHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler RecordAdPlayingEventHandler;
#pragma warning restore 0649

		public void RecordAdPlayingEvent ()
		{
			var __h = RecordAdPlayingEventHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler RecordAdSkippedEventHandler;
#pragma warning restore 0649

		public void RecordAdSkippedEvent ()
		{
			var __h = RecordAdSkippedEventHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler RecordAdStartedEventHandler;
#pragma warning restore 0649

		public void RecordAdStartedEvent ()
		{
			var __h = RecordAdStartedEventHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler RecordAdStoppedEventHandler;
#pragma warning restore 0649

		public void RecordAdStoppedEvent ()
		{
			var __h = RecordAdStoppedEventHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler RecordAdUserAcceptInvitationEventHandler;
#pragma warning restore 0649

		public void RecordAdUserAcceptInvitationEvent ()
		{
			var __h = RecordAdUserAcceptInvitationEventHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler RecordAdUserCloseEventHandler;
#pragma warning restore 0649

		public void RecordAdUserCloseEvent ()
		{
			var __h = RecordAdUserCloseEventHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler RecordAdUserMinimizeEventHandler;
#pragma warning restore 0649

		public void RecordAdUserMinimizeEvent ()
		{
			var __h = RecordAdUserMinimizeEventHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler RecordAdVideoFirstQuartileEventHandler;
#pragma warning restore 0649

		public void RecordAdVideoFirstQuartileEvent ()
		{
			var __h = RecordAdVideoFirstQuartileEventHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler RecordAdVideoMidpointEventHandler;
#pragma warning restore 0649

		public void RecordAdVideoMidpointEvent ()
		{
			var __h = RecordAdVideoMidpointEventHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler RecordAdVideoStartEventHandler;
#pragma warning restore 0649

		public void RecordAdVideoStartEvent ()
		{
			var __h = RecordAdVideoStartEventHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler RecordAdVideoThirdQuartileEventHandler;
#pragma warning restore 0649

		public void RecordAdVideoThirdQuartileEvent ()
		{
			var __h = RecordAdVideoThirdQuartileEventHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<RecordAdVolumeChangeEventEventArgs> RecordAdVolumeChangeEventHandler;
#pragma warning restore 0649

		public void RecordAdVolumeChangeEvent (global::Java.Lang.Integer p0)
		{
			var __h = RecordAdVolumeChangeEventHandler;
			if (__h != null)
				__h (sender, new RecordAdVolumeChangeEventEventArgs (p0));
		}

		internal static bool __IsEmpty (IAvidVideoPlaybackListenerImplementor value)
		{
			return value.RecordAdClickThruEventHandler == null && value.RecordAdCompleteEventHandler == null && value.RecordAdDurationChangeEventHandler == null && value.RecordAdEnteredFullscreenEventHandler == null && value.RecordAdErrorHandler == null && value.RecordAdExitedFullscreenEventHandler == null && value.RecordAdExpandedChangeEventHandler == null && value.RecordAdImpressionEventHandler == null && value.RecordAdLoadedEventHandler == null && value.RecordAdPausedEventHandler == null && value.RecordAdPlayingEventHandler == null && value.RecordAdSkippedEventHandler == null && value.RecordAdStartedEventHandler == null && value.RecordAdStoppedEventHandler == null && value.RecordAdUserAcceptInvitationEventHandler == null && value.RecordAdUserCloseEventHandler == null && value.RecordAdUserMinimizeEventHandler == null && value.RecordAdVideoFirstQuartileEventHandler == null && value.RecordAdVideoMidpointEventHandler == null && value.RecordAdVideoStartEventHandler == null && value.RecordAdVideoThirdQuartileEventHandler == null && value.RecordAdVolumeChangeEventHandler == null;
		}
	}

}
