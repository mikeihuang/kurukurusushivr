using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	// Fade Camera
	public GameObject camera;

	// Game Over State
	static public bool isGameover = false;

	void Start () {
		isGameover = false;
	}

	void Update () {
		// DEV USE: Press R to restart
		if (Input.GetKeyDown (KeyCode.R)) {
			StartCoroutine(RestartScene());
		}
	}


	// Call this function to go back to Title Screen
	public void GoBackToTitle(){
		StartCoroutine (GoToTitle ());
	}

	// Call this function to restart game
	public void RestartSceneNow(){
		StartCoroutine(RestartScene());
	}


	IEnumerator RestartScene(){
		camera.GetComponent<OVRScreenFade>().StartFadeOut ();
		yield return new WaitForSeconds (1.95f);
		SceneManager.LoadScene ("KuruKuruMain");
	}

	IEnumerator GoToTitle(){
		camera.GetComponent<OVRScreenFade>().StartFadeOut ();
		yield return new WaitForSeconds (1.95f);
		SceneManager.LoadScene ("Title");
	}
}
