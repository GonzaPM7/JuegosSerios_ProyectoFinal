using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour {

    public float maxHealth = 100;
    float health = 0;
    public Image barImage;
    float currentFraction;
    float imageFill;

    // Use this for initialization
    void Start () {
	}

    void Awake()
    {
        health = maxHealth;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void example()
    {
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        UpdateBar(health, maxHealth);
    }

    void UpdateBar(float currentValue, float maxValue)
    {
        currentFraction = currentValue / maxValue;

        if (currentFraction < 0 || currentFraction > 1)
            currentFraction = currentFraction < 0 ? 0 : 1;

        imageFill = currentFraction;

        barImage.fillAmount = imageFill;
        Debug.Log("mafia" + barImage.fillAmount);
    }
}
