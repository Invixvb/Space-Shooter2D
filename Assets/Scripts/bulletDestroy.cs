using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDestroy : MonoBehaviour
{
    //Dit zorgt er voor dat als hij door iets anders word geraakt dat die de gameObject destroyed zodat die weg is.
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Shots")
        {
            Destroy(gameObject);
        }
    }
}
