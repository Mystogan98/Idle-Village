﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SunScript : MonoBehaviour {

	public float speed = 1;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//transform.Rotate(Vector3.zero, speed*Time.deltaTime);
		transform.RotateAround (Vector3.zero, Vector3.right, speed * Time.deltaTime);
	}
}
