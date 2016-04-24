using UnityEngine;
using System.Collections;

public class LevelOne_Setting : MonoBehaviour {

	public GameObject green_pu;
	public GameObject red_pu;
	public GameObject yellow_pu;
	public GameObject player;
	public GameObject bridge;
	AudioLauncher al;
	Rigidbody rb;
	Vector3 respawnPosition;
	bool checkpointOnePassed;
	Color respawnColor;
	bool bridgeCreated;

	void Start() {
		respawnColor = player.GetComponent<Renderer> ().material.color;
		al = player.GetComponent<AudioLauncher> ();
		respawnPosition = player.transform.position;
		rb = player.GetComponent<Rigidbody> ();
		GameObject.Find ("bridge").SetActive (false);
		Instantiate (red_pu, new Vector3(8f, 1f, 1.5f), green_pu.transform.rotation);
		Instantiate (green_pu, new Vector3(12f, 4f, 14f), green_pu.transform.rotation);
		Instantiate (yellow_pu, new Vector3 (26f, 1f, 22f), yellow_pu.transform.rotation);
	}

	void Update() {
		if (player.transform.position.y < -5f) {
			Respawn ();
		}
		if (GameObject.Find ("mw1 switch").GetComponent<PushSwitchController> ().status) {
			if (!bridgeCreated) {
				Instantiate (bridge, new Vector3 (28.85f, -0.87f, 5.49f), Quaternion.identity);
				bridgeCreated = true;
			}
		}

		if (player.transform.position.x > 27.5 && player.transform.position.x < 30.5
		   && player.transform.position.z < 0.5 && player.transform.position.z > -2.5 && !checkpointOnePassed) {
			checkpointOnePassed = true;
			respawnPosition = new Vector3 (29f, 0.5f, -1f);
			al.CheckpointSound ();
		}
	}

	void Respawn() {
		if (!checkpointOnePassed) {
			
			if (GameObject.Find ("Red Pickup(Clone)") == null) {
				Instantiate (red_pu, new Vector3 (8f, 1f, 1.5f), red_pu.transform.rotation);
			}
			if (GameObject.Find ("Green Pickup(Clone)") == null) {
				Instantiate (green_pu, new Vector3 (12f, 4f, 14f), green_pu.transform.rotation);
			}
			if (GameObject.Find ("Yellow Pickup(Clone)") == null) {
				Instantiate (yellow_pu, new Vector3 (26f, 1f, 22f), yellow_pu.transform.rotation);
			}
			if (GameObject.Find ("mw1 switch").GetComponent<PushSwitchController> ().status) {
				GameObject.Find ("mw1 switch").GetComponent<PushSwitchController> ().status = false;
				GameObject.Find ("mw1 switch").GetComponent<PushSwitchController> ().UpdateColor ();
				Destroy (GameObject.Find ("bridge(Clone)"));
				bridgeCreated = false;
			}

			player.GetComponent<Renderer> ().material.SetColor ("_Color", respawnColor);

		}

		rb.isKinematic = true;
		rb.position = respawnPosition;
		rb.isKinematic = false;

	}


}
