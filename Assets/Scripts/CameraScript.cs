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
	private float rotx, roty;

	// Use this for initialization
	void Start () {
		localCamera = GetComponent<Camera>();
		baseFoV = localCamera.fieldOfView;
		basePos = transform.position;
		baseRot = transform.rotation;

		rotx = transform.rotation.x;
		roty = transform.rotation.y;
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


				// Vector3 rot = transform.rotation.eulerAngles;
				// rot.x += Input.GetAxis("Mouse X") * RotationSpeed * Time.deltaTime;
				// rot.y = Mathf.Clamp(transform.rotation.y + (Input.GetAxis("Mouse Y") * RotationSpeed * Time.deltaTime), -90, 90);
				// transform.rotation = Quaternion.Euler(rot.x,rot.y,rot.z);

				//transform.localRotation = Quaternion.AngleAxis(transform.rotation.x + (Input.GetAxis("Mouse X") * RotationSpeed * Time.deltaTime), Vector3.up);
				//transform.localRotation *= Quaternion.AngleAxis(Mathf.Clamp(transform.rotation.y + (Input.GetAxis("Mouse Y") * RotationSpeed * Time.deltaTime), -90, 90), Vector3.left);

				rotx += (Input.GetAxis("Mouse X") * RotationSpeed * Time.deltaTime);
				roty += (Input.GetAxis("Mouse Y") * RotationSpeed * Time.deltaTime);
				transform.rotation = Quaternion.Euler(rotx, roty, 0);

				//transform.RotateAround(localCamera.ScreenToWorldPoint(new Vector3(Screen.width/2,Screen.height/2,localCamera.nearClipPlane)),Vector3.up,-Input.GetAxis("Mouse X") * Time.deltaTime * RotationSpeed);
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
