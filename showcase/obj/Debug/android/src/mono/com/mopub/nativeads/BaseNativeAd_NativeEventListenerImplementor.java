package mono.com.mopub.nativeads;


public class BaseNativeAd_NativeEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mopub.nativeads.BaseNativeAd.NativeEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAdClicked:()V:GetOnAdClickedHandler:Com.Mopub.Nativeads.BaseNativeAd/INativeEventListenerInvoker, MopubSdk\n" +
			"n_onAdImpressed:()V:GetOnAdImpressedHandler:Com.Mopub.Nativeads.BaseNativeAd/INativeEventListenerInvoker, MopubSdk\n" +
			"";
		mono.android.Runtime.register ("Com.Mopub.Nativeads.BaseNativeAd+INativeEventListenerImplementor, MopubSdk", BaseNativeAd_NativeEventListenerImplementor.class, __md_methods);
	}


	public BaseNativeAd_NativeEventListenerImplementor ()
	{
		super ();
		if (getClass () == BaseNativeAd_NativeEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mopub.Nativeads.BaseNativeAd+INativeEventListenerImplementor, MopubSdk", "", this, new java.lang.Object[] {  });
	}


	public void onAdClicked ()
	{
		n_onAdClicked ();
	}

	private native void n_onAdClicked ();


	public void onAdImpressed ()
	{
		n_onAdImpressed ();
	}

	private native void n_onAdImpressed ();

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
