using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraScript : MonoBehaviour {

	public float zoomSpeed = 2, moveSpeed = 1, RotationSpeed = 10;

	private Vector3 basePos;
	private Quaternion baseRot;
	private float baseFoV;
	private Camera localCamera;

	// Use this for initialization
	void Start () {
		localCamera = GetComponent<Camera>();
		baseFoV = localCamera.fieldOfView;
		basePos = transform.position;
		baseRot = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKeyDown)
		{
			// Reset caméra
			if(Input.GetKeyDown(KeyCode.R))
			{
				transform.position = basePos;
				transform.rotation = baseRot;
				localCamera.fieldOfView = baseFoV;
			}
		}
		if(Input.anyKey)
		{
			// Déplacement caméra
			if(Input.GetKey(KeyCode.Mouse2))
			{
				Debug.Log(Input.GetAxis("Mouse X") + " / " + Input.GetAxis("Mouse Y"));

				Vector3 move = new Vector3(Input.GetAxis("Mouse Y") * Mathf.Sin(transform.rotation.y),0,-Input.GetAxis("Mouse X") * Mathf.Cos(transform.rotation.x));
				transform.position += move * moveSpeed * Time.deltaTime;
			}
			// Rotation caméra
			if(Input.GetKey(KeyCode.Mouse1))
			{
				transform.Rotate(new Vector3(0,Input.GetAxis("Mouse X"),Input.GetAxis("Mouse Y")) * RotationSpeed * Time.deltaTime,Space.World);
				transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.eulerAngles.x,transform.rotation.eulerAngles.y,0));
			}
		}
		// Zoom caméra
		if(Input.GetAxis("Mouse ScrollWheel") < 0)
		{
			localCamera.fieldOfView += zoomSpeed;
		} else if (Input.GetAxis("Mouse ScrollWheel") > 0)
		{
			localCamera.fieldOfView -= zoomSpeed;
		}
	}
}