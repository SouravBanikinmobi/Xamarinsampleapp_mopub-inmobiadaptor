package mono.com.mopub.mobileads;


public class CustomEventBanner_CustomEventBannerListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mopub.mobileads.CustomEventBanner.CustomEventBannerListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBannerClicked:()V:GetOnBannerClickedHandler:com.mopub.mobileads.CustomEventBanner/ICustomEventBannerListenerInvoker, MopubSdk\n" +
			"n_onBannerCollapsed:()V:GetOnBannerCollapsedHandler:com.mopub.mobileads.CustomEventBanner/ICustomEventBannerListenerInvoker, MopubSdk\n" +
			"n_onBannerExpanded:()V:GetOnBannerExpandedHandler:com.mopub.mobileads.CustomEventBanner/ICustomEventBannerListenerInvoker, MopubSdk\n" +
			"n_onBannerFailed:(Lcom/mopub/mobileads/MoPubErrorCode;)V:GetOnBannerFailed_Lcom_mopub_mobileads_MoPubErrorCode_Handler:com.mopub.mobileads.CustomEventBanner/ICustomEventBannerListenerInvoker, MopubSdk\n" +
			"n_onBannerLoaded:(Landroid/view/View;)V:GetOnBannerLoaded_Landroid_view_View_Handler:com.mopub.mobileads.CustomEventBanner/ICustomEventBannerListenerInvoker, MopubSdk\n" +
			"n_onLeaveApplication:()V:GetOnLeaveApplicationHandler:com.mopub.mobileads.CustomEventBanner/ICustomEventBannerListenerInvoker, MopubSdk\n" +
			"";
		mono.android.Runtime.register ("com.mopub.mobileads.CustomEventBanner+ICustomEventBannerListenerImplementor, MopubSdk", CustomEventBanner_CustomEventBannerListenerImplementor.class, __md_methods);
	}


	public CustomEventBanner_CustomEventBannerListenerImplementor ()
	{
		super ();
		if (getClass () == CustomEventBanner_CustomEventBannerListenerImplementor.class)
			mono.android.TypeManager.Activate ("com.mopub.mobileads.CustomEventBanner+ICustomEventBannerListenerImplementor, MopubSdk", "", this, new java.lang.Object[] {  });
	}


	public void onBannerClicked ()
	{
		n_onBannerClicked ();
	}

	private native void n_onBannerClicked ();


	public void onBannerCollapsed ()
	{
		n_onBannerCollapsed ();
	}

	private native void n_onBannerCollapsed ();


	public void onBannerExpanded ()
	{
		n_onBannerExpanded ();
	}

	private native void n_onBannerExpanded ();


	public void onBannerFailed (com.mopub.mobileads.MoPubErrorCode p0)
	{
		n_onBannerFailed (p0);
	}

	private native void n_onBannerFailed (com.mopub.mobileads.MoPubErrorCode p0);


	public void onBannerLoaded (android.view.View p0)
	{
		n_onBannerLoaded (p0);
	}

	private native void n_onBannerLoaded (android.view.View p0);


	public void onLeaveApplication ()
	{
		n_onLeaveApplication ();
	}

	private native void n_onLeaveApplication ();

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
