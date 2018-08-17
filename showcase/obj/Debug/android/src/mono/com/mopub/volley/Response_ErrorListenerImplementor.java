package mono.com.mopub.volley;


public class Response_ErrorListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mopub.volley.Response.ErrorListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onErrorResponse:(Lcom/mopub/volley/VolleyError;)V:GetOnErrorResponse_Lcom_mopub_volley_VolleyError_Handler:MoPub.Volley.Response/IErrorListenerInvoker, MopubSdk\n" +
			"";
		mono.android.Runtime.register ("MoPub.Volley.Response+IErrorListenerImplementor, MopubSdk", Response_ErrorListenerImplementor.class, __md_methods);
	}


	public Response_ErrorListenerImplementor ()
	{
		super ();
		if (getClass () == Response_ErrorListenerImplementor.class)
			mono.android.TypeManager.Activate ("MoPub.Volley.Response+IErrorListenerImplementor, MopubSdk", "", this, new java.lang.Object[] {  });
	}


	public void onErrorResponse (com.mopub.volley.VolleyError p0)
	{
		n_onErrorResponse (p0);
	}

	private native void n_onErrorResponse (com.mopub.volley.VolleyError p0);

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
