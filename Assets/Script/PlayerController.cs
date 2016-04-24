using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	GameObject ball;
	Rigidbody rb;
	float speed;
	bool isGrounded;
	Vector3 respawnPoint;
	private Vector3 move;
	// the world-relative desired move direction, calculated from the camForward and user input.

	private Transform cam; // A reference to the main camera in the scenes transform
	private Vector3 camForward; // The current forward direction of the camera
	private bool jump; // whether the jump button is currently pressed

	[SerializeField] private float m_MovePower = 5; // The force added to the ball to move it.
	[SerializeField] private bool m_UseTorque = true; // Whether or not to use torque to move the ball.
	[SerializeField] private float m_MaxAngularVelocity = 25; // The maximum velocity the ball can rotate at.
	[SerializeField] private float m_JumpPower = 1; // The force added to the ball when it jumps.

	private const float k_GroundRayLength = 1f; // The length of the ray to check if the ball is grounded.
	private Rigidbody m_Rigidbody;


	// Use this for initialization
	void Start () {
		respawnPoint = this.transform.position;
		rb = GetComponent<Rigidbody> ();
		speed = 10f;
		if (Camera.main != null) {
			cam = Camera.main.transform;
		} else {
			Debug.LogWarning (
				"Warning: no main camera found. Ball needs a Camera tagged \"MainCamera\", for camera-relative controls.");
		}
	}

	void Update () {

		if (this.transform.position.y < 0) {
			rb.isKinematic = true;
			Respawn ();
		}

		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		jump = Input.GetButton("Jump");

		// calculate move direction
		if (cam != null)
		{
			// calculate camera relative direction to move:
			camForward = Vector3.Scale(cam.forward, new Vector3(1, 0, 1)).normalized;
			move = (v*camForward + h*cam.right).normalized;
		}
		else
		{
			// we use world-relative directions in the case of no main camera
			move = (v*Vector3.forward + h*Vector3.right).normalized;
		}
	}
		
	void FixedUpdate () {
		
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		jump = Input.GetButton("Jump");

		// calculate move direction
		if (cam != null)
		{
			// calculate camera relative direction to move:
			camForward = Vector3.Scale(cam.forward, new Vector3(1, 0, 1)).normalized;
			move = (v*camForward + h*cam.right).normalized;
		}
		else
		{
			// we use world-relative directions in the case of no main camera
			move = (v*Vector3.forward + h*Vector3.right).normalized;
		}

		Move(move, jump);
		jump = false;

	}

	void OnCollisionEnter(Collision c){
		if(c.gameObject.tag == "Ground")
		{
			isGrounded = true;
		}
	}

	public void Move(Vector3 moveDirection, bool jump)
	{
		// If using torque to rotate the ball...
		if (m_UseTorque)
		{
			// ... add torque around the axis defined by the move direction.
			m_Rigidbody.AddTorque(new Vector3(moveDirection.z, 0, -moveDirection.x)*m_MovePower);
		}
		else
		{
			// Otherwise add force in the move direction.
			m_Rigidbody.AddForce(moveDirection*m_MovePower);
		}

		// If on the ground and jump is pressed...
		if (Physics.Raycast(transform.position, -Vector3.up, k_GroundRayLength) && jump)
		{
			// ... add force in upwards.
			m_Rigidbody.AddForce(Vector3.up*m_JumpPower, ForceMode.Impulse);
		}
	}

	void Respawn () {
		this.transform.position = respawnPoint;
		rb.isKinematic = false;
	}
		
}
