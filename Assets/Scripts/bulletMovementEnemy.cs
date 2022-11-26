using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovementEnemy : MonoBehaviour
{

    public float moveSpeed;

    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + moveSpeed, transform.position.z);
    }
}
