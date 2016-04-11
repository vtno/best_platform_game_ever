using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	Rigidbody rb;
	float speed;
	bool isGrounded;
	Vector3 respawnPoint;

	// Use this for initialization
	void Start () {
		respawnPoint = this.transform.position;
		rb = GetComponent<Rigidbody> ();
		speed = 10f;
	}

	void Update () {
		if (this.transform.position.y < 0) {
			rb.isKinematic = true;
			Respawn ();
		}
	}
		
	void FixedUpdate () {
		
		float moveHorizontal = Input.GetAxis ("Horizontal");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);
		rb.AddForce (speed * movement);

		if (Input.GetKeyDown ("space") && isGrounded){
			rb.AddForce (Vector3.up * 10f, ForceMode.Impulse);
			isGrounded = false;
		} 

	}

	void OnCollisionEnter(Collision c){
		if(c.gameObject.tag == "Ground")
		{
			isGrounded = true;
		}
	}

	void Respawn () {
		this.transform.position = respawnPoint;
		rb.isKinematic = false;
	}
		
}
