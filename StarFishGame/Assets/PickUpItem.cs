using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public bool Attach;
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Weapon")
        {
            Attach = true;
        }
    }
}
