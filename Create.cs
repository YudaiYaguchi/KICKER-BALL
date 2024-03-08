using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Threading;
using UnityEngine;
using Random = UnityEngine.Random;

public class Create : MonoBehaviour
{
    public GameObject original;
    public GameObject GoldSoccerBall;
    int firstObject = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating(nameof(CreateObject), 2f, 3.0f);
        //追加
    }

    // Update is called once per frame
    void Update()
    {

        //追加
        FlickScript flickscript;//呼ぶスクリプトにあだ名を付ける
        GameObject obj = GameObject.Find("SoccerBall");//オブジェクトを探す
        flickscript = obj.GetComponent<FlickScript>();//付いてるスクリプトを取得
        if (flickscript.createFlag == 1) {
            if (firstObject != 0) {
              //  Debug.Log("createFlag = 1");
                Invoke(nameof(CreateObject), 0.50f);
                flickscript.createFlag = 0;
            }
            firstObject = 1;
        }
        
      //
    }
    
    void CreateObject()
    {
        int rnd = Random.Range(1, 5); // ※ 1～4の範囲でランダムな整数値が返る

       // Debug.Log("rnd = " + rnd);
        if (rnd == 1)
        {
            //GoldSoccerBall
            Vector3 posi = this.transform.position;
            Instantiate(GoldSoccerBall, new Vector3(posi.x, posi.y, posi.z), Quaternion.identity);
        }
        else
        {
            //NomalSoccerBll
            Vector3 posi = this.transform.position;
            Instantiate(original, new Vector3(posi.x, posi.y, posi.z), Quaternion.identity);
        }

    }
    
    }
