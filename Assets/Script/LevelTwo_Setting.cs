using UnityEngine;
using System.Collections;

public class LevelTwo_Setting : MonoBehaviour {

	public GameObject item1;
	public GameObject item2;
	public GameObject item3;
	public GameObject item4;
	public GameObject checkpoint1;
	public GameObject player;
	public Transform startPosition;
	public Transform checkpoint1Position;
	public Material playerMaterial;

	void Update() {
		if (player.transform.position.y < -5f) {
			Respawn ();
		}
	}

	void Respawn() {
		if (!checkpoint1.GetComponent<Checkpoint> ().isCurrent) {
			player.GetComponent<Rigidbody> ().isKinematic = true;
			player.transform.position = startPosition.position;
			player.GetComponent<Rigidbody> ().isKinematic = false;
		} else {
			player.GetComponent<Rigidbody> ().isKinematic = true;
			player.transform.position = checkpoint1Position.position;
			player.GetComponent<Rigidbody> ().isKinematic = false;
		}
		player.GetComponent<Renderer> ().material.color = playerMaterial.color;
		player.layer = 0;
		player.GetComponent<PlayerKey> ().key = false;
		player.GetComponent<AudioSource> ().Play ();
		item1.SetActive (true);
		item2.SetActive (true);
		item3.SetActive (true);
		item4.SetActive (true);
	}

}
