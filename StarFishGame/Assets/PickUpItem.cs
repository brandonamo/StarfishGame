using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour {

    Transform Thingy;
    // Use this for initialization
    void Start () {
		
	}
    bool Attach;
	// Update is called once per frame
	void Update () {
	}
    Collision Other;
    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Weapon" && Attach == false)
        {
            Other = other;
            print("Hello");
            Attach = true;
        }
    }
}