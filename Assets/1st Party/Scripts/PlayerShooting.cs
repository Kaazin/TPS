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
			player.transform.parent = Camera.ttmain.tra
			Instantiate (paint, transform.position, transform.rotation);
		}
	}

}
