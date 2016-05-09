using UnityEngine;
using System.Collections;

public class ChangeEthanColour : MonoBehaviour {

	public GameObject ethan;
	
	// Update is called once per frame
	void Update () {
		Color myColor = this.GetComponent<Renderer> ().material.color;
		ethan.gameObject.GetComponent<Renderer> ().material.SetColor ("_Color", myColor);
	}
}
