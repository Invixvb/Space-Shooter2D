using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour
{
    public GameObject Bullet;
    private float Wait;

    void Update()
    {
        //Hier zorg ik ervoor dat als je op spatie druk die de kogel aanmaakt en vooruit schiet. Maar hij wacht eerst de time die word aan gegeven totdat die opnieuw schiet.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time > Wait)
            {
                Wait = Time.time + 0.35f;
                Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z),
                    Quaternion.identity);
            }
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.2f, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.2f, 0, 0);
        }
    }
}