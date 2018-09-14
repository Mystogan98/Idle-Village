using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour {

	private static Vector3 last = Vector3.zero, diff = Vector3.zero;
	
	// Update is called once per frame
	void Update () {
		if (last == Vector3.zero)
		{
			last = Input.mousePosition;
			return;
		}
		diff = Input.mousePosition - last;
		last = Input.mousePosition;
	}

	public static Vector3 GetMouseMovement()
	{
		return diff;
	}
}
