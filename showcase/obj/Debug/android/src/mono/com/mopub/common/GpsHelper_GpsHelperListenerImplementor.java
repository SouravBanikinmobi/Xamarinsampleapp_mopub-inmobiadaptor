package mono.com.mopub.common;


public class GpsHelper_GpsHelperListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mopub.common.GpsHelper.GpsHelperListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFetchAdInfoCompleted:()V:GetOnFetchAdInfoCompletedHandler:com.mopub.common.GpsHelper/IGpsHelperListenerInvoker, MopubSdk\n" +
			"";
		mono.android.Runtime.register ("com.mopub.common.GpsHelper+IGpsHelperListenerImplementor, MopubSdk", GpsHelper_GpsHelperListenerImplementor.class, __md_methods);
	}


	public GpsHelper_GpsHelperListenerImplementor ()
	{
		super ();
		if (getClass () == GpsHelper_GpsHelperListenerImplementor.class)
			mono.android.TypeManager.Activate ("com.mopub.common.GpsHelper+IGpsHelperListenerImplementor, MopubSdk", "", this, new java.lang.Object[] {  });
	}


	public void onFetchAdInfoCompleted ()
	{
		n_onFetchAdInfoCompleted ();
	}

	private native void n_onFetchAdInfoCompleted ();

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
