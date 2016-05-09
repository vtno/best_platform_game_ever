using UnityEngine;
using System.Collections;

public class PushSwitchController : MonoBehaviour {

	public bool status;
	public GameObject button;
	protected bool isReady = true;

	protected virtual void Start(){
		UpdateColor ();
	}

	protected virtual void OnCollisionEnter(Collision collision){
		if (isReady) {
			if (collision.gameObject == button) {
				GetComponent<AudioSource> ().Play();
				status = !status;
				UpdateColor ();
				StartCoroutine (wait());
			}
		}
	}

	protected IEnumerator wait() {
		isReady = false;
		yield return new WaitForSeconds(0.5f);
		isReady = true;
	}

	public void UpdateColor(){
		if (status) {
			this.GetComponent<Renderer> ().material.SetColor ("_Color", Color.green);
			button.GetComponent<Renderer> ().material.SetColor ("_Color", Color.green);
		} else {
			this.GetComponent<Renderer> ().material.SetColor ("_Color", Color.red);
			button.GetComponent<Renderer> ().material.SetColor ("_Color", Color.red);
		}
	}
}
