using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EASY : MonoBehaviour
{


    public void EASY1()
    {
        SceneManager.LoadScene("Start screen");
    }
    public void RetryGame()
    {
        SceneManager.LoadScene("LEVEL 1");
    }

}
