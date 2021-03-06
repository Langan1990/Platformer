﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public bool isPaused;
    public GameObject pausemenucanvas;
    

    public string mainmenu;

    void Update()
    {
        if (isPaused)
        {
            
            pausemenucanvas.SetActive(true);
            AudioListener.pause = true;
            Time.timeScale = 0f;
        }
        else
        {
            pausemenucanvas.SetActive(false);
            AudioListener.pause = false;
            // AudioListener.volume = 1;
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Escape)) //if satatement 
        {
            isPaused = !isPaused;
        }


    }


    public void MainMenu()
    {
        SceneManager.LoadScene(mainmenu);

    }

    public void Resume()
    {
        isPaused = false;

    }
}
