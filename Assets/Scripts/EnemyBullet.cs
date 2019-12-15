using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

    public BarrabinBarrabas barrabas;
    public bool bMode;

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
            Destroy(gameObject);
            // quitar vida
        }
        else if ((other.gameObject.tag == "BulletB" && gameObject.tag == "EnemyB" && bMode) || (other.gameObject.tag == "BulletD" && gameObject.tag == "EnemyD" && !bMode))
        {
            barrabas.loseHealth();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if ((other.gameObject.tag == "BulletB" && gameObject.tag == "EnemyB" && !bMode) || (other.gameObject.tag == "BulletD" && gameObject.tag == "EnemyD" && bMode))
        {
            Destroy(other.gameObject);
            // quitar vida
        }
        else if ((other.gameObject.tag == "BulletD" && gameObject.tag == "EnemyB") || (other.gameObject.tag == "BulletB" && gameObject.tag == "EnemyD"))
        {
            Destroy(other.gameObject);
            // quitar vida
        }
    }
}
