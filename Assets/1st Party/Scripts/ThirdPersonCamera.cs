using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour 
{
	Transform player;

	public Vector3 _camOffset;

	public float smoothing = 0.5f;

	Transform fulcrum;
	public float sensitivityX = 4;
	public float sensitivityY = 1;
	float currentX, currentY;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		_camOffset = transform.position - player.position;
		fulcrum = GameObject.Find ("Fulcrum").transform;
	}

	void Update()
	{
		currentX = Input.GetAxis ("Mouse X");
		currentY = Input.GetAxis ("Mouse Y");
		Orbit ();
		Rotate ();
	 }

	void LateUpdate()
	{
		Vector3 newPos = player.position + _camOffset;

		transform.position = Vector3.Slerp (transform.position, newPos, smoothing);


	}

	void Orbit()
	{
		//transform.RotateAround (player.position, Vector3.right, Input.GetAxis("Mouse Y")  * smoothing);
	}
	void Rotate()
	{
		transform.RotateAround (fulcrum.position, Vector3.up, Input.GetAxis("Mouse X")  * smoothing);
	}
}
