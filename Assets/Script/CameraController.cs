using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	public Transform ball;
	private Vector3 offset;
	private float distance = 6f;
	public float sensitivity = 3.0f;
	protected float fDistance = 1;
	protected float fSpeed = 1;

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
		//transform.position = player.transform.position + offset;
		//if (Input.GetKey(KeyCode.Q)) OrbitTower(false);
		//if (Input.GetKey(KeyCode.E)) OrbitTower(true);
		//if (Input.GetKey(KeyCode.UpArrow)) MoveInOrOut(false);
		//if (Input.GetKey(KeyCode.DownArrow)) MoveInOrOut(true);
	}
	/*
	protected void OrbitTower(bool bLeft)
	{
		float step = fSpeed * Time.deltaTime;
		float fOrbitCircumfrance = 2F * fDistance * Mathf.PI;
		float fDistanceDegrees = (fSpeed / fOrbitCircumfrance) * 360;
		float fDistanceRadians = (fSpeed / fOrbitCircumfrance) * 2 * Mathf.PI;
		if (bLeft)
		{
			transform.RotateAround(transform.position, Vector3.up, -fDistanceRadians);
		}
		else
			transform.RotateAround(transform.position, Vector3.up, fDistanceRadians);
	}

	protected void MoveInOrOut(bool bOut)
	{
		if (bOut)   transform.Translate(0, 0, -fSpeed, Space.Self);
		else
			transform.Translate(0, 0, fSpeed, Space.Self);
	}
*/

}
