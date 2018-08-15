using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 50.0f;
        transform.Translate(x, 0, 0);
        var y = Input.GetAxis("Vertical") * Time.deltaTime * 200.0f;

        if (y > 0)
        {
            transform.Translate(0, y, 0);
        }
    }
}
