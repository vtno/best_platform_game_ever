using UnityEngine;
using System.Collections;

public class MovingTile : MonoBehaviour {
	public bool isOpen;
	public Transform openedPosition;
	public Transform closedPosition;
	private float fraction = 0f;

	// Update is called once per frame
	void Update () {

		if (isOpen) {
			if (fraction < 2.0f) {
				fraction += Time.deltaTime;
			} else {
				isOpen = false;
			}
		} else {
			if (fraction > -2.0f) {
				fraction -= Time.deltaTime;
			} else {
				isOpen = true;
			}
		}
		Mathf.Clamp (fraction, -1f, 1f);
		transform.position = Vector3.Lerp (closedPosition.position, openedPosition.position, fraction);
	}
}
