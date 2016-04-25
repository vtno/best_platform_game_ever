using UnityEngine;
using System.Collections;

public class MovingWall_noButton : MonoBehaviour {

	public bool isOpen;
	public Transform openedPosition;
	public Transform closedPosition;
	private float fraction = 0f;

	// Update is called once per frame
	void Update () {

		if (isOpen) {
			if (fraction < 1.0f) {
				fraction += Time.deltaTime;
			}
		} else {
			if (fraction > 0.0f) {
				fraction -= Time.deltaTime;
			}
		}
		Mathf.Clamp (fraction, 0f, 1f);
		transform.position = Vector3.Lerp (closedPosition.position, openedPosition.position, fraction);
	}
}
