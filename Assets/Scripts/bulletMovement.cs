using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    public float moveSpeed;

    //Dit zorgt ervoor dat de positie nieuw word aangegeven en dan de positie die die al had op de x, y en z as hetzelfde blijft 
    //maar bij de y as doet die de movement speed die je zelf kan aangeven nog erbij
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + moveSpeed, transform.position.z);
    }
}
