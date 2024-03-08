using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdMobScript : MonoBehaviour
{
    private BannerView bannerView;
    private InterstitialAd interstitial;

    public void Start()
    {

        // Google AdMob Initial
        MobileAds.Initialize(initStatus => { });

        this.loadInterstitialAd();
    }

 
        public void loadInterstitialAd()
        {

#if UNITY_ANDROID
    string adUnitId = "ca-app-pub-3940256099942544/1033173712";
#elif UNITY_IPHONE
    string adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
            string adUnitId = "unexpected_platform";
#endif

            InterstitialAd.Load(adUnitId, new AdRequest(),
              (InterstitialAd ad, LoadAdError loadAdError) =>
              {
                  if (loadAdError != null)
                  {
                      // Interstitial ad failed to load with error
                      interstitial.Destroy();
                      return;
                  }
                  else if (ad == null)
                  {
                      // Interstitial ad failed to load.
                      return;
                  }
                  ad.OnAdFullScreenContentClosed += () => {
                      HandleOnAdClosed();
                  };
                  ad.OnAdFullScreenContentFailed += (AdError error) =>
                  {
                      HandleOnAdClosed();
                  };
                  interstitial = ad;
              });
        }

        private void HandleOnAdClosed()
        {
            this.interstitial.Destroy();
            this.loadInterstitialAd();
        }

        public void showInterstitialAd()
        {
            if (interstitial != null && interstitial.CanShowAd())
            {
                interstitial.Show();
            }
            else
            {
                Debug.Log("Interstitial Ad not load");
            }
        }
  

}