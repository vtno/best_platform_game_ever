using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	Rigidbody rb;
	float speed;
	public bool key = false;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		speed = 10f;
	}

	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (speed * movement);
		if (Input.GetKeyDown ("space")){
			rb.AddForce (Vector3.up * 2f, ForceMode.Impulse);
		} 
	}
}
