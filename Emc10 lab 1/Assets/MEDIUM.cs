using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MEDIUM : MonoBehaviour
{


    public void MEDIUM1()
    {
        SceneManager.LoadScene("Start screen");
    }
    public void RetryGame()
    {
        SceneManager.LoadScene("LEVEL 2");
    }

}
