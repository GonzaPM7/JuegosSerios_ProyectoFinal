using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalabraIncorrecta2 : MonoBehaviour
{

    public GameObject letraIncorrecta;
    public string tipoLetraCorrecta;
    public PlayerHealth health;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void colision(GameObject letra, string tipoLetra)
    {
        if (letra == letraIncorrecta && tipoLetra == tipoLetraCorrecta)
        {
            Destroy(gameObject);
        }
        else
        {
            health.damageFallo();
        }
    }
}
