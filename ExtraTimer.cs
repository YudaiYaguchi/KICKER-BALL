using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ExtraTimer : MonoBehaviour
{
    public static int extraFlag = 0;
    public Text extraTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (extraFlag == 1)
        {
            OnDisplay();
            extraFlag = 0;
        }   
    }

    void OnDisplay()
    {
        extraTimer.text = "+10";
        Invoke("OffDisplay", 3.0f);
    }
    void OffDisplay()
    {
        extraTimer.text = "";

    }
}
