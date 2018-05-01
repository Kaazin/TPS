using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSplatter : MonoBehaviour
{
	public List<ParticleCollisionEvent> collisionEvents;
	public GameObject splatter;

	public Vector3 rotation;

	ParticleSystem part;

	GameObject Player;

	public float footPos;
	void Awake()
	{
		Player = GameObject.Find("Player");
	}
	void Start()
	{
		part = GetComponent<ParticleSystem>();
		collisionEvents = new List<ParticleCollisionEvent>();
	}

	void OnParticleCollision(GameObject other)
	{

		int numCollisionEvents = part.GetCollisionEvents(other, collisionEvents);

		Rigidbody rb = other.GetComponent<Rigidbody>();
		int i = 0;

		while (i < numCollisionEvents)
		{
			if (!rb)
			{

				Vector3 pos = collisionEvents[i].intersection;
				Quaternion rot = Quaternion.Euler (rotation);

				Instantiate (splatter, new Vector3(pos.x,(Player.transform.position.y + Player.gameObject.transform.localScale.y) - footPos ,pos.z), rot);
			}
			i++;
		}

		Destroy (this.transform.parent.gameObject);
	}
}
