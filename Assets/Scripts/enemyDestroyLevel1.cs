using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDestroyLevel1 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        //Hij kijkt naar de tag Enemy, dan wanneer die word gehit doet die bij counterEnemies 1tje bij. Dat destroyed die deze gameobject en die hem raakte.
        if (other.gameObject.CompareTag("Enemy"))
        {
            counterLevel1.counterEnemies++;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}