using UnityEngine;
using System.Collections;

public class EnemyHealthManager : MonoBehaviour {

    public int enemyhealth;

    public GameObject deathEffect;

    public int pointsOnDeath;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(enemyhealth <= 0)
        {
            Instantiate(deathEffect, transform.position, transform.rotation);
            ScoreManager.AddPoints(pointsOnDeath);
            Destroy(gameObject);
        }
	}


    public void giveDamage(int damagetoGive)
    {
        enemyhealth -= damagetoGive;
        
    }


}
