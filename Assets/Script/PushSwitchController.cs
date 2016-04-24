﻿using UnityEngine;
using System.Collections;

public class PushSwitchController : MonoBehaviour {

	public bool status;
	public GameObject button;
	protected bool isReady = true;

	void Start(){
		UpdateColor ();
	}

	protected virtual void OnCollisionEnter(Collision collision){
		if (isReady) {
			if (collision.gameObject == button) {
				Debug.Log("KUY");
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

	protected void UpdateColor(){
		if (status) {
			this.GetComponent<Renderer> ().material.SetColor ("_Color", Color.green);
			button.GetComponent<Renderer> ().material.SetColor ("_Color", Color.green);
		} else {
			this.GetComponent<Renderer> ().material.SetColor ("_Color", Color.red);
			button.GetComponent<Renderer> ().material.SetColor ("_Color", Color.red);
		}
	}
}
