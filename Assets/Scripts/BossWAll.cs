using UnityEngine;
using System.Collections;

public class BossWAll : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	if (FindObjectOfType<BossHealth>())
        {
            return;
        }
        else
        {
            Destroy(this.gameObject);
        }
      
	}
}
