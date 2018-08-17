package mono.com.mopub.mobileads;


public class MoPubRewardedVideoListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mopub.mobileads.MoPubRewardedVideoListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onRewardedVideoClosed:(Ljava/lang/String;)V:GetOnRewardedVideoClosed_Ljava_lang_String_Handler:com.mopub.mobileads.IMoPubRewardedVideoListenerInvoker, MopubSdk\n" +
			"n_onRewardedVideoCompleted:(Ljava/util/Set;Lcom/mopub/common/MoPubReward;)V:GetOnRewardedVideoCompleted_Ljava_util_Set_Lcom_mopub_common_MoPubReward_Handler:com.mopub.mobileads.IMoPubRewardedVideoListenerInvoker, MopubSdk\n" +
			"n_onRewardedVideoLoadFailure:(Ljava/lang/String;Lcom/mopub/mobileads/MoPubErrorCode;)V:GetOnRewardedVideoLoadFailure_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_Handler:com.mopub.mobileads.IMoPubRewardedVideoListenerInvoker, MopubSdk\n" +
			"n_onRewardedVideoLoadSuccess:(Ljava/lang/String;)V:GetOnRewardedVideoLoadSuccess_Ljava_lang_String_Handler:com.mopub.mobileads.IMoPubRewardedVideoListenerInvoker, MopubSdk\n" +
			"n_onRewardedVideoPlaybackError:(Ljava/lang/String;Lcom/mopub/mobileads/MoPubErrorCode;)V:GetOnRewardedVideoPlaybackError_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_Handler:com.mopub.mobileads.IMoPubRewardedVideoListenerInvoker, MopubSdk\n" +
			"n_onRewardedVideoStarted:(Ljava/lang/String;)V:GetOnRewardedVideoStarted_Ljava_lang_String_Handler:com.mopub.mobileads.IMoPubRewardedVideoListenerInvoker, MopubSdk\n" +
			"";
		mono.android.Runtime.register ("com.mopub.mobileads.IMoPubRewardedVideoListenerImplementor, MopubSdk", MoPubRewardedVideoListenerImplementor.class, __md_methods);
	}


	public MoPubRewardedVideoListenerImplementor ()
	{
		super ();
		if (getClass () == MoPubRewardedVideoListenerImplementor.class)
			mono.android.TypeManager.Activate ("com.mopub.mobileads.IMoPubRewardedVideoListenerImplementor, MopubSdk", "", this, new java.lang.Object[] {  });
	}


	public void onRewardedVideoClosed (java.lang.String p0)
	{
		n_onRewardedVideoClosed (p0);
	}

	private native void n_onRewardedVideoClosed (java.lang.String p0);


	public void onRewardedVideoCompleted (java.util.Set p0, com.mopub.common.MoPubReward p1)
	{
		n_onRewardedVideoCompleted (p0, p1);
	}

	private native void n_onRewardedVideoCompleted (java.util.Set p0, com.mopub.common.MoPubReward p1);


	public void onRewardedVideoLoadFailure (java.lang.String p0, com.mopub.mobileads.MoPubErrorCode p1)
	{
		n_onRewardedVideoLoadFailure (p0, p1);
	}

	private native void n_onRewardedVideoLoadFailure (java.lang.String p0, com.mopub.mobileads.MoPubErrorCode p1);


	public void onRewardedVideoLoadSuccess (java.lang.String p0)
	{
		n_onRewardedVideoLoadSuccess (p0);
	}

	private native void n_onRewardedVideoLoadSuccess (java.lang.String p0);


	public void onRewardedVideoPlaybackError (java.lang.String p0, com.mopub.mobileads.MoPubErrorCode p1)
	{
		n_onRewardedVideoPlaybackError (p0, p1);
	}

	private native void n_onRewardedVideoPlaybackError (java.lang.String p0, com.mopub.mobileads.MoPubErrorCode p1);


	public void onRewardedVideoStarted (java.lang.String p0)
	{
		n_onRewardedVideoStarted (p0);
	}

	private native void n_onRewardedVideoStarted (java.lang.String p0);

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
