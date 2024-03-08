using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using UnityEngine;

using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text scoreText;
    public static int score = 0;
    private int scoreTop;
    private int scoreUnder;
   
   

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
     
        if(score < 1000)
        {
          //  score = 123500;
            scoreText.text = "SCORE:" + score.ToString();
        }
        if (score >= 1000)
        {
            scoreTop = score / 1000;
            scoreUnder = score - (scoreTop * 1000);
            if (scoreUnder >= 100)
            {
                scoreText.text = "SCORE:" + scoreTop.ToString() + "," + scoreUnder.ToString();
            }
            else if (scoreUnder >= 10)
            {
                scoreText.text = "SCORE:" + scoreTop.ToString() + ",0" + scoreUnder.ToString();
            }
            else if (scoreUnder >= 0)
            {
                scoreText.text = "SCORE:" + scoreTop.ToString() + ",00" + scoreUnder.ToString();
            }
        }

    }

}
