using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalabraIncompleta : MonoBehaviour {
    
    public string letra;
    public PlayerHealth health;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {        
        if (letra == "B") {
            if (collision.gameObject.tag == "BulletB")
            {                
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
            else if (collision.gameObject.tag == "BulletD")
            {
                Destroy(collision.gameObject);
                health.damageFallo();
            }
        }
        else if(letra == "D")
        {
            if (collision.gameObject.tag == "BulletD")
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
            else if (collision.gameObject.tag == "BulletB")
            {
                Destroy(collision.gameObject);
                health.damageFallo();
            }
        }
    }
}
