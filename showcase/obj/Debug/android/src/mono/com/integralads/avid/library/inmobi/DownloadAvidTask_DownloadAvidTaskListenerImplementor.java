package mono.com.integralads.avid.library.inmobi;


public class DownloadAvidTask_DownloadAvidTaskListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.integralads.avid.library.inmobi.DownloadAvidTask.DownloadAvidTaskListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_failedToLoadAvid:()V:GetFailedToLoadAvidHandler:Com.Integralads.Avid.Library.Inmobi.DownloadAvidTask/IDownloadAvidTaskListenerInvoker, Jars\n" +
			"n_onLoadAvid:(Ljava/lang/String;)V:GetOnLoadAvid_Ljava_lang_String_Handler:Com.Integralads.Avid.Library.Inmobi.DownloadAvidTask/IDownloadAvidTaskListenerInvoker, Jars\n" +
			"";
		mono.android.Runtime.register ("Com.Integralads.Avid.Library.Inmobi.DownloadAvidTask+IDownloadAvidTaskListenerImplementor, Jars", DownloadAvidTask_DownloadAvidTaskListenerImplementor.class, __md_methods);
	}


	public DownloadAvidTask_DownloadAvidTaskListenerImplementor ()
	{
		super ();
		if (getClass () == DownloadAvidTask_DownloadAvidTaskListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Integralads.Avid.Library.Inmobi.DownloadAvidTask+IDownloadAvidTaskListenerImplementor, Jars", "", this, new java.lang.Object[] {  });
	}


	public void failedToLoadAvid ()
	{
		n_failedToLoadAvid ();
	}

	private native void n_failedToLoadAvid ();


	public void onLoadAvid (java.lang.String p0)
	{
		n_onLoadAvid (p0);
	}

	private native void n_onLoadAvid (java.lang.String p0);

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
