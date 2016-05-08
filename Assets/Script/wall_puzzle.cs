using UnityEngine;
using System.Collections;
using System;
public class wall_puzzle : MonoBehaviour {
	public GameObject player;
	protected bool isReady = true;
	protected bool isMoved = false;
	public Transform openedPosition;
	public Transform closedPosition;
	private float fraction = 0f;
	protected virtual void OnCollisionEnter(Collision collision){
		if (isReady) {
			Console.Write ("FUCK");
			if (collision.gameObject == player) {
				if (isMoved) {
					if (fraction < 1.0f) {
						fraction += Time.deltaTime;
						isMoved = false;
					}
				} else {
					if (fraction > 0.0f) {
						fraction -= Time.deltaTime;
						isMoved = true;
					}
				}
			}
		}
		Mathf.Clamp (fraction, 0f, 1f);
		transform.position = Vector3.Lerp (closedPosition.position, openedPosition.position, fraction);
	}
}
