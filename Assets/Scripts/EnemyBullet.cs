using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

    public BarrabinBarrabas barrabas;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            // quitar vida
        }
        else if((other.gameObject.tag == "BulletB" && gameObject.tag == "EnemyB") || (other.gameObject.tag == "BulletD" && gameObject.tag == "EnemyD"))
        {
            barrabas.loseHealth();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
