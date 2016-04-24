using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	public void StartScene(int num){
		SceneManager.LoadScene (num);
	}

	public void Exit(){
		Application.Quit ();
	}
}
