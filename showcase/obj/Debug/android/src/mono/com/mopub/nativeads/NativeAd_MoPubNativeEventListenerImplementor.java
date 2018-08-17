package mono.com.mopub.nativeads;


public class NativeAd_MoPubNativeEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mopub.nativeads.NativeAd.MoPubNativeEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClick:(Landroid/view/View;)V:GetOnClick_Landroid_view_View_Handler:Com.Mopub.Nativeads.NativeAd/IMoPubNativeEventListenerInvoker, MopubSdk\n" +
			"n_onImpression:(Landroid/view/View;)V:GetOnImpression_Landroid_view_View_Handler:Com.Mopub.Nativeads.NativeAd/IMoPubNativeEventListenerInvoker, MopubSdk\n" +
			"";
		mono.android.Runtime.register ("Com.Mopub.Nativeads.NativeAd+IMoPubNativeEventListenerImplementor, MopubSdk", NativeAd_MoPubNativeEventListenerImplementor.class, __md_methods);
	}


	public NativeAd_MoPubNativeEventListenerImplementor ()
	{
		super ();
		if (getClass () == NativeAd_MoPubNativeEventListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mopub.Nativeads.NativeAd+IMoPubNativeEventListenerImplementor, MopubSdk", "", this, new java.lang.Object[] {  });
	}


	public void onClick (android.view.View p0)
	{
		n_onClick (p0);
	}

	private native void n_onClick (android.view.View p0);


	public void onImpression (android.view.View p0)
	{
		n_onImpression (p0);
	}

	private native void n_onImpression (android.view.View p0);

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
