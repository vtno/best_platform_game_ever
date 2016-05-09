using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NextLevelPanelController : MonoBehaviour {

	public Finish finish;
	public GameObject thePanel;

	void Update(){
		if (finish.finished) {
			thePanel.SetActive (true);
		}
	}
}
