using UnityEngine;
using System.Collections;

public class ShootAtPlayer : MonoBehaviour {

    public float playerRange;

    public GameObject enemybullet;

    public Ace_Control player;

    public Transform launchPoint;

    public float waitBetweenShots;
    private float shotCounter;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<Ace_Control>();

        shotCounter = waitBetweenShots;
	}

	
	// Update is called once per frame
	void Update () {

        //draws line for showing range
        //Debug.DrawLine(new Vector3(transform.position.x - playerRange, transform.position.y, transform.position.z), new Vector3(transform.position.x + playerRange, transform.position.y, transform.position.z));

        shotCounter -= Time.deltaTime;

        if (transform.localScale.x < 0 && player.transform.position.x > transform.position.x && player.transform.position.x < transform.position.x + playerRange && shotCounter < 0)
        {
            Instantiate(enemybullet, launchPoint.position, launchPoint.rotation);
            shotCounter = waitBetweenShots;
        }
        if (transform.localScale.x > 0 && player.transform.position.x < transform.position.x && player.transform.position.x > transform.position.x - playerRange && shotCounter < 0)
        {
            Instantiate(enemybullet, launchPoint.position, launchPoint.rotation);
            shotCounter = waitBetweenShots;
        }



    }
}
