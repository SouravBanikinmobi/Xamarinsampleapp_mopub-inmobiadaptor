using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Nativeads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubNativeAdPositioning']"
	[global::Android.Runtime.Register ("com/mopub/nativeads/MoPubNativeAdPositioning", DoNotGenerateAcw=true)]
	public sealed partial class MoPubNativeAdPositioning : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubNativeAdPositioning.MoPubClientPositioning']"
		[global::Android.Runtime.Register ("com/mopub/nativeads/MoPubNativeAdPositioning$MoPubClientPositioning", DoNotGenerateAcw=true)]
		public partial class MoPubClientPositioning : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubNativeAdPositioning.MoPubClientPositioning']/field[@name='NO_REPEAT']"
			[Register ("NO_REPEAT")]
			public const int NoRepeat = (int) 2147483647;
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/nativeads/MoPubNativeAdPositioning$MoPubClientPositioning", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MoPubClientPositioning); }
			}

			protected MoPubClientPositioning (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubNativeAdPositioning.MoPubClientPositioning']/constructor[@name='MoPubNativeAdPositioning.MoPubClientPositioning' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe MoPubClientPositioning ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (MoPubClientPositioning)) {
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

			static Delegate cb_addFixedPosition_I;
#pragma warning disable 0169
			static Delegate GetAddFixedPosition_IHandler ()
			{
				if (cb_addFixedPosition_I == null)
					cb_addFixedPosition_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_AddFixedPosition_I);
				return cb_addFixedPosition_I;
			}

			static IntPtr n_AddFixedPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Mopub.Nativeads.MoPubNativeAdPositioning.MoPubClientPositioning __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubNativeAdPositioning.MoPubClientPositioning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AddFixedPosition (p0));
			}
#pragma warning restore 0169

			static IntPtr id_addFixedPosition_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubNativeAdPositioning.MoPubClientPositioning']/method[@name='addFixedPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("addFixedPosition", "(I)Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubClientPositioning;", "GetAddFixedPosition_IHandler")]
			public virtual unsafe global::Com.Mopub.Nativeads.MoPubNativeAdPositioning.MoPubClientPositioning AddFixedPosition (int p0)
			{
				if (id_addFixedPosition_I == IntPtr.Zero)
					id_addFixedPosition_I = JNIEnv.GetMethodID (class_ref, "addFixedPosition", "(I)Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubClientPositioning;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubNativeAdPositioning.MoPubClientPositioning> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addFixedPosition_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubNativeAdPositioning.MoPubClientPositioning> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFixedPosition", "(I)Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubClientPositioning;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_enableRepeatingPositions_I;
#pragma warning disable 0169
			static Delegate GetEnableRepeatingPositions_IHandler ()
			{
				if (cb_enableRepeatingPositions_I == null)
					cb_enableRepeatingPositions_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_EnableRepeatingPositions_I);
				return cb_enableRepeatingPositions_I;
			}

			static IntPtr n_EnableRepeatingPositions_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Mopub.Nativeads.MoPubNativeAdPositioning.MoPubClientPositioning __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubNativeAdPositioning.MoPubClientPositioning> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.EnableRepeatingPositions (p0));
			}
#pragma warning restore 0169

			static IntPtr id_enableRepeatingPositions_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubNativeAdPositioning.MoPubClientPositioning']/method[@name='enableRepeatingPositions' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("enableRepeatingPositions", "(I)Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubClientPositioning;", "GetEnableRepeatingPositions_IHandler")]
			public virtual unsafe global::Com.Mopub.Nativeads.MoPubNativeAdPositioning.MoPubClientPositioning EnableRepeatingPositions (int p0)
			{
				if (id_enableRepeatingPositions_I == IntPtr.Zero)
					id_enableRepeatingPositions_I = JNIEnv.GetMethodID (class_ref, "enableRepeatingPositions", "(I)Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubClientPositioning;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubNativeAdPositioning.MoPubClientPositioning> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_enableRepeatingPositions_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubNativeAdPositioning.MoPubClientPositioning> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableRepeatingPositions", "(I)Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubClientPositioning;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubNativeAdPositioning.MoPubServerPositioning']"
		[global::Android.Runtime.Register ("com/mopub/nativeads/MoPubNativeAdPositioning$MoPubServerPositioning", DoNotGenerateAcw=true)]
		public partial class MoPubServerPositioning : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/nativeads/MoPubNativeAdPositioning$MoPubServerPositioning", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MoPubServerPositioning); }
			}

			protected MoPubServerPositioning (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubNativeAdPositioning.MoPubServerPositioning']/constructor[@name='MoPubNativeAdPositioning.MoPubServerPositioning' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe MoPubServerPositioning ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (MoPubServerPositioning)) {
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

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/nativeads/MoPubNativeAdPositioning", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MoPubNativeAdPositioning); }
		}

		internal MoPubNativeAdPositioning (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubNativeAdPositioning']/constructor[@name='MoPubNativeAdPositioning' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MoPubNativeAdPositioning ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MoPubNativeAdPositioning)) {
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

		static IntPtr id_clientPositioning;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubNativeAdPositioning']/method[@name='clientPositioning' and count(parameter)=0]"
		[Register ("clientPositioning", "()Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubClientPositioning;", "")]
		public static unsafe global::Com.Mopub.Nativeads.MoPubNativeAdPositioning.MoPubClientPositioning ClientPositioning ()
		{
			if (id_clientPositioning == IntPtr.Zero)
				id_clientPositioning = JNIEnv.GetStaticMethodID (class_ref, "clientPositioning", "()Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubClientPositioning;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubNativeAdPositioning.MoPubClientPositioning> (JNIEnv.CallStaticObjectMethod  (class_ref, id_clientPositioning), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_serverPositioning;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.nativeads']/class[@name='MoPubNativeAdPositioning']/method[@name='serverPositioning' and count(parameter)=0]"
		[Register ("serverPositioning", "()Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubServerPositioning;", "")]
		public static unsafe global::Com.Mopub.Nativeads.MoPubNativeAdPositioning.MoPubServerPositioning ServerPositioning ()
		{
			if (id_serverPositioning == IntPtr.Zero)
				id_serverPositioning = JNIEnv.GetStaticMethodID (class_ref, "serverPositioning", "()Lcom/mopub/nativeads/MoPubNativeAdPositioning$MoPubServerPositioning;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Nativeads.MoPubNativeAdPositioning.MoPubServerPositioning> (JNIEnv.CallStaticObjectMethod  (class_ref, id_serverPositioning), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
