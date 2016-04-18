using UnityEngine;
using System.Collections;

public class movingPlatformScript : MonoBehaviour {

    public GameObject platform;
    public float moveSpeed;
    public Transform currentPosition;
    public Transform[] positions;

    public int PositionSelect;


    // Use this for initialization
    void Start()
    {
        currentPosition = positions[PositionSelect];
    }
	// Update is called once per frame
	void Update () {

            platform.transform.position = Vector3.MoveTowards(platform.transform.position, currentPosition.position, Time.deltaTime * moveSpeed);

        if (platform.transform.position == currentPosition.position)
        {
            PositionSelect++;

            if (PositionSelect == positions.Length)
            {
                PositionSelect = 0;
            }

            currentPosition = positions[PositionSelect];
        }
    }
}
