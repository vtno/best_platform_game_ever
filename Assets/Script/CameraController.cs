using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;
	private Quaternion defaultRotation;
	private float distance = 6f;
	public float sensitivity = 3.0f;
	public bool puzzle = false;
	public Transform puzzleCamPos;

	// Use this for initialization
	void Start()
	{
		offset = (transform.position - player.transform.position).normalized * distance;
		defaultRotation = transform.rotation;
		transform.position = player.transform.position + offset;
	}

	void Update()
	{
		if (!puzzle) {
			Quaternion q = Quaternion.AngleAxis (Input.GetAxis ("Mouse X") * sensitivity, Vector3.up);
			offset = q * offset;
			transform.rotation = q * transform.rotation;
			transform.position = player.transform.position + offset;
		} else {
			transform.position = puzzleCamPos.position;
			transform.rotation = Quaternion.Euler (new Vector3 (89, 0, 0));
		}
	}

	public void resetCamera(){
		transform.position = player.transform.position + offset;
		transform.rotation = defaultRotation;
	}

}
