using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour
{

	float rotationSpeed = 1.0f;
	public AudioClip pickupSound;

	void Update ()
	{
		transform.RotateAround (transform.position, Vector3.up, rotationSpeed);
	}

	public virtual void OnTriggerEnter (Collider collider)
	{
		if (collider.tag.Equals ("Player")) {
			collider.GetComponent<AudioSource> ().PlayOneShot(pickupSound);
			gameObject.SetActive(false);
		}
	}
}
