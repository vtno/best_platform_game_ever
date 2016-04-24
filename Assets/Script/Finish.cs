using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Finish : Pickup {

	public int nextScene;

	public override void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag.Equals ("Player") && collider.gameObject.GetComponent<PlayerKey> ().key) {
			collider.gameObject.GetComponent<PlayerKey> ().key = false;
			Debug.Log ("finished");
			SceneManager.LoadScene (nextScene);
		}
	}
}
