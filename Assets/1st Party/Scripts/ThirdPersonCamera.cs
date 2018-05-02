using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour 
{
	Transform player;   //the player's transform

	public Vector3 _camOffset; //the camera's offset from the player

	public float smoothing = 0.5f; // camera smoothing

	Transform fulcrum;  //the point which the camer will rotate around
	public float sensitivityX = 4;  //the sensitivity of the x axis
	public float sensitivityY = 1; //the sensitivity of the y axis
	public float currentX, currentY;   //the current values of mouse x and mouse y

    void Awake()
	{
		Cursor.lockState = CursorLockMode.Locked;
        //set up the references
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		_camOffset = transform.position - player.position;
		fulcrum = GameObject.Find ("Fulcrum").transform;
	}

	void Update()
	{
        //assign a value to current x and current y
		currentX = Input.GetAxis ("Mouse X");
		currentY = Input.GetAxis ("Mouse Y");

        //run the orbit and rotate functions
		Orbit ();

		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Cursor.lockState = CursorLockMode.None;
		}

	 }


	void Orbit()
	{

		transform.RotateAround (fulcrum.position, Vector3.up, Time.deltaTime * currentX * smoothing);
		transform.RotateAround (fulcrum.position, transform.right, Time.deltaTime * -currentY * smoothing);
    }
}

