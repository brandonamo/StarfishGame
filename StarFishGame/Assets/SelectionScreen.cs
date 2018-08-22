using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionScreen : MonoBehaviour {

    private int Selection = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Selection >= 2)
        {
            // Do nothing
        }
	}

    void AddOne()
    {
        Selection++;
    }
}
