package mono.com.mopub.volley;


public class Response_ListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mopub.volley.Response.Listener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onResponse:(Ljava/lang/Object;)V:GetOnResponse_Ljava_lang_Object_Handler:MoPub.Volley.Response/IListenerInvoker, MopubSdk\n" +
			"";
		mono.android.Runtime.register ("MoPub.Volley.Response+IListenerImplementor, MopubSdk", Response_ListenerImplementor.class, __md_methods);
	}


	public Response_ListenerImplementor ()
	{
		super ();
		if (getClass () == Response_ListenerImplementor.class)
			mono.android.TypeManager.Activate ("MoPub.Volley.Response+IListenerImplementor, MopubSdk", "", this, new java.lang.Object[] {  });
	}


	public void onResponse (java.lang.Object p0)
	{
		n_onResponse (p0);
	}

	private native void n_onResponse (java.lang.Object p0);

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
