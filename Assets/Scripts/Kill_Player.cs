using UnityEngine;
using System.Collections;

public class Kill_Player : MonoBehaviour {


	public Level_Manager levelmanager;//creates empty levelmanager

    private HealthManager healthManager;

    // Use this for initialization
    void Start () {
		levelmanager = FindObjectOfType<Level_Manager>();//allows access to Level_Manager
        healthManager = FindObjectOfType<HealthManager>();//allows access to Level_Manager
    }
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
            healthManager.isDead = true;
			levelmanager.RespawnPlayer();
		}
	}
}
