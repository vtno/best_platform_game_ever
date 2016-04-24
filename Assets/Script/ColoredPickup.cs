using UnityEngine;
using System.Collections;

public class ColoredPickup : Pickup {

	public override void OnTriggerEnter (Collider collider)
	{
		if (collider.gameObject.tag.Equals ("Player")) {
			Color myColor = this.GetComponent<Renderer> ().material.color;
			collider.gameObject.GetComponent<Renderer> ().material.SetColor ("_Color", myColor);
			if (myColor.Equals (Color.red)) {
				collider.gameObject.layer = 8;
			} else if (myColor.Equals (Color.green)) {
				collider.gameObject.layer = 9;
			} else if (myColor.Equals (Color.blue)) {
				collider.gameObject.layer = 10;
<<<<<<< HEAD
			} else if (myColor.Equals (Color.yellow)) {
=======
			} else if (myColor.Equals (new Color(1, 1, 0))) {
>>>>>>> mickey/UI
				collider.gameObject.layer = 11;
			} else {
				collider.gameObject.layer = 0;
			}
		}
		base.OnTriggerEnter (collider);
	}
}
