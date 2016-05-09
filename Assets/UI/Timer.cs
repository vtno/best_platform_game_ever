using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float timePassed;
	public Text timeText;
	public Finish finish;

	void Update () {
		if (!finish.finished) {
			timePassed += Time.deltaTime;
		}
		float minutes = Mathf.Floor(timePassed / 60.0f);
		float seconds = Mathf.Floor (timePassed % 60.0f);
		float miliseconds = Mathf.Floor ((timePassed % 1) * 1000.0f);
		timeText.text = minutes + " : " + seconds + " : " + miliseconds;
	}
}
