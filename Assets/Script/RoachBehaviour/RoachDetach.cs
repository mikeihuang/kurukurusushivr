using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoachDetach : MonoBehaviour {

	bool isTouchedByPlayer = false;
	public GameObject SoundController;

	void Start(){
		if (SoundController == null) {
			SoundController = GameObject.FindGameObjectWithTag ("SoundController");
		}
	}



	void Update(){
		if (GetComponent<NewtonVR.NVRInteractableItem> ().AttachedHand != null) {
			isTouchedByPlayer = true;
		} else {
			isTouchedByPlayer = false;
		}

		if (isTouchedByPlayer) {
			SoundController.GetComponent<SoundController> ().playLaserSound ();
			transform.parent = null;
			GetComponent<Animator> ().enabled = false;
			GetComponent<DestroyRoach> ().DestroyNow ();
		}
	}
}
