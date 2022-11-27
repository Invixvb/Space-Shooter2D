using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public bool goRight;
    public bool goLeft;

    void Start()
    {
        goRight = true;
    }

    //Hierbij zeg ik dat als die naar rechts is en niet naar links doet die het eerste colum stukje. Bij de tweede andersom. 
    //Als de positie groter is dan 7.5 op de x as en hij gaat naar rechts dan is goLeft true en goRight false dus gaat die naar links, bij de laatste colum stukje is het andersom
    void FixedUpdate()
    {
        if (goRight && !goLeft)
        {
            transform.Translate(-Random.Range(0.3f, 0.2f), 0, 0);
        }

        if (goLeft && !goRight)
        {
            transform.Translate(Random.Range(0.3f, 0.2f), 0, 0);
        }


        if (transform.position.x >= 7.5f && goRight)
        {
            goLeft = true;
            goRight = false;
        }

        if (transform.position.x <= -7.5f && goLeft)
        {
            goLeft = false;
            goRight = true;
        }
    }
}