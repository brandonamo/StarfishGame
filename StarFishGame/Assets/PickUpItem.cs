using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour {

    public Transform OtherItem;

    GameObject WeaponObj;
    hammer hammerScript;
    GameObject WeaponObj1;
    hammer hammerScript1;
    // Use this for initialization
    void Start () {
        WeaponObj = GameObject.Find("Hammer (1)");
        hammerScript = WeaponObj.GetComponent<hammer>();
       // WeaponObj1 = GameObject.Find("Hammer (2)");
       // hammerScript1 = WeaponObj1.GetComponent<hammer>();
    }
    bool Attach;
	// Update is called once per frame
	void Update () {

        if (Attach == true)
        {
            OtherItem.Rotate(Vector3.right * Time.deltaTime);
            OtherItem.position = transform.position;
            OtherItem.rotation = transform.rotation;
        }
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Weapon" && Attach == false && hammerScript.Possessed == false)
        {
            Attach = true;
            print(hammerScript.Test);
        }
    }
}