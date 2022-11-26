using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRight : MonoBehaviour
{
     private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.position = new Vector3(-9, -4, 0);
    }
}
