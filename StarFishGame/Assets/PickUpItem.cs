using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour {

    public Transform OtherItem;
    public Transform offsetRotation;
    // Use this for initialization
    void Start () {

    }
    bool Attach;
	// Update is called once per frame
	void Update () {

        if (Attach == true)
        {
            OtherItem.Rotate(Vector3.right * Time.deltaTime);
            print("OtherPickUp");
            OtherItem.position = transform.position;
            OtherItem.rotation = transform.rotation ;
        }
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Weapon" && Attach == false)
        {
            print("Hello");
            Attach = true;
        }
    }
}