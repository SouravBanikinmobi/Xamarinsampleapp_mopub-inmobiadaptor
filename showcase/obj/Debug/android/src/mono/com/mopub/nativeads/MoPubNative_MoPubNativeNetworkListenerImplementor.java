package mono.com.mopub.nativeads;


public class MoPubNative_MoPubNativeNetworkListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mopub.nativeads.MoPubNative.MoPubNativeNetworkListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onNativeFail:(Lcom/mopub/nativeads/NativeErrorCode;)V:GetOnNativeFail_Lcom_mopub_nativeads_NativeErrorCode_Handler:Com.Mopub.Nativeads.MoPubNative/IMoPubNativeNetworkListenerInvoker, MopubSdk\n" +
			"n_onNativeLoad:(Lcom/mopub/nativeads/NativeAd;)V:GetOnNativeLoad_Lcom_mopub_nativeads_NativeAd_Handler:Com.Mopub.Nativeads.MoPubNative/IMoPubNativeNetworkListenerInvoker, MopubSdk\n" +
			"";
		mono.android.Runtime.register ("Com.Mopub.Nativeads.MoPubNative+IMoPubNativeNetworkListenerImplementor, MopubSdk", MoPubNative_MoPubNativeNetworkListenerImplementor.class, __md_methods);
	}


	public MoPubNative_MoPubNativeNetworkListenerImplementor ()
	{
		super ();
		if (getClass () == MoPubNative_MoPubNativeNetworkListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mopub.Nativeads.MoPubNative+IMoPubNativeNetworkListenerImplementor, MopubSdk", "", this, new java.lang.Object[] {  });
	}


	public void onNativeFail (com.mopub.nativeads.NativeErrorCode p0)
	{
		n_onNativeFail (p0);
	}

	private native void n_onNativeFail (com.mopub.nativeads.NativeErrorCode p0);


	public void onNativeLoad (com.mopub.nativeads.NativeAd p0)
	{
		n_onNativeLoad (p0);
	}

	private native void n_onNativeLoad (com.mopub.nativeads.NativeAd p0);

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
