using UnityEngine;
using System.Collections;

public class EnemyBulletControl : MonoBehaviour {

    public float speed;

    public Ace_Control player;

  //  public GameObject enemydeathEffect;

    public GameObject bullethit;

   // public int pointsperkill;

    public int damagetoGive;

    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<Ace_Control>();
        if (player.transform.position.x < transform.position.x)
        {
            speed = -speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            // Instantiate(enemydeathEffect, other.transform.position, other.transform.rotation);
            // Destroy(other.gameObject);
            //ScoreManager.AddPoints(pointsperkill);
            HealthManager.HurtPlayer(damagetoGive);


        }
        Instantiate(bullethit, transform.position, transform.rotation);
        Destroy(gameObject);

    }

}
