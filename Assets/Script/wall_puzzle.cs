using UnityEngine;
using System.Collections;
using System;

public class wall_puzzle : MonoBehaviour
{
	public GameObject player;
	public bool isMoving = false;
	public bool isReady = true;
	public bool direction = true;
	public Vector3 forward;
	public Vector3 back;

	void Update ()
	{
		if (!isMoving) {
			GetComponent<Rigidbody> ().velocity = Vector3.zero;
		} else {
			if (direction) {
				GetComponent<Rigidbody> ().AddForce (forward * 10f, ForceMode.Force);
			} else {
				GetComponent<Rigidbody> ().AddForce (back * 10f, ForceMode.Force);
			}
		}
	}

	protected virtual void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.tag.Equals ("Player") && !isMoving && isReady) {
			wait ();
			isMoving = true;
			Debug.Log ("hello");
		} else if (collision.gameObject.tag.Equals ("Wall") && isMoving) {
			direction = !direction;
			isMoving = false;
		}
	}

	protected IEnumerator wait() {
		isReady = false;
		yield return new WaitForSeconds(0.5f);
		isReady = true;
	}
}
