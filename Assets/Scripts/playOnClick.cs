using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playOnClick : MonoBehaviour
{
    public void playClick()
    {
        SceneManager.LoadScene("Controls");
    }
}