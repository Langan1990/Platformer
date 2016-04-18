using UnityEngine;
using System.Collections;

public class Level_Manager : MonoBehaviour {


	public GameObject currentCheckpoint;

	private Ace_Control player;

	public GameObject deathParticle;
	public GameObject respawnParticle;

    public int pointPenaltyOnDeath;

	public float respawnDelay;

    private float gravityStore;

    private CameraController camera;

    public HealthManager healthmanager;

    public bool isDead = false;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<Ace_Control> ();
        camera = FindObjectOfType<CameraController>();
        healthmanager = FindObjectOfType<HealthManager>();

	}
	
	// Update is called once per frame
	void Update () {
	       
	}

	public void RespawnPlayer()
	{
		StartCoroutine ("RespawnPlayerCo");	
	}

	public IEnumerator RespawnPlayerCo()
	{
		Instantiate (deathParticle, player.transform.position, player.transform.rotation);
		player.enabled = false;//disables control of the player
		player.GetComponent<Renderer>().enabled = false;//disables view of the player
        camera.isFollowing = false;
        //gravityStore = player.GetComponent<Rigidbody2D>().gravityScale;//stores the gravity scale
       // player.GetComponent<Rigidbody2D>().gravityScale = 0f;//stops the player falling when killed
       // player.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;//stops the camera moving after player dies
        ScoreManager.AddPoints(-pointPenaltyOnDeath);//deducts points when player dies
		Debug.Log ("Player Respawn");
       // player.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
        yield return new WaitForSeconds (respawnDelay);
        
        player.transform.position = currentCheckpoint.transform.position;
		player.enabled = true;
		player.GetComponent<Renderer>().enabled = true;
        healthmanager.FullHealth();
        healthmanager.isDead = false;
        camera.isFollowing = true;
        Instantiate (respawnParticle, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);

	}
}
