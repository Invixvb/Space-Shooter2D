using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverButtons : MonoBehaviour
{
    //Hier zeg ik dat als die word geklikt dat die of De scene moet laden en bij de anderen de game moet afsluiten.
    public void tryAgain()
    {
        SceneManager.LoadScene("Level01");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}