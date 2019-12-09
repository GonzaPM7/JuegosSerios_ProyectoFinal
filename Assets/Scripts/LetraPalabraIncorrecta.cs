using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetraPalabraIncorrecta : MonoBehaviour {

    public PalabraIncorrecta padre;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BulletNormal")
        {
            Destroy(collision.gameObject);
            padre.colision(gameObject);
        }
    }
}
