package mono.com.mopub.common;


public class CacheService_DiskLruCacheGetListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.mopub.common.CacheService.DiskLruCacheGetListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onComplete:(Ljava/lang/String;[B)V:GetOnComplete_Ljava_lang_String_arrayBHandler:com.mopub.common.CacheService/IDiskLruCacheGetListenerInvoker, MopubSdk\n" +
			"";
		mono.android.Runtime.register ("com.mopub.common.CacheService+IDiskLruCacheGetListenerImplementor, MopubSdk", CacheService_DiskLruCacheGetListenerImplementor.class, __md_methods);
	}


	public CacheService_DiskLruCacheGetListenerImplementor ()
	{
		super ();
		if (getClass () == CacheService_DiskLruCacheGetListenerImplementor.class)
			mono.android.TypeManager.Activate ("com.mopub.common.CacheService+IDiskLruCacheGetListenerImplementor, MopubSdk", "", this, new java.lang.Object[] {  });
	}


	public void onComplete (java.lang.String p0, byte[] p1)
	{
		n_onComplete (p0, p1);
	}

	private native void n_onComplete (java.lang.String p0, byte[] p1);

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
