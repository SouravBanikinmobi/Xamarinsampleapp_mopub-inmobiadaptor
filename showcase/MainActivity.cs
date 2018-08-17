using Android.App;
using Android.OS;
using Android.Widget;
using com.mopub.mobileads;
using Com.Inmobi.Ads;
namespace showcase

{
    [Activity(Label = "showcase", MainLauncher = true, Icon ="@mipmap/icon")]
    public class MainActivity : Activity
    {
        MoPubView moPubViewBanner;

        int _count = 1;
        MoPubInterstitial mInterstitial;
        public Button button;
        public Button BannerButton;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            button = FindViewById<Button>(Resource.Id.MyButton);

            BannerButton = FindViewById<Button>(Resource.Id.banner);
            button.Click += Button_Click;
            BannerButton.Click += BannerButton_Click;

            //setup ads

            moPubViewBanner = FindViewById<MoPubView>(Resource.Id.adview_banner);
            moPubViewBanner.Testing = true;
            moPubViewBanner.AdUnitId = Resources.GetString(Resource.String.mopub_ad_id_banner);

            mInterstitial = new MoPubInterstitial(this, "09a914c0486044f3936c85cbbf1bd766");
            mInterstitial.Load();
        }

        void Button_Click(object sender, System.EventArgs e)
        {

            if (mInterstitial.IsReady)
            {

                mInterstitial.Show();

            }
            else
            {

                button.Text = string.Format("{0} clicks!", _count++);
            }


        }

        void BannerButton_Click(object sender, System.EventArgs e)
        {
            moPubViewBanner.LoadAd();
            BannerButton.Text = string.Format("{0} clicks!", _count++);

        }
    }
}

