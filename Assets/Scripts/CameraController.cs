using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    public Ace_Control player;

    public bool isFollowing;

    public float xOffset;
    public float yOffset;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<Ace_Control>();

        isFollowing = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (isFollowing)
        {
            transform.position = new Vector3(player.transform.position.x + xOffset, player.transform.position.y + yOffset, player.transform.position.z - 10);
        }
	}
}
