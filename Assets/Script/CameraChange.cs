using UnityEngine;
using System.Collections;

public class CameraChange : MonoBehaviour {

	public Transform player;
	public Transform puzzle;
	public Camera camera1;
	public Camera camera2;
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (player.position, puzzle.position) <= 15.0f) {
			camera1.enabled = false;
			camera2.enabled = true;
		} else {
			camera1.enabled = true;
			camera2.enabled = false;
		}
		Debug.Log (Vector3.Distance (player.position, puzzle.position));
	}
}
