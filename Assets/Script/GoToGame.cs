using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGame : MonoBehaviour {

	float Timer = 0F;
	float TriggerActivationTime = 3F;
	bool isGoingToNextScene = false;

	public GameObject PlayerHead;

	void Start () {
		Timer = 0F;
	}
	
	void OnTriggerStay (Collider other){
		if (Time.timeSinceLevelLoad > 2F) {
			if (other.gameObject.layer == 10) {
				Timer += 1F * Time.deltaTime;
			}
		}
	}

	void OnTriggerExit(Collider other){ // Reset timer if player exits portal
		if (other.gameObject.layer == 10) {
			Timer = 0F;
		}
	}

	void Update(){
		if (isGoingToNextScene == false) {
			if (Timer > TriggerActivationTime) {
				StartCoroutine (GoToNextSceneNow());
				isGoingToNextScene = true;
			}
		}

		// In case space is limited: FOR DEMO PURPOSES force going to next screen
		if (Input.GetKeyDown("space")){
			StartCoroutine (GoToNextSceneNow());
			isGoingToNextScene = true;
		}


	} // End of Update

	IEnumerator GoToNextSceneNow(){
		PlayerHead.GetComponent<OVRScreenFade> ().StartFadeOut ();
		yield return new WaitForSeconds (1.98F);
		SceneManager.LoadScene ("KuruKuruMain");
	}
}
