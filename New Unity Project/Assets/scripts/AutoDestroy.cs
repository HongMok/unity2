﻿using UnityEngine;
using System.Collections;

public class AutoDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
		//sdalfajlfjaslfdj
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnBecameInvisible(){
		Destroy (this.gameObject);
	}
}
