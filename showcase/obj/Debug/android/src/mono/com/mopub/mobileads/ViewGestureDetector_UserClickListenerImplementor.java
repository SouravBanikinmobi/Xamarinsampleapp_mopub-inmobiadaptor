package mono.com.mopub.mobileads;


public class ViewGestureDetector_UserClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mopub.mobileads.ViewGestureDetector.UserClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onResetUserClick:()V:GetOnResetUserClickHandler:com.mopub.mobileads.ViewGestureDetector/IUserClickListenerInvoker, MopubSdk\n" +
			"n_onUserClick:()V:GetOnUserClickHandler:com.mopub.mobileads.ViewGestureDetector/IUserClickListenerInvoker, MopubSdk\n" +
			"n_wasClicked:()Z:GetWasClickedHandler:com.mopub.mobileads.ViewGestureDetector/IUserClickListenerInvoker, MopubSdk\n" +
			"";
		mono.android.Runtime.register ("com.mopub.mobileads.ViewGestureDetector+IUserClickListenerImplementor, MopubSdk", ViewGestureDetector_UserClickListenerImplementor.class, __md_methods);
	}


	public ViewGestureDetector_UserClickListenerImplementor ()
	{
		super ();
		if (getClass () == ViewGestureDetector_UserClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("com.mopub.mobileads.ViewGestureDetector+IUserClickListenerImplementor, MopubSdk", "", this, new java.lang.Object[] {  });
	}


	public void onResetUserClick ()
	{
		n_onResetUserClick ();
	}

	private native void n_onResetUserClick ();


	public void onUserClick ()
	{
		n_onUserClick ();
	}

	private native void n_onUserClick ();


	public boolean wasClicked ()
	{
		return n_wasClicked ();
	}

	private native boolean n_wasClicked ();

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
