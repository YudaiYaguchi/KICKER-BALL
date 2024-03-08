using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;

public class LevelTimer : MonoBehaviour
{
    private float level_time = 0f;
    public  float ratio_one = 1.15f; //level1 の設定
    public  float ratio_two = 1.35f; //level2 の設定
    public  float ratio_three = 1.5f;//level3 の設定
    public float ratio_four = 1.75f;
    public float ratio_five = 1.90f;
    public float ratio_six = 2.25f;

    private int level = 0;
    private bool count1 = true;
    private bool count2 = true; 
    private bool count3 = true; 
    private bool count4 = true;
    private bool count5 = true;
    private bool count6 = true;


    GameObject CreateAmbulance;
    Car script_Amubulance;

    GameObject CreateBus;
    Car script_Bus;

    GameObject CreateContainer;
    Car script_Container;

    GameObject CreateGoldPoliceCar;
    Car script_GoldPoliceCar;

    GameObject CreatePoliceCar;
    Car script_PoliceCar;

    GameObject CreateTaxi;
    Car script_Taxi;

    private int default_ambulance_speed = 16;
    private int default_bus_speed = 12;
    private int default_container_speed = 8;
    private int default_goldPoliceCar_speed = 27;
    private int default_policeCar_speed = 20;
    private int default_taxi_speed = 18;

    /***************************
     <default speed>
    1.CreateAmbulance.speed = 16
    2.CreateBus.speed = 12
    3.CreateContainer.speed = 8
    4.CreateGoldPoliceCar.speed = 27
    5.CreatePoliceCar.speed = 20.5
    6.CreateTaxi.speed = 18
    ***************************/

    // Start is called before the first frame update
    void Start()
    {
        level_time = 0;
       count1 = true;
       count2 = true;
       count3 = true;
       count4 = true;
       count5 = true;
        count6 = true;
    }

    // Update is called once per frame
    void Update()
    {

        level_time += Time.deltaTime;
    // Debug.Log("level_time = " + level_time.ToString("F0"));
    if (level_time >= 240)
    {
        if (count6)
        {
            SpeedUPText.speedUP_flag = true;
            count6 = false;
        }
        level = 6;
        LevelUP(level);

    }
    else if(level_time >= 140)
    {
        if (count5)
        {
            SpeedUPText.speedUP_flag = true;
            count5 = false;
        }
        level = 5;
        LevelUP(level);

    }
    else if(level_time >= 130)
    {
        if (count4)
        {
            SpeedUPText.speedUP_flag = true;
            count4 = false;
        }
        level = 4;
        LevelUP(level);

    }
    else if(level_time >= 90)
        {
            if (count3)
            {
                SpeedUPText.speedUP_flag = true;
                count3 = false;
            }
            level = 3;
            LevelUP(level);

        }
        else if (level_time >= 60)
        {
            if (count2)
            {
                SpeedUPText.speedUP_flag = true;
                count2 = false;
            }
            level = 2;
            LevelUP(level);
        }
        else if (level_time >= 30)
        {
            if (count1)
            {
                SpeedUPText.speedUP_flag = true;
                count1 = false; 
            }
            level = 1;
            LevelUP(level); 
        }
    }
    
   void LevelUP(int level)
    {
        float ratio = 0f;

        if(level == 1){
            ratio = ratio_one;
        }else if(level == 2)
        { 
            ratio = ratio_two;
        }else if(level == 3)
        {
            ratio = ratio_three;
        }else if(level == 4)
    {
        ratio = ratio_four;
    }else if( level == 5)
    {
        ratio = ratio_five;
    }else if(level == 6)
    {
        ratio = ratio_six;
    }
    
        //Ambulance
        CreateAmbulance = GameObject.Find("CreateAmbulance(Clone)"); //オブジェクトの名前から取得して変数に格納する
        if (CreateAmbulance != null)
        {
            script_Amubulance = CreateAmbulance.GetComponent<Car>(); //UnityChanScriptを取得して変数に格納する
            script_Amubulance.speed = ratio * default_ambulance_speed;
          //  Debug.Log("script_Amubulance.speed =" + script_Amubulance.speed);
        }

        //Bus
        CreateBus = GameObject.Find("CreateBus(Clone)"); //オブジェクトの名前から取得して変数に格納する
        if (CreateBus != null)
        {
            script_Bus = CreateBus.GetComponent<Car>(); //UnityChanScriptを取得して変数に格納する
            script_Bus.speed = ratio* default_bus_speed;
        }

        //Container
        CreateContainer = GameObject.Find("CreateContainer(Clone)"); //オブジェクトの名前から取得して変数に格納する
        if (CreateContainer != null)
        {
            script_Container = CreateContainer.GetComponent<Car>(); //UnityChanScriptを取得して変数に格納する
            script_Container.speed = ratio* default_container_speed;
        }

        //GoldPoliceCar
        CreateGoldPoliceCar = GameObject.Find("CreateGoldPoliceCar(Clone)"); //オブジェクトの名前から取得して変数に格納する
        if (CreateGoldPoliceCar != null)
        {
            script_GoldPoliceCar = CreateGoldPoliceCar.GetComponent<Car>(); //UnityChanScriptを取得して変数に格納する
            script_GoldPoliceCar.speed = ratio* default_goldPoliceCar_speed;
        }

        //PoliceCar
        CreatePoliceCar = GameObject.Find("CreatePoliceCar(Clone)"); //オブジェクトの名前から取得して変数に格納する
        if (CreatePoliceCar != null)
        {
            script_PoliceCar = CreatePoliceCar.GetComponent<Car>(); //UnityChanScriptを取得して変数に格納する
            script_PoliceCar.speed = ratio * default_policeCar_speed;
        }

        //Taxi
        CreateTaxi = GameObject.Find("CreateTaxi(Clone)"); //オブジェクトの名前から取得して変数に格納する
        if (CreateTaxi != null)
        {
            script_Taxi = CreateTaxi.GetComponent<Car>(); //UnityChanScriptを取得して変数に格納する
            script_Taxi.speed = ratio* default_taxi_speed;
        }
        
    }

}
