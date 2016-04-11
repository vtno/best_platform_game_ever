using UnityEngine;
using System.Collections;

public class MainController : MonoBehaviour {

	public GameObject playerPrefab;

	// Use this for initialization
	void Start () {
		Vector3 startPoint = new Vector3 (4f, 5f, 0f);
		Instantiate (playerPrefab, startPoint, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
