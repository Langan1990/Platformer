using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesManager : MonoBehaviour {
   // public int startinglives;

    private int livesCounter;
    private Text text;
    public GameObject gameOverScreen;

    public Ace_Control player;

       public float waitAfterGameOver;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();

        livesCounter = PlayerPrefs.GetInt("CurrentLives");

        player = FindObjectOfType<Ace_Control>();
	}
	
	// Update is called once per frame
	void Update () {

        if (livesCounter == 0)
        {
            gameOverScreen.SetActive(true);
            player.gameObject.SetActive(false);
        }

        text.text = "x " + livesCounter;

        if (gameOverScreen.activeSelf)
        {
            waitAfterGameOver -= Time.deltaTime;
        }

        if(waitAfterGameOver < 0)
        {
            SceneManager.LoadScene("Menu");
        }
	}

    public void GiveLife()
    {
        livesCounter++;
        PlayerPrefs.SetInt("CurrentLives", livesCounter);
    }

    public void TakeLife()
    {
        livesCounter--;
        PlayerPrefs.SetInt("CurrentLives", livesCounter);
    }


}
