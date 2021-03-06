using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

	private const float Y_ANGLE_MIN = 0.0f;
	private const float Y_ANGLE_MAX = 50.0f;

	public Transform lookAt;
	public Transform CamTransform;

	private Camera cams;
	private float distance = 10.0f;
	private float currentX = 0.0f;
	private float currentY = 300.0f;
	private float sensitivityX = 4.0f;
	private float sensitivityY = 1.0f;


	private void Start(){

		CamTransform = transform;
	

	}

	private void Update(){

		//The player can use the mouse to move the camera and see his route from different positions.
		currentX += Input.GetAxis("Mouse X");
		currentY += Input.GetAxis("Mouse Y");

		currentY = Mathf.Clamp (currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);

	}
	private void LateUpdate (){

		Vector3  dir = new Vector3 (0, 0, -distance);
		Quaternion rotation = Quaternion.Euler (currentY, currentX, 0);
		CamTransform.position = lookAt.position + rotation * dir;
		CamTransform.LookAt (lookAt.position);

			
	}
}
