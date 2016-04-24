using UnityEngine;
using System.Collections;

public class ColoredWall : MonoBehaviour {

	public Material pickupColor;

	// Use this for initialization
	void Start (){
		Color myColor = pickupColor.color;
		if (myColor.Equals (Color.red)) {
			this.gameObject.layer = 8;
		} else if (myColor.Equals (Color.green)) {
			this.gameObject.layer = 9;
		} else if (myColor.Equals (Color.blue)) {
			this.gameObject.layer = 10;
		} else {
			this.gameObject.layer = 0;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
