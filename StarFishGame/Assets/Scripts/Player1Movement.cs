using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour {
    public Rigidbody rb;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int direction;
        if (Input.GetKey("a") && !Input.GetKey("d"))
        {
            direction = 1;
        }
        else if (Input.GetKey("d") && !Input.GetKey("a"))
        {
            direction = -1;
        }
        else
        {
            direction = 0;
        }
        var x = direction * 500.0f;

        int ydirection;
        if (Input.GetKey("w") && !Input.GetKey("s"))
        {
            ydirection = 1;
        }
        else if (Input.GetKey("s") && !Input.GetKey("w"))
        {
            ydirection = -1;
        }
        else
        {
            ydirection = 0;
        }
        var y = ydirection * 500.0f;
        Vector3 movement = new Vector3(x, y, 0);
        rb.AddForce(movement);
    }
}
