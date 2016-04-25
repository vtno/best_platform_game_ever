using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

	public bool isCurrent = false;

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag.Equals ("Player") && !isCurrent) {
			GetComponent<AudioSource> ().Play();
			isCurrent = true;
		}
	}
}
