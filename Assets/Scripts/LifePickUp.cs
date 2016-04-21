using UnityEngine;
using System.Collections;

public class LifePickUp : MonoBehaviour {

    private LivesManager lifesystem;
    public GameObject lifeparticle;
    // Use this for initialization
    void Start () {
        lifesystem = FindObjectOfType<LivesManager>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) {
	    if (other.name == "Ace")
        {
  
            lifesystem.GiveLife();
            Instantiate(lifeparticle, transform.position, transform.rotation);
            Destroy(gameObject);
        }
	}
}
