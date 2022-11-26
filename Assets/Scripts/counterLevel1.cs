using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class counterLevel1 : MonoBehaviour
{
    public static int counterEnemies;

    private void Start()
    {
        counterEnemies = 0;
    }

    //Hier zeg ik als de counterEnemeies 3 bereikt dat die een scene moet laden. 
    //Hierbij kijkt die naar de active scene en daarbij in de buildindex eentje erbij doet dus de eerst volgende scene laad.
    private void Update()
    {
        if(counterEnemies == 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
