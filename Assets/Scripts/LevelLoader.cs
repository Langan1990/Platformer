using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

    private bool playerinZone;

    public string levelToLoad;



	// Use this for initialization
	void Start () {
        playerinZone = false;

    }
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.W) && playerinZone)
        {
            SceneManager.LoadScene(levelToLoad);
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            playerinZone = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerinZone = false;
        }
    }
}
