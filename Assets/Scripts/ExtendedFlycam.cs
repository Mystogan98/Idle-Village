﻿using UnityEngine;
using System.Collections;
 
public class ExtendedFlycam : MonoBehaviour
{
 
	/*
	EXTENDED FLYCAM
		Desi Quintans (CowfaceGames.com), 17 August 2012.
		Based on FlyThrough.js by Slin (http://wiki.unity3d.com/index.php/FlyThrough), 17 May 2011.
 
	LICENSE
		Free as in speech, and free as in beer.
 
	FEATURES
		WASD/Arrows:    Movement
        End:    Toggle cursor locking to screen (you can also press Ctrl+P to toggle play mode on and off).
	*/
 
	public float cameraSensitivity = 90;
	public float normalMoveSpeed = 10;
 
	private float rotationX = 0.0f;
	private float rotationY = 0.0f;
 
	void Start ()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;

		rotationX = transform.rotation.x;
		rotationY = transform.rotation.y;
	}
 
	void Update ()
	{
		if(Input.GetKey(KeyCode.Mouse1))
		{
			rotationX += Input.GetAxis("Mouse X") * cameraSensitivity * Time.deltaTime;
			rotationY += Input.GetAxis("Mouse Y") * cameraSensitivity * Time.deltaTime;
			rotationY = Mathf.Clamp (rotationY, -90, 90);
	
			transform.localRotation = Quaternion.AngleAxis(rotationX, Vector3.up);
			transform.localRotation *= Quaternion.AngleAxis(rotationY, Vector3.left);

			transform.position += transform.forward * normalMoveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
			transform.position += transform.right * normalMoveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
		}
		if (Input.GetKeyDown (KeyCode.End) || Input.GetKeyDown(KeyCode.E))
		{
			//Screen.lockCursor = (Screen.lockCursor == false) ? true : false;
			Cursor.visible = (Cursor.visible == false) ? true : false;
			Cursor.lockState = (Cursor.lockState == CursorLockMode.Locked) ? CursorLockMode.None : CursorLockMode.Locked;
		}
	}
}