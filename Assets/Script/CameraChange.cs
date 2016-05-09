using UnityEngine;
using System.Collections;

public class CameraChange : MonoBehaviour {

	public Transform player;
	public Transform puzzle;
	bool reset = false;
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (player.position, puzzle.position) <= 15.0f) {
			GetComponent<CameraController> ().puzzle = true;
			reset = false;
		} else {
			GetComponent<CameraController> ().puzzle = false;
			if (!reset) {
				GetComponent<CameraController> ().resetCamera ();
				reset = true;
			}
		}
		Debug.Log (Vector3.Distance (player.position, puzzle.position));
	}
}
