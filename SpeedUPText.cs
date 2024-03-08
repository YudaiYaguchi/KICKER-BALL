using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SpeedUPText : MonoBehaviour
{
    public TextMeshProUGUI speedUPText;
    public static bool speedUP_flag = false;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        speedUPText.text = "";
        speedUP_flag = false;
        count = 0;  
    }

    // Update is called once per frame
    void Update()
    {
        if (speedUP_flag)
        {
            InvokeRepeating("OnDisplay", 0f, 0.3f);
            InvokeRepeating("OffDisplay", 0.15f, 0.3f);
            speedUP_flag = false;
        }
        
    }

    private void OnDisplay()
    {
        speedUPText.text = "SPEED UP";
    }

    private void OffDisplay()
    {
        speedUPText.text = "";
        count++;
        if(count == 10)
        {
            CancelInvoke();
            count = 0;
        }
      
    }
}
