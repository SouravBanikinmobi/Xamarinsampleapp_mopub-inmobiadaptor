package mono.com.mopub.nativeads;


public class MoPubNativeAdLoadedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mopub.nativeads.MoPubNativeAdLoadedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAdLoaded:(I)V:GetOnAdLoaded_IHandler:Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerInvoker, MopubSdk\n" +
			"n_onAdRemoved:(I)V:GetOnAdRemoved_IHandler:Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerInvoker, MopubSdk\n" +
			"";
		mono.android.Runtime.register ("Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerImplementor, MopubSdk", MoPubNativeAdLoadedListenerImplementor.class, __md_methods);
	}


	public MoPubNativeAdLoadedListenerImplementor ()
	{
		super ();
		if (getClass () == MoPubNativeAdLoadedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mopub.Nativeads.IMoPubNativeAdLoadedListenerImplementor, MopubSdk", "", this, new java.lang.Object[] {  });
	}


	public void onAdLoaded (int p0)
	{
		n_onAdLoaded (p0);
	}

	private native void n_onAdLoaded (int p0);


	public void onAdRemoved (int p0)
	{
		n_onAdRemoved (p0);
	}

	private native void n_onAdRemoved (int p0);

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
