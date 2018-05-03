using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour 
{
    public Transform gun;

	Transform player;   //the player's transform

	public Vector3 _camOffset; //the camera's offset from the player

	public float smoothing = 0.5f; // camera smoothing

	Transform fulcrum;  //the point which the camer will rotate around
	public float sensitivityX = 4;  //the sensitivity of the x axis
	public float sensitivityY = 1; //the sensitivity of the y axis
	public float currentX, currentY;   //the current values of mouse x and mouse y

    public Transform gunbase;
    Quaternion gunRot;

    void Awake()
	{
        //disable the cursor so the player doesn't accidentally click out of the window
		Cursor.lockState = CursorLockMode.Locked;
        //set up the references
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		fulcrum = GameObject.Find ("Fulcrum").transform;
	}

	void Update()
	{


        //set the camera's position relatvie to its offset

        transform.position = player.position - _camOffset;

        //assign a value to current x and current y
		currentX = Input.GetAxis ("Mouse X");
		currentY = Input.GetAxis ("Mouse Y");

        //run the orbit and rotate functions
		Orbit ();

        gun.localRotation = Quaternion.Euler(transform.rotation.x, player.rotation.y, 0);

        //if the escape key is pressed
        if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Cursor.lockState = CursorLockMode.None;
		}


    }

    void Orbit()
	{
        transform.RotateAround(fulcrum.position, Vector3.up, Time.deltaTime * currentX * smoothing);
        transform.RotateAround(fulcrum.position, transform.right, Time.deltaTime * -currentY * smoothing);

            //Vector3 gunAngle = gun.eulerAngles;
            //gunAngle.x = Camera.main.transform.eulerAngles.x;
           // gun.eulerAngles = gunAngle;

    }
}

