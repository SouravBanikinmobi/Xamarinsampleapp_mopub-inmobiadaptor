package mono.com.mopub.common;


public class LifecycleListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mopub.common.LifecycleListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBackPressed:(Landroid/app/Activity;)V:GetOnBackPressed_Landroid_app_Activity_Handler:com.mopub.common.ILifecycleListenerInvoker, MopubSdk\n" +
			"n_onCreate:(Landroid/app/Activity;)V:GetOnCreate_Landroid_app_Activity_Handler:com.mopub.common.ILifecycleListenerInvoker, MopubSdk\n" +
			"n_onDestroy:(Landroid/app/Activity;)V:GetOnDestroy_Landroid_app_Activity_Handler:com.mopub.common.ILifecycleListenerInvoker, MopubSdk\n" +
			"n_onPause:(Landroid/app/Activity;)V:GetOnPause_Landroid_app_Activity_Handler:com.mopub.common.ILifecycleListenerInvoker, MopubSdk\n" +
			"n_onRestart:(Landroid/app/Activity;)V:GetOnRestart_Landroid_app_Activity_Handler:com.mopub.common.ILifecycleListenerInvoker, MopubSdk\n" +
			"n_onResume:(Landroid/app/Activity;)V:GetOnResume_Landroid_app_Activity_Handler:com.mopub.common.ILifecycleListenerInvoker, MopubSdk\n" +
			"n_onStart:(Landroid/app/Activity;)V:GetOnStart_Landroid_app_Activity_Handler:com.mopub.common.ILifecycleListenerInvoker, MopubSdk\n" +
			"n_onStop:(Landroid/app/Activity;)V:GetOnStop_Landroid_app_Activity_Handler:com.mopub.common.ILifecycleListenerInvoker, MopubSdk\n" +
			"";
		mono.android.Runtime.register ("com.mopub.common.ILifecycleListenerImplementor, MopubSdk", LifecycleListenerImplementor.class, __md_methods);
	}


	public LifecycleListenerImplementor ()
	{
		super ();
		if (getClass () == LifecycleListenerImplementor.class)
			mono.android.TypeManager.Activate ("com.mopub.common.ILifecycleListenerImplementor, MopubSdk", "", this, new java.lang.Object[] {  });
	}


	public void onBackPressed (android.app.Activity p0)
	{
		n_onBackPressed (p0);
	}

	private native void n_onBackPressed (android.app.Activity p0);


	public void onCreate (android.app.Activity p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.app.Activity p0);


	public void onDestroy (android.app.Activity p0)
	{
		n_onDestroy (p0);
	}

	private native void n_onDestroy (android.app.Activity p0);


	public void onPause (android.app.Activity p0)
	{
		n_onPause (p0);
	}

	private native void n_onPause (android.app.Activity p0);


	public void onRestart (android.app.Activity p0)
	{
		n_onRestart (p0);
	}

	private native void n_onRestart (android.app.Activity p0);


	public void onResume (android.app.Activity p0)
	{
		n_onResume (p0);
	}

	private native void n_onResume (android.app.Activity p0);


	public void onStart (android.app.Activity p0)
	{
		n_onStart (p0);
	}

	private native void n_onStart (android.app.Activity p0);


	public void onStop (android.app.Activity p0)
	{
		n_onStop (p0);
	}

	private native void n_onStop (android.app.Activity p0);

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
