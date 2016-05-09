using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {

	public Transform origin;
	public Transform target;
	public GameObject player;
	
	// Update is called once per frame
	public virtual void OnTriggerEnter (Collider collider)
	{
		if (collider.tag.Equals ("Player")) {
			collider.transform.position = target.position;
		}
	}
}
