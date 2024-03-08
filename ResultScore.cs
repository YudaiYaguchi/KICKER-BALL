using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResultScore : MonoBehaviour
{
    public TextMeshProUGUI scoreTextResult;
   // public Text scoreTextResult;
    private int scoreTop;
    private int scoreUnder;
    private int flag = 1;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        flag = 1;
        TimerText.timer = 0;
       // ScoreText.score = 100000;
    }

    // Update is called once per frame
    void Update()
    {

        if (TimerText.timer <= 0 && flag == 1)//Result‰æ–Ê‚ÌÝ’è
        {
        //    Debug.Log("TimerText.timer <= 0");
            flag = 0;
            InvokeRepeating("Result", 0f, 0.01f);
           
        }

    }

    void Result()
    {
      //  Debug.Log("Result()‚ªŒÄ‚Ño‚³‚ê‚Ü‚µ‚½");
        
        if (count < 1000)
        {
            if (count >= ScoreText.score)
            {
                scoreTextResult.text =   "   " +ScoreText.score.ToString();
            }
            else
            {
                // Debug.Log("count<1000");
                scoreTextResult.text = "   "+ count.ToString();
            }
        }
        if (count >= 1000)
        {
            //Debug.Log("count>=1000");
            if (count < ScoreText.score)
            {
                scoreTop = count / 1000;
                scoreUnder = count - (scoreTop * 1000);
            }else if(count >= ScoreText.score){
               
                scoreTop = ScoreText.score / 1000;
                scoreUnder = ScoreText.score - (scoreTop * 1000);
            }



            if (scoreUnder >= 100)
            {
                if (scoreTop >= 100)
                {
                    scoreTextResult.text = scoreTop.ToString() + "," + scoreUnder.ToString();
                }else if (scoreTop >= 10)
                {
                    scoreTextResult.text = " " + scoreTop.ToString() + "," + scoreUnder.ToString();
                }
                else if(scoreTop >= 0)
                {
                    scoreTextResult.text = "  " + scoreTop.ToString() + "," + scoreUnder.ToString();

                }
            }
            else if (scoreUnder >= 10)
            {
                if (scoreTop >= 100)
                {
                    scoreTextResult.text = scoreTop.ToString() + ",0" + scoreUnder.ToString();
                }
                else if (scoreTop >= 10)
                {
                    scoreTextResult.text = " " + scoreTop.ToString() + ",0" + scoreUnder.ToString();
                }
                else if (scoreTop >= 0)
                {
                    scoreTextResult.text = "  " + scoreTop.ToString() + ",0" + scoreUnder.ToString();

                }
               
            }
            else if (scoreUnder >= 0)
            {
                if (scoreTop >= 100)
                {
                    scoreTextResult.text = scoreTop.ToString() + ",00" + scoreUnder.ToString();
                }
                else if (scoreTop >= 10)
                {
                    scoreTextResult.text = " " + scoreTop.ToString() + ",00" + scoreUnder.ToString();
                }
                else if (scoreTop >= 0)
                {
                    scoreTextResult.text = "  " + scoreTop.ToString() + ",00" + scoreUnder.ToString();

                }
              
            }
        }
        if (count >= ScoreText.score)
        {
            EndSE.scoreMaxFlag = 1;
            Debug.Log("CancelInvoke()");
            CancelInvoke();
        }
        else
        {
            count += 100;
        }
    }
}
