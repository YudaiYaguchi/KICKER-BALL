using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class ResultButton : MonoBehaviour
{
    [SerializeField]
    AudioSource seAudioSource;

    private InterstitialAd interstitial;


    public void PushButton()
    {
        //ここで移りたいシーンを指定します。
        //SceneManager.LoadScene("Main");
        seAudioSource.Play();
        MobileAds.Initialize(initStatus => { });
        this.loadInterstitialAd();
        showInterstitialAd();
        AdMobBannerBottom.flag = true;//main scene でのバナー表示をなくすため
    }


    public void loadInterstitialAd()
    {

#if UNITY_ANDROID
    string adUnitId = "ca-app-pub-4884717140079444/7896571195";
#elif UNITY_IPHONE
    string adUnitId = "ca-app-pub-4884717140079444/7896571195";
#else
        string adUnitId = "unexpected_platform";
#endif

        InterstitialAd.Load(adUnitId, new AdRequest(),
          (InterstitialAd ad, LoadAdError loadAdError) =>
          {
              if (loadAdError != null)
              {
                  // Interstitial ad failed to load with error
                  SceneManager.LoadScene("Main");//main画面を呼ぶ//
                  interstitial.Destroy();
                  return;
              }
              else if (ad == null)
              {
                  SceneManager.LoadScene("Main");//main画面を呼ぶ
                  // Interstitial ad failed to load.
                  return;
              }
              ad.OnAdFullScreenContentClosed += () => {
                  HandleOnAdClosed();
                  SceneManager.LoadScene("Main");//main画面を呼ぶ

              };
              ad.OnAdFullScreenContentFailed += (AdError error) =>
              {
                  HandleOnAdClosed();
                  SceneManager.LoadScene("Main");//main画面を呼ぶ

              };
              interstitial = ad;
          });
    }

    private void HandleOnAdClosed()
    {
        this.interstitial.Destroy();
        this.loadInterstitialAd();
        SceneManager.LoadScene("Main");//main画面を呼ぶ

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


