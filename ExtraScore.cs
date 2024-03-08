using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ExtraScore : MonoBehaviour
{
    public TextMeshProUGUI extraScoreText;
    public TextMeshProUGUI goldText;
    public static int extraScoreFlag = 0;
    public static int goldScoreFlag = 0;
    public static int extraScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        OffDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        if (extraScoreFlag ==1 && goldScoreFlag == 1)
        {
            OnDisplayGold();
            extraScoreFlag = 0; 
            goldScoreFlag = 0;  
        }else if (extraScoreFlag == 1)
        {
            OnDisplay();
            extraScoreFlag = 0;
        
        }
    }

    void OnDisplayGold()
    {
        if (ScoreText.score >= 100000)
        {
            if (extraScore >= 1000)
            {
                goldText.text = "      ~2";
                extraScoreText.text = "    +" + extraScore;
                Invoke("OffDisplay", 0.75f);
            }
            else
            {
                goldText.text = "     ~2";
                extraScoreText.text = "    +" + extraScore;
                Invoke("OffDisplay", 0.75f);
            }
        }else if (ScoreText.score >= 10000)
        {
            if (extraScore >= 1000)
            {
                goldText.text = "     ~2";
                extraScoreText.text = "    +" + extraScore;
                Invoke("OffDisplay", 0.75f);
            }
            else
            {
                goldText.text = "    ~2";
                extraScoreText.text = "    +" + extraScore;
                Invoke("OffDisplay", 0.75f);
            }
        }
        else if (ScoreText.score >= 1000)
        {
            if (extraScore >= 1000)
            {
                goldText.text = "   ~2";
                extraScoreText.text = "  +" + extraScore;
                Invoke("OffDisplay", 0.75f);
            }
            else
            {
                goldText.text = "  ~2";
                extraScoreText.text = "  +" + extraScore;
                Invoke("OffDisplay", 0.75f);
            }
        }
        else if (ScoreText.score >= 100)
        {
            if (extraScore >= 1000)
            {
                goldText.text = " ~2";
                extraScoreText.text = "+" + extraScore;
                Invoke("OffDisplay", 0.75f);
            }
            else
            {
                goldText.text = "~2";
                extraScoreText.text = "+" + extraScore;
                Invoke("OffDisplay", 0.75f);
            }
        }
    }
    void OnDisplay()
    {
        if (ScoreText.score >= 10000)
        {
            extraScoreText.text = "    +" + extraScore;
            Invoke("OffDisplay", 0.75f);
        }
        else if (ScoreText.score >= 1000)
        {
            extraScoreText.text = "  +" + extraScore;
            Invoke("OffDisplay", 0.75f);
        }
        else if (ScoreText.score >= 100)
        {
            extraScoreText.text = "+" + extraScore;
            Invoke("OffDisplay", 0.75f);
        }
    }


    void OffDisplay()
    {
        extraScoreText.text = "";
        goldText.text = "";

    }
}
