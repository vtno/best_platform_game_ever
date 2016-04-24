using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;
	private float distance = 6f;
	public float sensitivity = 3.0f;

	// Use this for initialization
	void Start()
	{
		offset = (transform.position - player.transform.position).normalized * distance;
		transform.position = player.transform.position + offset;
	}

	void Update()
	{
		Quaternion q = Quaternion.AngleAxis(Input.GetAxis ("Mouse X") * sensitivity, Vector3.up);
		offset = q * offset;
		transform.rotation = q * transform.rotation;
		transform.position = player.transform.position + offset;
	}

}
