using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour {

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
        var x = direction * Time.deltaTime * 50.0f;
        transform.Translate(-x, 0, 0);
    }
}
