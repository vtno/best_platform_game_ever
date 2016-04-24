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
<<<<<<< HEAD:Assets/Pickup.cs
=======
			Debug.Log ("Aloha Snackbar");
>>>>>>> f5ac4cf17400583f57405f2c81ba26efacd07afa:Assets/Script/Pickup.cs
			Destroy (this.gameObject);
		}
	}
}
