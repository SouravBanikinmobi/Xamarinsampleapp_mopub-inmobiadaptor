package mono.com.mopub.common;


public class CloseableLayout_OnCloseListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mopub.common.CloseableLayout.OnCloseListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClose:()V:GetOnCloseHandler:com.mopub.common.CloseableLayout/IOnCloseListenerInvoker, MopubSdk\n" +
			"";
		mono.android.Runtime.register ("com.mopub.common.CloseableLayout+IOnCloseListenerImplementor, MopubSdk", CloseableLayout_OnCloseListenerImplementor.class, __md_methods);
	}


	public CloseableLayout_OnCloseListenerImplementor ()
	{
		super ();
		if (getClass () == CloseableLayout_OnCloseListenerImplementor.class)
			mono.android.TypeManager.Activate ("com.mopub.common.CloseableLayout+IOnCloseListenerImplementor, MopubSdk", "", this, new java.lang.Object[] {  });
	}


	public void onClose ()
	{
		n_onClose ();
	}

	private native void n_onClose ();

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
