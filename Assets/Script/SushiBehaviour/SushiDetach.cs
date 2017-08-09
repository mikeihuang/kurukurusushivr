using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiDetach : MonoBehaviour {

	bool isTouchedByPlayer = false;

	void Update(){
		if (GetComponent<NewtonVR.NVRInteractableItem> ().AttachedHand != null) {
			isTouchedByPlayer = true;
		} else {
			isTouchedByPlayer = false;
		}

		if (isTouchedByPlayer) {
			transform.parent = null;
			GetComponent<Animator> ().enabled = false;
		}
	}
}
