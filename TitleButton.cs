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
        //Component���擾
        //audioSource = GetComponent<AudioSource>();
    }

    public void PushButton()
    {
        seAudioSource.Play();
      //  AdMobScriptBanner.flag = true;
        AdMobBannerBottom.flag = true;
        SceneManager.LoadScene("Main");//�����ňڂ肽���V�[�����w�肵�܂��B
    }
}