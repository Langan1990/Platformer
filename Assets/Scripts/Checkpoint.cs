using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

	public Level_Manager levelmanager;//creates empty levelmanager
	
	// Use this for initialization
	void Start () {
		levelmanager = FindObjectOfType<Level_Manager>();//allows access to Level_Manager
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			levelmanager.currentCheckpoint = gameObject;
			Debug.Log ("Checkpoint Activated" + transform.position);
		}
	}
}
