using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{
    SavePlayerPos playerPosData;
    void Start()
    {
        playerPosData = FindObjectOfType<SavePlayerPos>();
    }
    public void QuitGame()
    {
        playerPosData.PlayerPosSave();
        SceneManager.LoadScene("start screen");
    }
}
