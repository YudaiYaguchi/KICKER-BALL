using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class AdMobBannerBottom : MonoBehaviour
{
    private BannerView bannerView;
    public static bool flag = false;

    public void Start()
    {
        // Google AdMob Initial
        MobileAds.Initialize(initStatus => { });
        this.RequestBanner();
    }
    void Update()
    {
        if (flag)
        {
            this.bannerView.Destroy();
            flag = false;
        }
    }

    private void RequestBanner()
    {
#if UNITY_ANDROID
    string adUnitId = "ca-app-pub-4884717140079444/3987393576"; // テスト用広告ユニットID
#elif UNITY_IPHONE
    string adUnitId = "ca-app-pub-4884717140079444/3987393576"; // テスト用広告ユニットID
#else
        string adUnitId = "unexpected_platform";
#endif
        // Create a 320x50 banner at the bottom of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

        // Create an empty ad request.
        AdRequest request = new AdRequest();
        // Load the banner with the request.
        bannerView.LoadAd(request);



    }
}
