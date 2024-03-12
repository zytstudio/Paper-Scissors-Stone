using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthSliderController : MonoBehaviour
{
    private Slider slider;

    public int maxHealth;
    public int health;
    public UnityEvent PlayerDeath;

    private void Start()
    {
        slider = GetComponent<Slider>();
        InitValue();
    }

    public void InitValue()
    {
        if (maxHealth < 0)
        {
            maxHealth = 0;
        }
        health = maxHealth;
        slider.maxValue = maxHealth;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        this.health = health;
        slider.value = Mathf.Max(Mathf.Min(this.health, maxHealth), 0);
        if (health < 0)
        {
            PlayerDeath?.Invoke();
        }
    }

    public void AddHealth(int deltaHealth)
    {
        health += deltaHealth;
        slider.value = Mathf.Max(Mathf.Min(this.health, maxHealth), 0);
        if(health < 0)
        {
            PlayerDeath?.Invoke();
        }
    }
}
