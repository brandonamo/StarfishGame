using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammer : MonoBehaviour {

    HealthSystem healthSystem = new HealthSystem(100.0f);

    public Transform Thingy;
    public Vector3 offset;
    public string WhatIsYourWeapon;
    public GameObject p1;
    P1 player1;
    public GameObject p2;
    P1 player2;
    public GameObject player;
    public bool Possessed;
    public int Test = 10;
    public bool IsPlayerOne=false;
    // Use this for initialization-
    void Start()
    {
        p1 = GameObject.Find("starfish_reboned");
        player1 = p1.GetComponent<P1>();

        p2 = GameObject.Find("starfish_reboned (1)");
        player2 = p2.GetComponent<P1>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player2" && IsPlayerOne == true)
        {
            print("Hit Player 2");
            player2.attacked = true;
        }
        if (other.transform.tag == "Player" && Possessed == false)
        {
            print("Player1 possession");
            Possessed = true;
            IsPlayerOne = true;
        }
        if (other.transform.tag == "Player" && IsPlayerOne == false)
        {
            print("Hit Player 1");
            player1.attacked = true;
        }
        else if (other.transform.tag == "Player2" && Possessed == false)
        {
            print("Player2 possession");
            Possessed = true;
            IsPlayerOne = false;
        }


        //if (other.transform.tag == "Arm" && Attach == false)
        //{
        //    Other = other;
        //    print("Picked up");
        //    Attach = true;
        //}
    }
}