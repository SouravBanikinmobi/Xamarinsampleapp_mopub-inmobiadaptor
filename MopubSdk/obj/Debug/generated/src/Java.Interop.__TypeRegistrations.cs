using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/mopub/common",
						"com/mopub/common/event",
						"com/mopub/exceptions",
						"com/mopub/mobileads",
						"com/mopub/volley",
						"com/squareup/picasso",
					},
					new Converter<string, Type>[]{
						lookup_com_mopub_common_package,
						lookup_com_mopub_common_event_package,
						lookup_com_mopub_exceptions_package,
						lookup_com_mopub_mobileads_package,
						lookup_com_mopub_volley_package,
						lookup_com_squareup_picasso_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_mopub_common_mappings;
		static Type lookup_com_mopub_common_package (string klass)
		{
			if (package_com_mopub_common_mappings == null) {
				package_com_mopub_common_mappings = new string[]{
					"com/mopub/common/AdFormat:com.mopub.common.AdFormat",
					"com/mopub/common/AdReport:com.mopub.common.AdReport",
					"com/mopub/common/AdType:com.mopub.common.AdType",
					"com/mopub/common/AdUrlGenerator:com.mopub.common.AdUrlGenerator",
					"com/mopub/common/BaseLifecycleListener:com.mopub.common.BaseLifecycleListener",
					"com/mopub/common/BaseUrlGenerator:com.mopub.common.BaseUrlGenerator",
					"com/mopub/common/CacheService:com.mopub.common.CacheService",
					"com/mopub/common/CacheService$DiskLruCacheGetTask:com.mopub.common.CacheService/DiskLruCacheGetTask",
					"com/mopub/common/CacheService$DiskLruCachePutTask:com.mopub.common.CacheService/DiskLruCachePutTask",
					"com/mopub/common/ClientMetadata:com.mopub.common.ClientMetadata",
					"com/mopub/common/ClientMetadata$MoPubNetworkType:com.mopub.common.ClientMetadata/MoPubNetworkType",
					"com/mopub/common/CloseableLayout:com.mopub.common.CloseableLayout",
					"com/mopub/common/CloseableLayout$ClosePosition:com.mopub.common.CloseableLayout/ClosePosition",
					"com/mopub/common/CloseableLayout$UnsetPressedState:com.mopub.common.CloseableLayout/UnsetPressedState",
					"com/mopub/common/Constants:com.mopub.common.Constants",
					"com/mopub/common/CreativeOrientation:com.mopub.common.CreativeOrientation",
					"com/mopub/common/DataKeys:com.mopub.common.DataKeys",
					"com/mopub/common/DiskLruCache:com.mopub.common.DiskLruCache",
					"com/mopub/common/DiskLruCache$Editor:com.mopub.common.DiskLruCache/Editor",
					"com/mopub/common/DiskLruCache$Editor$FaultHidingOutputStream:com.mopub.common.DiskLruCache/Editor/FaultHidingOutputStream",
					"com/mopub/common/DiskLruCache$Entry:com.mopub.common.DiskLruCache/Entry",
					"com/mopub/common/DiskLruCache$Snapshot:com.mopub.common.DiskLruCache/Snapshot",
					"com/mopub/common/DiskLruCacheUtil:com.mopub.common.DiskLruCacheUtil",
					"com/mopub/common/GpsHelper:com.mopub.common.GpsHelper",
					"com/mopub/common/GpsHelper$AdvertisingInfo:com.mopub.common.GpsHelper/AdvertisingInfo",
					"com/mopub/common/GpsHelper$FetchAdvertisingInfoTask:com.mopub.common.GpsHelper/FetchAdvertisingInfoTask",
					"com/mopub/common/HttpResponses:com.mopub.common.HttpResponses",
					"com/mopub/common/LocationService:com.mopub.common.LocationService",
					"com/mopub/common/LocationService$LocationAwareness:com.mopub.common.LocationService/LocationAwareness",
					"com/mopub/common/MoPub:com.mopub.common.MoPub",
					"com/mopub/common/MoPub$LocationAwareness:com.mopub.common.MoPub/LocationAwareness",
					"com/mopub/common/MoPubBrowser:com.mopub.common.MoPubBrowser",
					"com/mopub/common/MoPubHttpUrlConnection:com.mopub.common.MoPubHttpUrlConnection",
					"com/mopub/common/MoPubLifecycleManager:com.mopub.common.MoPubLifecycleManager",
					"com/mopub/common/MoPubReward:com.mopub.common.MoPubReward",
					"com/mopub/common/Preconditions:com.mopub.common.Preconditions",
					"com/mopub/common/Preconditions$NoThrow:com.mopub.common.Preconditions/NoThrow",
					"com/mopub/common/SharedPreferencesHelper:com.mopub.common.SharedPreferencesHelper",
					"com/mopub/common/UrlAction:com.mopub.common.UrlAction",
					"com/mopub/common/UrlHandler:com.mopub.common.UrlHandler",
					"com/mopub/common/UrlHandler$Builder:com.mopub.common.UrlHandler/Builder",
				};
			}

			return Lookup (package_com_mopub_common_mappings, klass);
		}

		static string[] package_com_mopub_common_event_mappings;
		static Type lookup_com_mopub_common_event_package (string klass)
		{
			if (package_com_mopub_common_event_mappings == null) {
				package_com_mopub_common_event_mappings = new string[]{
					"com/mopub/common/event/BaseEvent:com.mopub.common.events.BaseEvent",
					"com/mopub/common/event/BaseEvent$AppPlatform:com.mopub.common.events.BaseEvent/AppPlatform",
					"com/mopub/common/event/BaseEvent$Builder:com.mopub.common.events.BaseEvent/Builder",
					"com/mopub/common/event/BaseEvent$Category:com.mopub.common.events.BaseEvent/Category",
					"com/mopub/common/event/BaseEvent$Name:com.mopub.common.events.BaseEvent/Name",
					"com/mopub/common/event/BaseEvent$SamplingRate:com.mopub.common.events.BaseEvent/SamplingRate",
					"com/mopub/common/event/BaseEvent$ScribeCategory:com.mopub.common.events.BaseEvent/ScribeCategory",
					"com/mopub/common/event/BaseEvent$SdkProduct:com.mopub.common.events.BaseEvent/SdkProduct",
					"com/mopub/common/event/ErrorEvent:com.mopub.common.events.ErrorEvent",
					"com/mopub/common/event/ErrorEvent$Builder:com.mopub.common.events.ErrorEvent/Builder",
					"com/mopub/common/event/Event:com.mopub.common.events.Event",
					"com/mopub/common/event/Event$Builder:com.mopub.common.events.Event/Builder",
					"com/mopub/common/event/EventDetails:com.mopub.common.events.EventDetails",
					"com/mopub/common/event/EventDetails$Builder:com.mopub.common.events.EventDetails/Builder",
					"com/mopub/common/event/EventDispatcher:com.mopub.common.events.EventDispatcher",
					"com/mopub/common/event/EventSampler:com.mopub.common.events.EventSampler",
					"com/mopub/common/event/MoPubEvents:com.mopub.common.events.MoPubEvents",
					"com/mopub/common/event/ScribeEventRecorder:com.mopub.common.events.ScribeEventRecorder",
					"com/mopub/common/event/ScribeEventRecorder$PollingRunnable:com.mopub.common.events.ScribeEventRecorder/PollingRunnable",
				};
			}

			return Lookup (package_com_mopub_common_event_mappings, klass);
		}

		static string[] package_com_mopub_exceptions_mappings;
		static Type lookup_com_mopub_exceptions_package (string klass)
		{
			if (package_com_mopub_exceptions_mappings == null) {
				package_com_mopub_exceptions_mappings = new string[]{
					"com/mopub/exceptions/IntentNotResolvableException:MoPub.Exceptions.IntentNotResolvableException",
					"com/mopub/exceptions/UrlParseException:MoPub.Exceptions.UrlParseException",
				};
			}

			return Lookup (package_com_mopub_exceptions_mappings, klass);
		}

		static string[] package_com_mopub_mobileads_mappings;
		static Type lookup_com_mopub_mobileads_package (string klass)
		{
			if (package_com_mopub_mobileads_mappings == null) {
				package_com_mopub_mobileads_mappings = new string[]{
					"com/mopub/mobileads/AdAlertGestureListener:com.mopub.mobileads.AdAlertGestureListener",
					"com/mopub/mobileads/AdAlertGestureListener$ZigZagState:com.mopub.mobileads.AdAlertGestureListener/ZigZagState",
					"com/mopub/mobileads/AdAlertReporter:com.mopub.mobileads.AdAlertReporter",
					"com/mopub/mobileads/AdRequestStatusMapping:com.mopub.mobileads.AdRequestStatusMapping",
					"com/mopub/mobileads/AdRequestStatusMapping$AdRequestStatus:com.mopub.mobileads.AdRequestStatusMapping/AdRequestStatus",
					"com/mopub/mobileads/AdRequestStatusMapping$LoadingStatus:com.mopub.mobileads.AdRequestStatusMapping/LoadingStatus",
					"com/mopub/mobileads/AdTypeTranslator:com.mopub.mobileads.AdTypeTranslator",
					"com/mopub/mobileads/AdTypeTranslator$CustomEventType:com.mopub.mobileads.AdTypeTranslator/CustomEventType",
					"com/mopub/mobileads/AdViewController:com.mopub.mobileads.AdViewController",
					"com/mopub/mobileads/BaseHtmlWebView:com.mopub.mobileads.BaseHtmlWebView",
					"com/mopub/mobileads/BaseInterstitialActivity:com.mopub.mobileads.BaseInterstitialActivity",
					"com/mopub/mobileads/BaseInterstitialActivity$JavaScriptWebViewCallbacks:com.mopub.mobileads.BaseInterstitialActivity/JavaScriptWebViewCallbacks",
					"com/mopub/mobileads/BaseVideoPlayerActivity:com.mopub.mobileads.BaseVideoPlayerActivity",
					"com/mopub/mobileads/BaseVideoViewController:com.mopub.mobileads.BaseVideoViewController",
					"com/mopub/mobileads/BaseWebView:com.mopub.mobileads.BaseWebView",
					"com/mopub/mobileads/BuildConfig:com.mopub.mobileads.BuildConfig",
					"com/mopub/mobileads/CustomEventBanner:com.mopub.mobileads.CustomEventBanner",
					"com/mopub/mobileads/CustomEventBannerAdapter:com.mopub.mobileads.CustomEventBannerAdapter",
					"com/mopub/mobileads/CustomEventInterstitial:com.mopub.mobileads.CustomEventInterstitial",
					"com/mopub/mobileads/CustomEventInterstitialAdapter:com.mopub.mobileads.CustomEventInterstitialAdapter",
					"com/mopub/mobileads/CustomEventRewardedVideo:com.mopub.mobileads.CustomEventRewardedVideo",
					"com/mopub/mobileads/DefaultBannerAdListener:com.mopub.mobileads.DefaultBannerAdListener",
					"com/mopub/mobileads/DefaultInterstitialAdListener:com.mopub.mobileads.DefaultInterstitialAdListener",
					"com/mopub/mobileads/EventForwardingBroadcastReceiver:com.mopub.mobileads.EventForwardingBroadcastReceiver",
					"com/mopub/mobileads/FacebookKeywordProvider:com.mopub.mobileads.FacebookKeywordProvider",
					"com/mopub/mobileads/HtmlBannerWebView:com.mopub.mobileads.HtmlBannerWebView",
					"com/mopub/mobileads/HtmlBannerWebView$HtmlBannerWebViewListener:com.mopub.mobileads.HtmlBannerWebView/HtmlBannerWebViewListener",
					"com/mopub/mobileads/HtmlInterstitialWebView:com.mopub.mobileads.HtmlInterstitialWebView",
					"com/mopub/mobileads/HtmlInterstitialWebView$HtmlInterstitialWebViewListener:com.mopub.mobileads.HtmlInterstitialWebView/HtmlInterstitialWebViewListener",
					"com/mopub/mobileads/MoPubActivity:com.mopub.mobileads.MoPubActivity",
					"com/mopub/mobileads/MoPubActivity$BroadcastingInterstitialListener:com.mopub.mobileads.MoPubActivity/BroadcastingInterstitialListener",
					"com/mopub/mobileads/MoPubConversionTracker:com.mopub.mobileads.MoPubConversionTracker",
					"com/mopub/mobileads/MoPubConversionTracker$ConversionUrlGenerator:com.mopub.mobileads.MoPubConversionTracker/ConversionUrlGenerator",
					"com/mopub/mobileads/MoPubErrorCode:com.mopub.mobileads.MoPubErrorCode",
					"com/mopub/mobileads/MoPubInterstitial:com.mopub.mobileads.MoPubInterstitial",
					"com/mopub/mobileads/MoPubInterstitial$InterstitialState:com.mopub.mobileads.MoPubInterstitial/InterstitialState",
					"com/mopub/mobileads/MoPubInterstitial$MoPubInterstitialView:com.mopub.mobileads.MoPubInterstitial/MoPubInterstitialView",
					"com/mopub/mobileads/MoPubRewardedVideoManager:com.mopub.mobileads.MoPubRewardedVideoManager",
					"com/mopub/mobileads/MoPubRewardedVideoManager$ForEachMoPubIdRunnable:com.mopub.mobileads.MoPubRewardedVideoManager/ForEachMoPubIdRunnable",
					"com/mopub/mobileads/MoPubRewardedVideoManager$RewardedVideoRequestListener:com.mopub.mobileads.MoPubRewardedVideoManager/RewardedVideoRequestListener",
					"com/mopub/mobileads/MoPubView:com.mopub.mobileads.MoPubView",
					"com/mopub/mobileads/MraidVideoPlayerActivity:com.mopub.mobileads.MraidVideoPlayerActivity",
					"com/mopub/mobileads/RepeatingHandlerRunnable:com.mopub.mobileads.RepeatingHandlerRunnable",
					"com/mopub/mobileads/VideoViewabilityTrackerXmlManager:com.mopub.mobileads.VideoViewabilityTrackerXmlManager",
					"com/mopub/mobileads/ViewGestureDetector:com.mopub.mobileads.ViewGestureDetector",
					"com/mopub/mobileads/WebViewAdUrlGenerator:com.mopub.mobileads.WebViewAdUrlGenerator",
				};
			}

			return Lookup (package_com_mopub_mobileads_mappings, klass);
		}

		static string[] package_com_mopub_volley_mappings;
		static Type lookup_com_mopub_volley_package (string klass)
		{
			if (package_com_mopub_volley_mappings == null) {
				package_com_mopub_volley_mappings = new string[]{
					"com/mopub/volley/AuthFailureError:MoPub.Volley.AuthFailureError",
					"com/mopub/volley/BuildConfig:MoPub.Volley.BuildConfig",
					"com/mopub/volley/Cache$Entry:MoPub.Volley.CacheEntry",
					"com/mopub/volley/CacheDispatcher:MoPub.Volley.CacheDispatcher",
					"com/mopub/volley/DefaultRetryPolicy:MoPub.Volley.DefaultRetryPolicy",
					"com/mopub/volley/ExecutorDelivery:MoPub.Volley.ExecutorDelivery",
					"com/mopub/volley/ExecutorDelivery$ResponseDeliveryRunnable:MoPub.Volley.ExecutorDelivery/ResponseDeliveryRunnable",
					"com/mopub/volley/NetworkDispatcher:MoPub.Volley.NetworkDispatcher",
					"com/mopub/volley/NetworkError:MoPub.Volley.NetworkError",
					"com/mopub/volley/NetworkResponse:MoPub.Volley.NetworkResponse",
					"com/mopub/volley/NoConnectionError:MoPub.Volley.NoConnectionError",
					"com/mopub/volley/ParseError:MoPub.Volley.ParseError",
					"com/mopub/volley/Request:MoPub.Volley.Request",
					"com/mopub/volley/Request$Priority:MoPub.Volley.Request/Priority",
					"com/mopub/volley/RequestQueue:MoPub.Volley.RequestQueue",
					"com/mopub/volley/Response:MoPub.Volley.Response",
					"com/mopub/volley/ServerError:MoPub.Volley.ServerError",
					"com/mopub/volley/TimeoutError:MoPub.Volley.TimeoutError",
					"com/mopub/volley/VolleyError:MoPub.Volley.VolleyError",
					"com/mopub/volley/VolleyLog:MoPub.Volley.VolleyLog",
					"com/mopub/volley/VolleyLog$MarkerLog:MoPub.Volley.VolleyLog/MarkerLog",
					"com/mopub/volley/VolleyLog$MarkerLog$Marker:MoPub.Volley.VolleyLog/MarkerLog/Marker",
				};
			}

			return Lookup (package_com_mopub_volley_mappings, klass);
		}

		static string[] package_com_squareup_picasso_mappings;
		static Type lookup_com_squareup_picasso_package (string klass)
		{
			if (package_com_squareup_picasso_mappings == null) {
				package_com_squareup_picasso_mappings = new string[]{
					"com/squareup/picasso/Callback$EmptyCallback:Com.Squareup.Picasso.CallbackEmptyCallback",
					"com/squareup/picasso/Downloader$Response:Com.Squareup.Picasso.DownloaderResponse",
					"com/squareup/picasso/Downloader$ResponseException:Com.Squareup.Picasso.DownloaderResponseException",
				};
			}

			return Lookup (package_com_squareup_picasso_mappings, klass);
		}
	}
}
