using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDestroyLevel2 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            counterLevel2.counterEnemies++;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
