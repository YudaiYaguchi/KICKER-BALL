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
        //�ǉ�
    }

    // Update is called once per frame
    void Update()
    {

        //�ǉ�
        FlickScript flickscript;//�ĂԃX�N���v�g�ɂ�������t����
        GameObject obj = GameObject.Find("SoccerBall");//�I�u�W�F�N�g��T��
        flickscript = obj.GetComponent<FlickScript>();//�t���Ă�X�N���v�g���擾
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
        int rnd = Random.Range(1, 5); // �� 1�`4�͈̔͂Ń����_���Ȑ����l���Ԃ�

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
