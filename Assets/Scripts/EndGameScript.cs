using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGameScript : MonoBehaviour {

    private Text text;

    public static int highScoreDisplay;

    public Text HighScoreCount;
    public Text ScoreCount;

    public string mainmenu;

    // Use this for initialization
    void Start () {
        int score = PlayerPrefs.GetInt("CurrentScore");
        int highscore = PlayerPrefs.GetInt("HighScore");
        if (score > highscore)
        {
            highscore = score;
        }
        PlayerPrefs.SetInt("HighScore", highscore);
        highScoreDisplay = PlayerPrefs.GetInt("HighScore");
        HighScoreCount.text = "" + highScoreDisplay;
        ScoreCount.text = "" + score;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(mainmenu);
    }

    
}
