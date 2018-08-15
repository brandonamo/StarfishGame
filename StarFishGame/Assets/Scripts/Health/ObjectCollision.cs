using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour {

    void OnCollisionEnter()
    {
        Debug.Log("We Hit Something!");
    }
}
