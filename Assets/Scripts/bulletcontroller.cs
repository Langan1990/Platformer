using UnityEngine;
using System.Collections;

public class bulletcontroller : MonoBehaviour {
    public float speed;

    public Ace_Control player;

    public GameObject enemydeathEffect;

    public GameObject bullethit;

    public int pointsperkill;

    public int damagetoGive;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<Ace_Control>();
        if (player.transform.localScale.x < 0)
        {
            speed = -speed;
        }
    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag  == "Enemy")
        {
            // Instantiate(enemydeathEffect, other.transform.position, other.transform.rotation);
            // Destroy(other.gameObject);
            //ScoreManager.AddPoints(pointsperkill);
            other.GetComponent<EnemyHealthManager>().giveDamage(damagetoGive);


        }
        Instantiate(bullethit, transform.position, transform.rotation);
        Destroy(gameObject);

    }

}
