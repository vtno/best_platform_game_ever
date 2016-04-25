using UnityEngine;
using System.Collections;

public class PusherBlockMovement : MonoBehaviour {

	public GameObject myBlock;
	public Transform startPosition;
	public Transform endPosition;
	private float fraction = 0f;
	private bool isEnd;

	// Update is called once per frame
	void Update () {
		if (isEnd) {
			if (fraction < 3.0f) {
				fraction += Time.deltaTime;
			} else {
				isEnd = false;
			}
		} else {
			if (fraction > -3.0f) {
				fraction -= Time.deltaTime;
			} else {
				isEnd = true;
			}
		}
		Mathf.Clamp (fraction, 0f, 3f);
		transform.position = Vector3.Lerp (endPosition.position, startPosition.position, fraction);
	}
}
