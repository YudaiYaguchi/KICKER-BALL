using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TitleButton : MonoBehaviour
{
    [SerializeField]
    AudioSource seAudioSource;

    void Start()
    {
        //Componentを取得
        //audioSource = GetComponent<AudioSource>();
    }

    public void PushButton()
    {
        seAudioSource.Play();
      //  AdMobScriptBanner.flag = true;
        AdMobBannerBottom.flag = true;
        SceneManager.LoadScene("Main");//ここで移りたいシーンを指定します。
    }
}