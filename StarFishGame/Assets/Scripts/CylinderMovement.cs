﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 1000.0f;
        transform.Rotate(0, 0, -x);
    }
}
