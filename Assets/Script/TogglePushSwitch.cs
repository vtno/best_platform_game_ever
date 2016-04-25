using UnityEngine;
using System.Collections;

public class TogglePushSwitch : PushSwitchController {

	public MovingWall mw1;
	public MovingWall mw2;

	protected override void Start(){
	}
	
	protected override void OnCollisionEnter(Collision collision){
		if (isReady) {
			if (collision.gameObject == button) {
				GetComponent<AudioSource> ().Play();
				mw1.isOpen = !mw1.isOpen;
				mw2.isOpen = !mw2.isOpen;
				StartCoroutine (wait());
			}
		}
	}
}
