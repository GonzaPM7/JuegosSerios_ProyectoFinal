using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour {

    public float maxHealth = 100;
    float health = 0;
    public Image barImage;
    RectTransform rt;

    float currentFraction;
    float imageFill;

    Vector2 startSize;

    // Use this for initialization
    void Start () {
        rt = barImage.GetComponent<RectTransform>();
        startSize = rt.sizeDelta;
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
        rt.sizeDelta = new Vector2(startSize.x * currentFraction, startSize.y);
        Debug.Log("mafia" + barImage.fillAmount);
    }
}
