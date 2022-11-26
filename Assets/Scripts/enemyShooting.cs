using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    float ran;
    float coolingDown;


    void Start()
    {
        coolingDown = 0.5f;
    }

    //Hierbij zeg ik dat die moet wachten elke keer met schieten, 
    //dan pakt die de bulletPrefab en die houd de positie aan die die heeft, maar met de movement van het anderen script gaat die naar voren.
    void FixedUpdate()
    {
        if (Time.time > coolingDown)
        {
            ran = Random.Range(1f, 3f);
            coolingDown = Time.time + ran;
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }
}
