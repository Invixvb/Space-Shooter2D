using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLeft : MonoBehaviour
{
    //Hier zeg ik dat als die collide met n ander object dat die deze nieuwe positie aan moet nemen.
    private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.position = new Vector3(9, -4, 0);
    }
}