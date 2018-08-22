using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2 : MonoBehaviour {
    float Health = 100.0f;

    // Use this for initialization
    void Start () {
        HealthSystem HP = new HealthSystem(Health);
    }

    [Header("Unity Stuff")]
    public Image healthBar;

    // Update is called once per frame
    void Update () {
		
	}
}
