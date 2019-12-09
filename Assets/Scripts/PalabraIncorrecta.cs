using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalabraIncorrecta : MonoBehaviour
{

    public GameObject letraIncorrecta;

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
    }
}
