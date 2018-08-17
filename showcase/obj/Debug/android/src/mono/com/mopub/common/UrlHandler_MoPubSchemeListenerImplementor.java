package mono.com.mopub.common;


public class UrlHandler_MoPubSchemeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mopub.common.UrlHandler.MoPubSchemeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClose:()V:GetOnCloseHandler:com.mopub.common.UrlHandler/IMoPubSchemeListenerInvoker, MopubSdk\n" +
			"n_onFailLoad:()V:GetOnFailLoadHandler:com.mopub.common.UrlHandler/IMoPubSchemeListenerInvoker, MopubSdk\n" +
			"n_onFinishLoad:()V:GetOnFinishLoadHandler:com.mopub.common.UrlHandler/IMoPubSchemeListenerInvoker, MopubSdk\n" +
			"";
		mono.android.Runtime.register ("com.mopub.common.UrlHandler+IMoPubSchemeListenerImplementor, MopubSdk", UrlHandler_MoPubSchemeListenerImplementor.class, __md_methods);
	}


	public UrlHandler_MoPubSchemeListenerImplementor ()
	{
		super ();
		if (getClass () == UrlHandler_MoPubSchemeListenerImplementor.class)
			mono.android.TypeManager.Activate ("com.mopub.common.UrlHandler+IMoPubSchemeListenerImplementor, MopubSdk", "", this, new java.lang.Object[] {  });
	}


	public void onClose ()
	{
		n_onClose ();
	}

	private native void n_onClose ();


	public void onFailLoad ()
	{
		n_onFailLoad ();
	}

	private native void n_onFailLoad ();


	public void onFinishLoad ()
	{
		n_onFinishLoad ();
	}

	private native void n_onFinishLoad ();

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
