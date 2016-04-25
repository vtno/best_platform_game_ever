using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Finish : Pickup
{

	public int nextScene;
	public bool finished = false;

	public override void OnTriggerEnter (Collider collider)
	{
		if (collider.gameObject.tag.Equals ("Player") && collider.gameObject.GetComponent<PlayerKey> ().key) {
			finished = true;
			GetComponent<AudioSource> ().Play();
			collider.gameObject.GetComponent<PlayerKey> ().key = false;
			Debug.Log ("finished");
			//SceneManager.LoadScene (nextScene);
		}
	}
}
