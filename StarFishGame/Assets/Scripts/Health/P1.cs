using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1 : MonoBehaviour {
    public float MaxHealth = 100.0f;
    public float CurrentHealth;
    public bool attacked = false;
    // Use this for initialization
    HealthSystem HP;

    void Start () {
        HP = new HealthSystem(MaxHealth);
    }

    [Header("Unity Stuff")]
    public Image healthBar;
    
    // Update is called once per frame
    void Update () {
        CurrentHealth = HP.GetHealth();
        healthBar.fillAmount = CurrentHealth / MaxHealth;
        if (CurrentHealth == 0)
        {
            
        }
        if (attacked == true)
        {
            HP.Damage(10);
            attacked = false;
        }
    }
}
