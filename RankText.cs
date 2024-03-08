using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RankText : MonoBehaviour
{
    public Text rankText;
  

    // Start is called before the first frame update
    void Start()
    {
        rankText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreText.score >= 100000)
        {
            rankText.text = "Ågâ…ê_Åg";
        }else if (ScoreText.score >= 75000)
        {
            rankText.text = "Ågê_êlÅg";
        }else if (ScoreText.score >= 50000)
        {
            rankText.text = "ÅgìVçcÅg";
        }else if(ScoreText.score >= 30000)
        {
            rankText.text = "ÅgñºêlÅg";
        }else if(ScoreText.score >= 20000)
        {
            rankText.text = "ÅgíBêlÅg";
        }else if(ScoreText.score >= 10000)
        {
            rankText.text = "Ågènó˚Åg";
        }else if(ScoreText.score >= 5000)
        {
            rankText.text = "ÅgàÍî Åg";
        }else if (ScoreText.score >= 0)
        {
            rankText.text = "Ågñ¢ènÅg";
        }

    }
}
