using UnityEngine;
using System.Collections;

public class LevelThree_Setting : MonoBehaviour {

	public GameObject item1;
	public GameObject item2;
	public GameObject player;
	public Transform startPosition;
	float holdTime = 0.0f;

	public Material playerMaterial;

	void Update() {
		if (Input.GetKey(KeyCode.R)) {
			holdTime += Time.deltaTime;
		} else {
			holdTime = 0;
		}
		if (holdTime >= 1.5f) {
			Respawn ();
			holdTime = 0;
		}
		if (player.transform.position.y < -5f) {
			Respawn ();
		}
	}

	public void Respawn() {
		player.transform.position = startPosition.position;
		player.GetComponent<Renderer> ().material.color = playerMaterial.color;
		player.layer = 0;
		player.GetComponent<PlayerKey> ().key = false;
		player.GetComponent<AudioSource> ().Play ();
		item1.SetActive (true);
		item2.SetActive (true);
	}
}
