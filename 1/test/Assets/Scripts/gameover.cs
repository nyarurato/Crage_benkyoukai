﻿using UnityEngine;
using System.Collections;

public class gameover : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag.Equals("myks")) {
			Application.LoadLevel ("gameover");
		}
	}
}
