package mono.com.mopub.mobileads;


public class CustomEventInterstitial_CustomEventInterstitialListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mopub.mobileads.CustomEventInterstitial.CustomEventInterstitialListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onInterstitialClicked:()V:GetOnInterstitialClickedHandler:com.mopub.mobileads.CustomEventInterstitial/ICustomEventInterstitialListenerInvoker, MopubSdk\n" +
			"n_onInterstitialDismissed:()V:GetOnInterstitialDismissedHandler:com.mopub.mobileads.CustomEventInterstitial/ICustomEventInterstitialListenerInvoker, MopubSdk\n" +
			"n_onInterstitialFailed:(Lcom/mopub/mobileads/MoPubErrorCode;)V:GetOnInterstitialFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler:com.mopub.mobileads.CustomEventInterstitial/ICustomEventInterstitialListenerInvoker, MopubSdk\n" +
			"n_onInterstitialLoaded:()V:GetOnInterstitialLoadedHandler:com.mopub.mobileads.CustomEventInterstitial/ICustomEventInterstitialListenerInvoker, MopubSdk\n" +
			"n_onInterstitialShown:()V:GetOnInterstitialShownHandler:com.mopub.mobileads.CustomEventInterstitial/ICustomEventInterstitialListenerInvoker, MopubSdk\n" +
			"n_onLeaveApplication:()V:GetOnLeaveApplicationHandler:com.mopub.mobileads.CustomEventInterstitial/ICustomEventInterstitialListenerInvoker, MopubSdk\n" +
			"";
		mono.android.Runtime.register ("com.mopub.mobileads.CustomEventInterstitial+ICustomEventInterstitialListenerImplementor, MopubSdk", CustomEventInterstitial_CustomEventInterstitialListenerImplementor.class, __md_methods);
	}


	public CustomEventInterstitial_CustomEventInterstitialListenerImplementor ()
	{
		super ();
		if (getClass () == CustomEventInterstitial_CustomEventInterstitialListenerImplementor.class)
			mono.android.TypeManager.Activate ("com.mopub.mobileads.CustomEventInterstitial+ICustomEventInterstitialListenerImplementor, MopubSdk", "", this, new java.lang.Object[] {  });
	}


	public void onInterstitialClicked ()
	{
		n_onInterstitialClicked ();
	}

	private native void n_onInterstitialClicked ();


	public void onInterstitialDismissed ()
	{
		n_onInterstitialDismissed ();
	}

	private native void n_onInterstitialDismissed ();


	public void onInterstitialFailed (com.mopub.mobileads.MoPubErrorCode p0)
	{
		n_onInterstitialFailed (p0);
	}

	private native void n_onInterstitialFailed (com.mopub.mobileads.MoPubErrorCode p0);


	public void onInterstitialLoaded ()
	{
		n_onInterstitialLoaded ();
	}

	private native void n_onInterstitialLoaded ();


	public void onInterstitialShown ()
	{
		n_onInterstitialShown ();
	}

	private native void n_onInterstitialShown ();


	public void onLeaveApplication ()
	{
		n_onLeaveApplication ();
	}

	private native void n_onLeaveApplication ();

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
