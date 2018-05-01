using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour {

	public float smoothing = 0.5f;

	// Update is called once per frame
	void Update () 
	{
		Rotate ();
	}
	void Rotate()
	{
		//if(transform.rotation.y < 360 && transform.rotation.y > -360 && Input.GetAxis("Mouse X") != 0)
			//transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.Euler (0, Input.GetAxis ("Mouse X"), 0), smoothing * Time.deltaTime);
			//transform.Rotate(0, Input.GetAxis ("Mouse X"), 0 * smoothing * Time.deltaTime);

	}

}
