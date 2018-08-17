package mono.com.mopub.nativeads;


public class CustomEventNative_CustomEventNativeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mopub.nativeads.CustomEventNative.CustomEventNativeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onNativeAdFailed:(Lcom/mopub/nativeads/NativeErrorCode;)V:GetOnNativeAdFailed_Lcom_mopub_nativeads_NativeErrorCode_Handler:Com.Mopub.Nativeads.CustomEventNative/ICustomEventNativeListenerInvoker, MopubSdk\n" +
			"n_onNativeAdLoaded:(Lcom/mopub/nativeads/BaseNativeAd;)V:GetOnNativeAdLoaded_Lcom_mopub_nativeads_BaseNativeAd_Handler:Com.Mopub.Nativeads.CustomEventNative/ICustomEventNativeListenerInvoker, MopubSdk\n" +
			"";
		mono.android.Runtime.register ("Com.Mopub.Nativeads.CustomEventNative+ICustomEventNativeListenerImplementor, MopubSdk", CustomEventNative_CustomEventNativeListenerImplementor.class, __md_methods);
	}


	public CustomEventNative_CustomEventNativeListenerImplementor ()
	{
		super ();
		if (getClass () == CustomEventNative_CustomEventNativeListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mopub.Nativeads.CustomEventNative+ICustomEventNativeListenerImplementor, MopubSdk", "", this, new java.lang.Object[] {  });
	}


	public void onNativeAdFailed (com.mopub.nativeads.NativeErrorCode p0)
	{
		n_onNativeAdFailed (p0);
	}

	private native void n_onNativeAdFailed (com.mopub.nativeads.NativeErrorCode p0);


	public void onNativeAdLoaded (com.mopub.nativeads.BaseNativeAd p0)
	{
		n_onNativeAdLoaded (p0);
	}

	private native void n_onNativeAdLoaded (com.mopub.nativeads.BaseNativeAd p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
