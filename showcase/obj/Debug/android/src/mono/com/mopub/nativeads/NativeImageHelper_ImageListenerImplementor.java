package mono.com.mopub.nativeads;


public class NativeImageHelper_ImageListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mopub.nativeads.NativeImageHelper.ImageListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onImagesCached:()V:GetOnImagesCachedHandler:Com.Mopub.Nativeads.NativeImageHelper/IImageListenerInvoker, MopubSdk\n" +
			"n_onImagesFailedToCache:(Lcom/mopub/nativeads/NativeErrorCode;)V:GetOnImagesFailedToCache_Lcom_mopub_nativeads_NativeErrorCode_Handler:Com.Mopub.Nativeads.NativeImageHelper/IImageListenerInvoker, MopubSdk\n" +
			"";
		mono.android.Runtime.register ("Com.Mopub.Nativeads.NativeImageHelper+IImageListenerImplementor, MopubSdk", NativeImageHelper_ImageListenerImplementor.class, __md_methods);
	}


	public NativeImageHelper_ImageListenerImplementor ()
	{
		super ();
		if (getClass () == NativeImageHelper_ImageListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Mopub.Nativeads.NativeImageHelper+IImageListenerImplementor, MopubSdk", "", this, new java.lang.Object[] {  });
	}


	public void onImagesCached ()
	{
		n_onImagesCached ();
	}

	private native void n_onImagesCached ();


	public void onImagesFailedToCache (com.mopub.nativeads.NativeErrorCode p0)
	{
		n_onImagesFailedToCache (p0);
	}

	private native void n_onImagesFailedToCache (com.mopub.nativeads.NativeErrorCode p0);

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
