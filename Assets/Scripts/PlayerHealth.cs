using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

    public int maxHealth;
    public int dañoColision;
    public int dañoFallo;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void damageFallo()
    {
        maxHealth -= dañoFallo;
        checkDeath();
    }

    public void damageColission()
    {
        maxHealth -= dañoColision;
        Debug.Log(maxHealth);
        checkDeath();
    }

    void checkDeath()
    {
        if (maxHealth <= 0)
        {
            string scene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(scene);
        }
    }
}
