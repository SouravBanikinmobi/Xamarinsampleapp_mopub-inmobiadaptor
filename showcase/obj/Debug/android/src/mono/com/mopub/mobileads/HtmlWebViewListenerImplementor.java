package mono.com.mopub.mobileads;


public class HtmlWebViewListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mopub.mobileads.HtmlWebViewListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClicked:()V:GetOnClickedHandler:com.mopub.mobileads.IHtmlWebViewListenerInvoker, MopubSdk\n" +
			"n_onCollapsed:()V:GetOnCollapsedHandler:com.mopub.mobileads.IHtmlWebViewListenerInvoker, MopubSdk\n" +
			"n_onFailed:(Lcom/mopub/mobileads/MoPubErrorCode;)V:GetOnFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler:com.mopub.mobileads.IHtmlWebViewListenerInvoker, MopubSdk\n" +
			"n_onLoaded:(Lcom/mopub/mobileads/BaseHtmlWebView;)V:GetOnLoaded_Lcom_mopub_mobileads_BaseHtmlWebView_Handler:com.mopub.mobileads.IHtmlWebViewListenerInvoker, MopubSdk\n" +
			"";
		mono.android.Runtime.register ("com.mopub.mobileads.IHtmlWebViewListenerImplementor, MopubSdk", HtmlWebViewListenerImplementor.class, __md_methods);
	}


	public HtmlWebViewListenerImplementor ()
	{
		super ();
		if (getClass () == HtmlWebViewListenerImplementor.class)
			mono.android.TypeManager.Activate ("com.mopub.mobileads.IHtmlWebViewListenerImplementor, MopubSdk", "", this, new java.lang.Object[] {  });
	}


	public void onClicked ()
	{
		n_onClicked ();
	}

	private native void n_onClicked ();


	public void onCollapsed ()
	{
		n_onCollapsed ();
	}

	private native void n_onCollapsed ();


	public void onFailed (com.mopub.mobileads.MoPubErrorCode p0)
	{
		n_onFailed (p0);
	}

	private native void n_onFailed (com.mopub.mobileads.MoPubErrorCode p0);


	public void onLoaded (com.mopub.mobileads.BaseHtmlWebView p0)
	{
		n_onLoaded (p0);
	}

	private native void n_onLoaded (com.mopub.mobileads.BaseHtmlWebView p0);

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
