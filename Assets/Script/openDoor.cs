using UnityEngine;
using System.Collections;

public class openDoor : PushSwitchController{
	public GameObject wall1;
	public GameObject wall2;
	// Use this for initialization
	void Start () {
		
	}	
	
	protected override void OnCollisionEnter(Collision collision){
		if (isReady) {
			if (collision.gameObject == button) {
				wall1.GetComponent<MovingWall> ().isOpen = !wall1.GetComponent<MovingWall> ().isOpen;
				Debug.Log (wall1.GetComponent<MovingWall> ().isOpen);
				wall2.GetComponent<MovingWall> ().isOpen = !wall2.GetComponent<MovingWall> ().isOpen;
				StartCoroutine (wait());
			}
		}
	}
		
}
