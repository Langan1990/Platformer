using UnityEngine;
using System.Collections;

public class CoinPickupScript : MonoBehaviour {

    public int points;

    public GameObject coinparticle;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Ace_Control>() == null)
            return;


        ScoreManager.AddPoints(points);
        Instantiate(coinparticle, transform.position, transform.rotation);
        Destroy(gameObject);
    }   
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
