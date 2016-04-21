using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour {
    public string level1;
    public string level2;
    public string level3;
    public string level4;
    public string level5;
    public string levelMain;

    public int startinglives;


    public void Level1()
    {
        PlayerPrefs.SetInt("CurrentLives", startinglives);
        PlayerPrefs.SetInt("CurrentScore", 0);
        SceneManager.LoadScene(level1);
    }

    public void Level2()
    {
        PlayerPrefs.SetInt("CurrentLives", startinglives);
        PlayerPrefs.SetInt("CurrentScore", 0);
        SceneManager.LoadScene(level2);
    }

    public void Level3()
    {
        PlayerPrefs.SetInt("CurrentLives", startinglives);
        PlayerPrefs.SetInt("CurrentScore", 0);
        SceneManager.LoadScene(level3);
    }

    public void Level4()
    {
        PlayerPrefs.SetInt("CurrentLives", startinglives);
        PlayerPrefs.SetInt("CurrentScore", 0);
        SceneManager.LoadScene(level4);
    }

    public void Level5()
    {
        PlayerPrefs.SetInt("CurrentLives", startinglives);
        PlayerPrefs.SetInt("CurrentScore", 0);
        SceneManager.LoadScene(level5);
    }
    public void MainMenu()
    {
        PlayerPrefs.SetInt("CurrentLives", startinglives);
        PlayerPrefs.SetInt("CurrentScore", 0);
        SceneManager.LoadScene(levelMain);
    }
}
