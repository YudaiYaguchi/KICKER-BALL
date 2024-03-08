using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;


public class FlickScript : MonoBehaviour
{
    public float powerPerPixel;
    public float maxPower;
    Vector3 touchPos;
    float posiZ = 0;
    public int createFlag = 0;
    private int times = 1;
    [SerializeField]
    AudioSource seAudioSource;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            transform.Rotate(new Vector3(0, 0, 30));

            touchPos = Input.mousePosition;

            InvokeRepeating(nameof(IncreasePositionZ), 0.5f, 0.1f);
        }
        else if (Input.GetMouseButtonUp(0))
        {
         //   seAudioSource.Play();

            Vector3 releasePos = Input.mousePosition;
            float swipeDistanceY = releasePos.y - touchPos.y;
            float powerY = swipeDistanceY * powerPerPixel;
            float swipeDistanceX = releasePos.x - touchPos.x;
            float powerX = swipeDistanceX * powerPerPixel;
         
            createFlag = 1;//サッカーボールを生成
            if (this.gameObject.name == "SoccerBall(Clone)")
            {
                Invoke(nameof(DestroyObject), 3.0f);//オブジェクトを削除
            }
            if (this.gameObject.name == "GoldSoccerBall(Clone)")
            {
                Invoke(nameof(DestroyObject), 3.0f);//オブジェクトを削除
            }


            if (powerX < 0)
            {
                powerX *= -1;
            }
            if (powerY < 0)
            {
                powerY *= -1;
            }

            if (powerX > maxPower)
            {
                powerX = maxPower;
            }
            if (powerY > maxPower)
            {
                powerY = maxPower;
            }

            GetComponent<Rigidbody>().AddForce(new Vector3(powerX * swipeDistanceX,0, powerY * swipeDistanceY), ForceMode.Impulse);
        }
        
        Vector3 posi = transform.position;
        posi.y = posiZ;
        transform.position = posi;
        
     
        if (posiZ > 5) {
            CancelInvoke("IncreasePositionZ");
        }

    }

    /******************得点表****************************
       
    CreateGoldPoliceCar 1000
    CreatePoliceCar 375
    CreateTaxi 330
    CreateAmbulance 285
    CreateBus 150
    CreateContainer 150

    *******************得点表***************************/


    void OnTriggerEnter(Collider other)//ボールが車と衝突したときの処理
    {
      //  createFlag = 1;//サッカーボールを生成

        if (other.gameObject.CompareTag("SupecialCar"))
        {
            SE.seFlag = 1;//効果音フラグ

            if (this.gameObject.CompareTag("GoldSoccerBall"))
            {
                times = 2;
                ExtraScore.goldScoreFlag = 1;
                // Debug.Log("tag = GoldSoccerBall");
            }

            ScoreText.score += 1000*times;//ScoreTextのscoreを更新
            TimerText.timer += 10;//TimerTextを更新
            times = 1;

            ExtraTimer.extraFlag = 1;
            ExtraScore.extraScoreFlag = 1;
            ExtraScore.extraScore = 1000;

            other.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
            Destroy(other.gameObject, 2.0f);
            Destroy(this.gameObject);

        }else  if (other.gameObject.CompareTag("CreatePoliceCar"))
        {
            SE.seFlag = 1;//効果音フラグ

            if (this.gameObject.CompareTag("GoldSoccerBall"))
            {
                times = 2;
                ExtraScore.goldScoreFlag = 1;

            }
            ScoreText.score += 375*times;//ScoreTextのscoreを更新
            times = 1;

            ExtraScore.extraScoreFlag = 1;
            ExtraScore.extraScore = 375;

            other.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
            Destroy(other.gameObject, 2.0f);
            Destroy(this.gameObject);
            
        }else if (other.gameObject.CompareTag("CreateTaxi"))
        {
            SE.seFlag = 1;//効果音フラグ

            if (this.gameObject.CompareTag("GoldSoccerBall"))
            {
                times = 2;
                ExtraScore.goldScoreFlag = 1;

            }
            ScoreText.score += 330*times;//ScoreTextのscoreを更新
            times = 1;

            ExtraScore.extraScoreFlag = 1;
            ExtraScore.extraScore = 330;

            other.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
            Destroy(other.gameObject, 2.0f);
            Destroy(this.gameObject);
        }
        else if (other.gameObject.CompareTag("CreateAmbulance"))
        {
            SE.seFlag = 1;//効果音フラグ

            if (this.gameObject.CompareTag("GoldSoccerBall"))
            {
                times = 2;
                ExtraScore.goldScoreFlag = 1;

            }
            ScoreText.score += 285*times;//ScoreTextのscoreを更新
            times = 1;

            ExtraScore.extraScoreFlag = 1;
            ExtraScore.extraScore = 285;

            other.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
            Destroy(other.gameObject, 2.0f);
            Destroy(this.gameObject);
        }
        else if (other.gameObject.CompareTag("CreateBus"))
        {
            SE.seFlag = 1;//効果音フラグ

            if (this.gameObject.CompareTag("GoldSoccerBall"))
            {
                times = 2;
                ExtraScore.goldScoreFlag = 1;

            }
            ScoreText.score += 150*times;//ScoreTextのscoreを更新
            times = 1;

            ExtraScore.extraScoreFlag = 1;
            ExtraScore.extraScore = 150;

            other.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
            Destroy(other.gameObject, 2.0f);
            Destroy(this.gameObject);
        }
        else if (other.gameObject.CompareTag("CreateContainer"))
        {
            SE.seFlag = 1;//効果音フラグ

            if (this.gameObject.CompareTag("GoldSoccerBall"))
            {
                times = 2;
                ExtraScore.goldScoreFlag = 1;

            }
            ScoreText.score += 150*times;//ScoreTextのscoreを更新
            times = 1;

            ExtraScore.extraScoreFlag = 1;
            ExtraScore.extraScore = 150;

            other.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
            Destroy(other.gameObject, 2.0f);
            Destroy(this.gameObject);
        }



    }

    void IncreasePositionZ()
    {
       // Debug.Log("posiZ = " + posiZ);
        posiZ = posiZ + 0.2f;
    }
    void DecreasePositionZ()
    {
        //Debug.Log("posiZ = " + posiZ);
        posiZ = posiZ - 0.2f;
    }
    void DestroyObject()
    {
       // createFlag = 1;//サッカーボールを生成
        DestroyObject(this.gameObject);
    }
  
}