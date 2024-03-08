using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class DestroyCar1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SupecialCar"))
        {

            other.gameObject.SetActive(false);
            Destroy(other.gameObject);

        }
        else if (other.gameObject.CompareTag("CreatePoliceCar"))
        {
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);

        }
        else if (other.gameObject.CompareTag("CreateTaxi"))
        {
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("CreateAmbulance"))
        {
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("CreateBus"))
        {
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("CreateContainer"))
        {
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);

        }

    }
}
