using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int direction;
        if (Input.GetKey("a") && !Input.GetKey("d"))
        {
            direction = -1;
        }
        else if (Input.GetKey("d") && !Input.GetKey("a"))
        {
            direction = 1;
        }
        else
        {
            direction = 0;
        }
        var x = direction * Time.deltaTime * 1000.0f;
        transform.Rotate(0, 0, x);
    }
}
