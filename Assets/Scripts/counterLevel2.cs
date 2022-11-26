using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class counterLevel2 : MonoBehaviour
{
    public static int counterEnemies;

    private void Start()
    {
        counterEnemies = 0;
    }

    private void Update()
    {
        if(counterEnemies == 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
