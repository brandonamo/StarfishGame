using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour {

    private float health;
    public float healthMax;

    public HealthSystem(float MaxHealth)
    {
        this.healthMax = MaxHealth;
        health = MaxHealth;
    }

    [Header("Unity Stuff")]
    public Image healthBar;
    

    public float GetHealth()
    {
        return health;
    }

    public void Damage(float damageAmount)
    {
        health -= damageAmount;

        healthBar.fillAmount = health/healthMax;

        if (health < 0)
        {
            health = 0;
            //print("Youa are dead");
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Weapon")
        {
            print("Hello");
        }
    }
}