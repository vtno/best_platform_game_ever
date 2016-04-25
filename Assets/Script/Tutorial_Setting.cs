using UnityEngine;
using System.Collections;

public class Tutorial_Setting : MonoBehaviour {

	public GameObject player;
	public Transform startPosition;
	public GameObject item1;
	public GameObject item2;
	public GameObject item3;
	public GameObject checkpoint1;
	public Transform checkpoint1Position;

	void Update () {
		if (player.transform.position.y <= -5f) {
			if (!checkpoint1.GetComponent<Checkpoint> ().isCurrent) {
				player.GetComponent<Rigidbody> ().isKinematic = true;
				player.transform.position = startPosition.position;
				player.GetComponent<Rigidbody> ().isKinematic = false;
			} else {
				player.GetComponent<Rigidbody> ().isKinematic = true;
				player.transform.position = checkpoint1Position.position;
				player.GetComponent<Rigidbody> ().isKinematic = false;
			}
			player.GetComponent<PlayerKey> ().key = false;
			player.GetComponent<AudioSource> ().Play ();
			item1.SetActive (true);
			item2.SetActive (true);
			item3.SetActive (true);
		}
	}
}
