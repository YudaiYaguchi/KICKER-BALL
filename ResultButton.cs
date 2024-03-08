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
        //�����ňڂ肽���V�[�����w�肵�܂��B
        //SceneManager.LoadScene("Main");
        seAudioSource.Play();
        MobileAds.Initialize(initStatus => { });
        this.loadInterstitialAd();
        showInterstitialAd();
        AdMobBannerBottom.flag = true;//main scene �ł̃o�i�[�\�����Ȃ�������
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
                  SceneManager.LoadScene("Main");//main��ʂ��Ă�//
                  interstitial.Destroy();
                  return;
              }
              else if (ad == null)
              {
                  SceneManager.LoadScene("Main");//main��ʂ��Ă�
                  // Interstitial ad failed to load.
                  return;
              }
              ad.OnAdFullScreenContentClosed += () => {
                  HandleOnAdClosed();
                  SceneManager.LoadScene("Main");//main��ʂ��Ă�

              };
              ad.OnAdFullScreenContentFailed += (AdError error) =>
              {
                  HandleOnAdClosed();
                  SceneManager.LoadScene("Main");//main��ʂ��Ă�

              };
              interstitial = ad;
          });
    }

    private void HandleOnAdClosed()
    {
        this.interstitial.Destroy();
        this.loadInterstitialAd();
        SceneManager.LoadScene("Main");//main��ʂ��Ă�

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


