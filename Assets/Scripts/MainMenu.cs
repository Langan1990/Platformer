using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string startLevel;

    public string levelSelect;

    public void NewGame()
    {
        SceneManager.LoadScene(startLevel);
       
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene(levelSelect);
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
