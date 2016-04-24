using UnityEngine;
using System.Collections;

public class Key : Pickup
{

	public override void OnTriggerEnter (Collider collider)
	{
		if (collider.gameObject.tag.Equals ("Player")) {
			collider.gameObject.GetComponent<PlayerKey> ().key = true;
			Destroy (this.gameObject);
		}
	}
}
