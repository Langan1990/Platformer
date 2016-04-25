using UnityEngine;
using System.Collections;
using System;

public class BossHealth : MonoBehaviour {
    public int bosshealth;

    public GameObject deathEffect;

    public int pointsOnDeath;

    public GameObject bossPrefab;

    public float minSize;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (bosshealth <= 0)
        {
            Instantiate(deathEffect, transform.position, transform.rotation);
            ScoreManager.AddPoints(pointsOnDeath);
            if (transform.localScale.y > minSize)
            {
                GameObject clone1 = Instantiate(bossPrefab, new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z), transform.rotation)as GameObject;
                GameObject clone2 = Instantiate(bossPrefab, new Vector3(transform.position.x - 1f, transform.position.y, transform.position.z), transform.rotation) as GameObject;
                GameObject clone3 = Instantiate(bossPrefab, new Vector3(transform.position.x + 2f, transform.position.y, transform.position.z), transform.rotation) as GameObject;
                GameObject clone4 = Instantiate(bossPrefab, new Vector3(transform.position.x - 2f, transform.position.y, transform.position.z), transform.rotation) as GameObject;

                clone1.transform.localScale = new Vector3(transform.localScale.y * 0.5f, transform.localScale.y * 0.5f, transform.localScale.z);
                clone1.GetComponent<BossHealth>().bosshealth = 100;
                clone2.transform.localScale = new Vector3(transform.localScale.y * 0.5f, transform.localScale.y * 0.5f, transform.localScale.z);
                clone2.GetComponent<BossHealth>().bosshealth = 100;
                clone3.transform.localScale = new Vector3(transform.localScale.y * 0.5f, transform.localScale.y * 0.5f, transform.localScale.z);
                clone3.GetComponent<BossHealth>().bosshealth = 100;
                clone4.transform.localScale = new Vector3(transform.localScale.y * 0.5f, transform.localScale.y * 0.5f, transform.localScale.z);
                clone4.GetComponent<BossHealth>().bosshealth = 100;
            }
            Destroy(gameObject);
        }



    }

  

    public void giveDamage(int damagetoGive)
    {
        bosshealth -= damagetoGive;

    }

}
