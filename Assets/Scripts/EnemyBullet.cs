using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

    public BarrabinBarrabas barrabas;
    public bool bMode;
    public PlayerHealth health;

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
            health.damageColission();
        }
        else if ((other.gameObject.tag == "BulletNormal" && gameObject.tag == "EnemyB" && bMode) || (other.gameObject.tag == "BulletNormal" && gameObject.tag == "EnemyD" && !bMode))
        {
            barrabas.loseHealth();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if ((other.gameObject.tag == "BulletNormal" && gameObject.tag == "EnemyB" && !bMode) || (other.gameObject.tag == "BulletNormal" && gameObject.tag == "EnemyD" && bMode))
        {
            Destroy(other.gameObject);
            health.damageFallo();
            Destroy(gameObject);
        }
    }
}
