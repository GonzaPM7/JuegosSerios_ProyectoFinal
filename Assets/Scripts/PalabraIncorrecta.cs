using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalabraIncorrecta : MonoBehaviour
{

    public GameObject letraIncorrecta;
    public PlayerHealth health;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void colision(GameObject letra)
    {
        if (letra == letraIncorrecta)
        {
            Destroy(gameObject);
        }
        else
        {
            health.damageFallo();
        }
    }
}
