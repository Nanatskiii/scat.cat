using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HARD : MonoBehaviour
{


    public void HARD2()
    {
        SceneManager.LoadScene("Start screen");
    }
    public void RetryGame()
    {
        SceneManager.LoadScene("LEVEL 3");
    }

}
