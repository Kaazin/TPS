using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	public float speed;

	Vector3 dir;

	CharacterController controller;


	void Awake () 
	{
		controller = GetComponent<CharacterController> ();
	}
	
	void Update () 
	{
		float moveH = Input.GetAxis ("Horizontal") * speed;
;
		float moveV = Input.GetAxis ("Vertical") * speed;


		dir = new Vector3 (moveH, dir.y, moveV) ;
	
		controller.Move (this.transform.rotation* dir * Time.deltaTime);
	}
}
