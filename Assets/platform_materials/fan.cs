using UnityEngine;
using System.Collections;

public class fan : MonoBehaviour {
	float rotationSpeed = 1.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (transform.position, Vector3.up, rotationSpeed);
	}
}
