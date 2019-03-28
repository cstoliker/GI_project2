using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject gameMenu;
    public GameObject quitMessage;
    public bool isPaused = false;

    void Update()
    {
        //exit start menu
        if(Input.GetKeyDown(KeyCode.Space))
        {
            startMenu.SetActive(false);
        }

        //enter or exit pause menu
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                isPaused = false;
                gameMenu.SetActive(false);
                Time.timeScale = 1f;
            } else
            {
                isPaused = true;
                gameMenu.SetActive(true);
                Time.timeScale = 0f;
            }
        }

        //restart call
        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }

        //quit call
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Quit();
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        gameMenu.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        gameMenu.SetActive(false);
        quitMessage.SetActive(true);
    }
}
