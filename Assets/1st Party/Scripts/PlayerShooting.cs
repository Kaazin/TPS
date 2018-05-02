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

		if (Input.GetButton ("Fire1")) {
			player.transform.parent = Camera.main.transform;
			player.transform.localRotation = Quaternion.Euler (Vector3.zero);
			Instantiate (paint, transform.position, transform.rotation);
		} else
			player.transform.parent = null;
	}

}
