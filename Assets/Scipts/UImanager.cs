using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    private bool isPaused;

    public void OpenScene(int scene)
    {
        SceneManager.LoadScene(scene);
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
    }
    
    public void PauseGame(GameObject screen)
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
            screen.SetActive(false);
        }
        else
        {
            screen.SetActive(true);
            Time.timeScale = 0;
            isPaused = true;
        }
    }
}