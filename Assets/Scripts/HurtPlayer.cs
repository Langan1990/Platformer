using UnityEngine;
using System.Collections;

public class HurtPlayer : MonoBehaviour {


    public int damagetoGive;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            HealthManager.HurtPlayer(damagetoGive);

            var player = other.GetComponent<Ace_Control>();
            player.knockbackcount = player.knockbacklength;

            if(other.transform.position.x < transform.position.x)
            {
                player.knockfromright = true;
            }
            else
            {
                player.knockfromright = false;
            }
        }
    }

}
