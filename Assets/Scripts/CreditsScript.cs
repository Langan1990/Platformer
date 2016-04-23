using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CreditsScript : MonoBehaviour {

    public string levelSelect;

    public void LevelSelect()
    {
        SceneManager.LoadScene(levelSelect);
    }

}
