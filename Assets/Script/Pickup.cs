using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour
{

	float rotationSpeed = 1.0f;

	void Update ()
	{
		transform.RotateAround (transform.position, Vector3.up, rotationSpeed);
	}

	public virtual void OnTriggerEnter (Collider collider)
	{
		if (collider.gameObject.tag.Equals ("Player")) {
			Debug.Log ("Aloha Snackbar");
			Destroy (this.gameObject);
		}
	}
}
