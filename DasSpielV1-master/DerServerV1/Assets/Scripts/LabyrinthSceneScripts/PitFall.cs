﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitFall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.GetComponent<Health2>().TakeDamage(100);
    }
}
