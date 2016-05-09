using UnityEngine;
using System.Collections;

public class openDoor : PushSwitchController{
	public GameObject wall1;
	public GameObject wall2;
	
	protected override void OnCollisionEnter(Collision collision){
		if (isReady) {
			//if (collision.gameObject == button) {
			wall1.GetComponent<MovingWall_noButton> ().isOpen = !wall1.GetComponent<MovingWall_noButton> ().isOpen;
			wall2.GetComponent<MovingWall_noButton> ().isOpen = !wall2.GetComponent<MovingWall_noButton> ().isOpen;
				StartCoroutine (wait());
			//}
		}
	}
		
}
