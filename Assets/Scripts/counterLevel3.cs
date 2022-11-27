using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class counterLevel3 : MonoBehaviour
{
    public static int counterEnemies;

    private void Start()
    {
        counterEnemies = 0;
    }

    private void Update()
    {
        if (counterEnemies == 8)
        {
            SceneManager.LoadScene("YouWon");
        }
    }
}