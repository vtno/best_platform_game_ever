using UnityEngine;
using System.Collections;

public class PushSwitchController : MonoBehaviour {

	public bool status;
	public GameObject button;
	public GameObject RollerBall;
	AudioLauncher al;
	bool isReady = true;

	void Start(){
		al = RollerBall.GetComponent<AudioLauncher> ();
		UpdateColor ();
	}

	void OnCollisionEnter(Collision collision){
		if (isReady) {
			if (collision.gameObject == button) {
				status = !status;
				UpdateColor ();
				StartCoroutine (wait());
			}
		}
	}

	IEnumerator wait() {
		isReady = false;
		yield return new WaitForSeconds(0.5f);
		isReady = true;
	}

	public void UpdateColor(){
		if (status) {
			al.ActivateSwitchSound ();
			this.GetComponent<Renderer> ().material.SetColor ("_Color", Color.green);
			button.GetComponent<Renderer> ().material.SetColor ("_Color", Color.green);
		} else {
			this.GetComponent<Renderer> ().material.SetColor ("_Color", Color.red);
			button.GetComponent<Renderer> ().material.SetColor ("_Color", Color.red);
		}
	}
}
