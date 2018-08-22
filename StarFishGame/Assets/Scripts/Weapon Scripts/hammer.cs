using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammer : MonoBehaviour {

    HealthSystem healthSystem = new HealthSystem(100.0f);

    public Transform Thingy;
    public Vector3 offset;
    public string WhatIsYourWeapon;

    public GameObject player;
    public bool Attach = false;

    // Use this for initialization-
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Attach == true)
        {

        }
    }

    Collision Other;
    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Arm" && Attach == false)
        {
            FindObjectOfType<AudioMgr>().Play("pick_up");
            Other = other;
            print("Picked up");
            Attach = true;
        }
        else
        {
            healthSystem.Damage(10.0f);
        }
    }
}