using UnityEngine;
using System.Collections;

public class PushSwitchController : MonoBehaviour {

	public bool status;
	public GameObject button;
	bool isReady = true;

	void OnCollisionEnter(Collision collision){
		if (isReady) {
			if (collision.gameObject == button) {
				status = !status;
				StartCoroutine (wait());
			}
		}
	}

	IEnumerator wait() {
		isReady = false;
		yield return new WaitForSeconds(5);
		isReady = true;
	}
}
