using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammer : MonoBehaviour {

    public Transform Thingy;
    public Vector3 offset;
    public string WhatIsYourWeapon;


    public GameObject player;
    bool Attach = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        print(transform.position);

        if (Attach == true)
        {// something like that.
            transform.position = Thingy.position + offset;
            transform.rotation = Thingy.rotation;
        }
    }

    Collision Other;
    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Arm" && Attach == false)
        {
            Other = other;
            print("Picked up");
            Attach = true;
        }
    }
}