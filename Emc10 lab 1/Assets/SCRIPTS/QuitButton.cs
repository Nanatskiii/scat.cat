using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{
    
   
    public void MainMenu()
    {
        SceneManager.LoadScene("Start screen");
    }
    public void RetryGame()
    {
        SceneManager.LoadScene("LEVEL 1");
    }

}
