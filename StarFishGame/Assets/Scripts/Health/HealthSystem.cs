using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem {

    private float health;
    public float healthMax;

    public HealthSystem(float MaxHealth)
    {
        this.healthMax = MaxHealth;
        health = MaxHealth;
    }

    public float GetHealth()
    {
        return health;
    }

    public void Damage(float damageAmount)
    {
        health -= damageAmount;


        if (health < 0)
        {
            health = 0;
        }
    }
}