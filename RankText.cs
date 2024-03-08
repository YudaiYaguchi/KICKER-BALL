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
            rankText.text = "�g�ɐ_�g";
        }else if (ScoreText.score >= 75000)
        {
            rankText.text = "�g�_�l�g";
        }else if (ScoreText.score >= 50000)
        {
            rankText.text = "�g�V�c�g";
        }else if(ScoreText.score >= 30000)
        {
            rankText.text = "�g���l�g";
        }else if(ScoreText.score >= 20000)
        {
            rankText.text = "�g�B�l�g";
        }else if(ScoreText.score >= 10000)
        {
            rankText.text = "�g�n���g";
        }else if(ScoreText.score >= 5000)
        {
            rankText.text = "�g��ʁg";
        }else if (ScoreText.score >= 0)
        {
            rankText.text = "�g���n�g";
        }

    }
}
