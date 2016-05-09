using UnityEngine;
using System.Collections;

public class AudioLauncher : MonoBehaviour {

	public AudioClip collect;
	public AudioClip switchOn;
	public AudioClip checkpoint;
	public AudioClip respawnSound;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}

	void OnTriggerEnter (Collider collider)
	{
		if (collider.gameObject.tag.Equals ("Pick Up")) {
			audio.PlayOneShot(collect, 0.7F);
		}
	}

	public void ActivateSwitchSound()
	{
		audio.PlayOneShot (switchOn, 0.5F);
	}

	public void CheckpointSound()
	{
		audio.PlayOneShot (checkpoint, 0.7F);
	}

	public void RespawnSound()
	{
		audio.PlayOneShot (respawnSound, 0.7F);
	}

}
