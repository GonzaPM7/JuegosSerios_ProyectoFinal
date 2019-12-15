using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

    public int maxHealth;
    public int dañoColision;
    public int dañoFallo;
    public PlayerHealthBar healthBar;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void damageFallo()
    {
        maxHealth -= dañoFallo;
        healthBar.TakeDamage(dañoFallo);
        Debug.Log(maxHealth);
        checkDeath();
    }

    public void damageColission()
    {
        maxHealth -= dañoColision;
        healthBar.TakeDamage(dañoColision);
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
