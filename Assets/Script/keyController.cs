using UnityEngine;
using System.Collections;

public class keyController : Pickup {
	float rotationSpeed = 1.0f;
	
	// Update is called once per frame
	void Update () {
	transform.RotateAround (transform.position, Vector3.up, rotationSpeed);
	}
	override public void OnTriggerEnter (Collider collider)
	{
		if (collider.gameObject.tag.Equals ("Player")) {
			Debug.Log("FUCK");
			if(!collider.gameObject.GetComponent<BallUserControl> ().key){
				
				collider.gameObject.GetComponent<BallUserControl> ().key = true;	
			}
			Destroy (this.gameObject);
		}
	}
}
