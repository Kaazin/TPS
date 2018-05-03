using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour 
{
	public GameObject paint;
	public Transform player;
	public Transform fulcrum;
	Quaternion cameraRotation;

	void Awake()
	{
	}
	void Update()
	{
		cameraRotation = Camera.main.transform.rotation;

		if (Input.GetButton ("Fire1")) 
		{
            Vector3 playerAngle = player.eulerAngles;
            playerAngle.y = Camera.main.transform.eulerAngles.y;
            player.eulerAngles = playerAngle;
            
			Instantiate (paint, transform.position, transform.rotation);
		}
	}

}
