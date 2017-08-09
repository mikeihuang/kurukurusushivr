using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObjHit : MonoBehaviour {

	public GameObject SoundController;
	public bool isHit = false;

	void Start () {

		if (SoundController == null) {
			SoundController = GameObject.FindGameObjectWithTag ("SoundController");
		}
	}

	void OnCollisionEnter(Collision collision){

		if (collision.gameObject.tag == "SushiPlate" || collision.gameObject.tag == "Sushi") {



			if (isHit == false) {

				// 1. Play explosion and sound
				SoundController.GetComponent<SoundController> ().playExplodeSound ();
				if (collision.transform.Find ("ExplosionSFX").gameObject != null) {
					collision.transform.Find ("ExplosionSFX").gameObject.SetActive (true);
					collision.transform.Find ("ExplosionSFX").gameObject.transform.parent = null;
				}

				// 2. Disable rigidbody is kinematic
				if (GetComponent<Rigidbody> () != null) {
					GetComponent<Rigidbody> ().isKinematic = false;
				}

				// 3. Disable Position Y lerping (for Lanterns)
				if (GetComponent<PositionYLerpBeatsUp> () != null) {
					GetComponent<PositionYLerpBeatsUp> ().enabled = false;
				}
				if (GetComponent<PositionYLerpBeatsDown> () != null) {
					GetComponent<PositionYLerpBeatsDown> ().enabled = false;
				}

				// 4. Disable any animator
				if (GetComponent<Animator> () != null) {
					GetComponent<Animator> ().enabled = false;
				}

				// 5. Detach from parent
				transform.parent = null;

				// 6. Is Hit True
				isHit = true;
			} else {

				// 1. Play Sound Effect
				SoundController.GetComponent<SoundController> ().playCollideSound();
			}

			// 7. +1 on Bill
			GameObject.FindGameObjectWithTag ("ScoreController").GetComponent<ScoreController> ().CurrentDamage += 1F;

			if (gameObject.tag == "StoneLantern") {
				GameObject.FindGameObjectWithTag ("ScoreController").GetComponent<ScoreController> ().CurrentScore += 10F;
			} else if (gameObject.tag == "Lantern") {
				GameObject.FindGameObjectWithTag ("ScoreController").GetComponent<ScoreController> ().CurrentScore += 30F;
			} else if (gameObject.tag == "Goldfish") {
				GameObject.FindGameObjectWithTag ("ScoreController").GetComponent<ScoreController> ().CurrentScore += 100F;
			} else if (gameObject.tag == "UFO") {
				GameObject.FindGameObjectWithTag ("ScoreController").GetComponent<ScoreController> ().CurrentScore += 500F;
			}

		}
	}
}
