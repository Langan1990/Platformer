using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour {

    public int maxPlayerHealth;

    public static int playerHealth;

    Text text;

    private Level_Manager levelmanager;

    public bool isDead;

    // Use this for initialization
    void Start () {
        text = GetComponent<Text>();

        playerHealth = maxPlayerHealth;

        levelmanager = FindObjectOfType<Level_Manager>();

        isDead = false;

    }

    // Update is called once per frame
    void Update () {


	    if(playerHealth <= 0 && !isDead)
        {
            playerHealth = 0;
            levelmanager.RespawnPlayer();

            isDead = true;

        }

        text.text = "" + playerHealth;

    }


    public static void HurtPlayer(int damagetoGive)
    {
        playerHealth -= damagetoGive;
    }

    public void FullHealth()
    {
        playerHealth = maxPlayerHealth;
    }


}
