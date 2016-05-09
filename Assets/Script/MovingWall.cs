using UnityEngine;
using System.Collections;

public class MovingWall : MonoBehaviour {

	public bool isOpen;
	public Transform openedPosition;
	public Transform closedPosition;
	private float fraction = 0f;
	public bool useButton = false;
	public GameObject button;

	// Update is called once per frame
	void Update () {
		if (useButton) {
			if (button.GetComponent<PushSwitchController> () != null) {
				isOpen = button.GetComponent<PushSwitchController> ().status;
			}
		}
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
