using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour {
    public Rigidbody rb;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        int xdirection;
        if (Input.GetKey("left") && !Input.GetKey("right"))
        {
            xdirection = 1;
        }
        else if (Input.GetKey("right") && !Input.GetKey("left"))
        {
            xdirection = -1;
        }
        else
        {
            xdirection = 0;
        }
        var x = xdirection * Time.deltaTime * 100000.0f;

        int ydirection;
        if (Input.GetKey("up") && !Input.GetKey("down"))
        {
            ydirection = 1;
        }
        else if (Input.GetKey("down") && !Input.GetKey("up"))
        {
            ydirection = -1;
        }
        else
        {
            ydirection = 0;
        }
        var y = ydirection * Time.deltaTime * 100000.0f;
        Vector3 movement = new Vector3(x, y, 0);
        rb.AddForce(movement);
    }
}
