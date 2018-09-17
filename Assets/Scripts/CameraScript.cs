using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraScript : MonoBehaviour {

	public float zoomSpeed = 2, moveSpeed = 1, RotationSpeed = 1;

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
				Vector3 move = new Vector3(Input.GetAxis("Mouse Y"),0,-Input.GetAxis("Mouse X")); //MouseScript.GetMouseMovement();
				// On change l'ordre des valeurs car les valeurs de la souris sont en 2D
				// move.z = -move.x;
				// move.x = move.y;
				// move.y = 0;
				transform.position += move * moveSpeed * Time.deltaTime;
			}
			// Rotation caméra
			if(Input.GetKey(KeyCode.Mouse1))
			{
				//Debug.Log(localCamera.ScreenToWorldPoint(new Vector3(Screen.width/2,Screen.height/2,localCamera.nearClipPlane)));
				transform.RotateAround(localCamera.ScreenToWorldPoint(new Vector3(Screen.width/2,Screen.height/2,localCamera.nearClipPlane)),Vector3.up,-MouseScript.GetMouseMovement().x * Time.deltaTime * RotationSpeed);
				//transform.RotateAround(Vector3.zero,Vector3.up,-MouseScript.GetMouseMovement().x * Time.deltaTime * RotationSpeed);
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
