using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour 
{
	public GameObject paint;
	void Update()
	{
		if (Input.GetButton ("Fire1")) 
		{
			Instantiate (paint, transform.position, transform.rotation);
		}
	}

}
