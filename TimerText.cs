using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimerText : MonoBehaviour
{
    public Text timerText;
    public static float timer = 60;
    [SerializeField]
    AudioSource seAudioSource;
    private bool flag = false;
    private int count = 1;  

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.score = 0;
        timer = 60;
        count = 1;
        flag = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
        {
            timer -= Time.deltaTime;
            timerText.text = "TIME:" + timer.ToString("F0");
            if(timer <= 5 && count == 1)
            {
                flag = true;
                count = 0;

            }
            if (flag)
            {
                InvokeRepeating("AudioPlay", 0f, 0.25f);
                flag = false;   
            }
        }
        if(timer <= 1)
        {
            AdMobBannerLeft.flag = true;

        }
        if (timer <= 0)
        {
            SceneManager.LoadScene("Result");

        }
    }

    void AudioPlay()
    {      
       seAudioSource.Play();
       if(timer <= 0 || timer > 5){
            CancelInvoke();
            count = 1;
        }
    }
}
