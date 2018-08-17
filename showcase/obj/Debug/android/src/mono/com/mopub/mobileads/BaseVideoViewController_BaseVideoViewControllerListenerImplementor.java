package mono.com.mopub.mobileads;


public class BaseVideoViewController_BaseVideoViewControllerListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mopub.mobileads.BaseVideoViewController.BaseVideoViewControllerListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFinish:()V:GetOnFinishHandler:com.mopub.mobileads.BaseVideoViewController/IBaseVideoViewControllerListenerInvoker, MopubSdk\n" +
			"n_onSetContentView:(Landroid/view/View;)V:GetOnSetContentView_Landroid_view_View_Handler:com.mopub.mobileads.BaseVideoViewController/IBaseVideoViewControllerListenerInvoker, MopubSdk\n" +
			"n_onSetRequestedOrientation:(I)V:GetOnSetRequestedOrientation_IHandler:com.mopub.mobileads.BaseVideoViewController/IBaseVideoViewControllerListenerInvoker, MopubSdk\n" +
			"n_onStartActivityForResult:(Ljava/lang/Class;ILandroid/os/Bundle;)V:GetOnStartActivityForResult_Ljava_lang_Class_ILandroid_os_Bundle_Handler:com.mopub.mobileads.BaseVideoViewController/IBaseVideoViewControllerListenerInvoker, MopubSdk\n" +
			"";
		mono.android.Runtime.register ("com.mopub.mobileads.BaseVideoViewController+IBaseVideoViewControllerListenerImplementor, MopubSdk", BaseVideoViewController_BaseVideoViewControllerListenerImplementor.class, __md_methods);
	}


	public BaseVideoViewController_BaseVideoViewControllerListenerImplementor ()
	{
		super ();
		if (getClass () == BaseVideoViewController_BaseVideoViewControllerListenerImplementor.class)
			mono.android.TypeManager.Activate ("com.mopub.mobileads.BaseVideoViewController+IBaseVideoViewControllerListenerImplementor, MopubSdk", "", this, new java.lang.Object[] {  });
	}


	public void onFinish ()
	{
		n_onFinish ();
	}

	private native void n_onFinish ();


	public void onSetContentView (android.view.View p0)
	{
		n_onSetContentView (p0);
	}

	private native void n_onSetContentView (android.view.View p0);


	public void onSetRequestedOrientation (int p0)
	{
		n_onSetRequestedOrientation (p0);
	}

	private native void n_onSetRequestedOrientation (int p0);


	public void onStartActivityForResult (java.lang.Class p0, int p1, android.os.Bundle p2)
	{
		n_onStartActivityForResult (p0, p1, p2);
	}

	private native void n_onStartActivityForResult (java.lang.Class p0, int p1, android.os.Bundle p2);

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
