using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string startLevel;
    public string options;
    public string levelSelect;

    public int startinglives;
   

    public void NewGame()
    {
        PlayerPrefs.SetInt ("CurrentLives", startinglives);
        PlayerPrefs.SetInt("CurrentScore", 0);
        SceneManager.LoadScene(startLevel);
       
    }
    //
    public void LevelSelect()
    {
        PlayerPrefs.SetInt("CurrentLives", startinglives);
        PlayerPrefs.SetInt("CurrentScore", 0);
        SceneManager.LoadScene(levelSelect);
    }

    public void Options()
    {
        SceneManager.LoadScene(options);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
