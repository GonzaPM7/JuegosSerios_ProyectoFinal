using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetraPalabraIncorrecta2 : MonoBehaviour
{

    public PalabraIncorrecta2 padre;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BulletD")
        {
            Destroy(collision.gameObject);
            padre.colision(gameObject, "D");
        } else if (collision.gameObject.tag == "BulletB")
        {
            Destroy(collision.gameObject);
            padre.colision(gameObject, "B");
        }
    }
}
