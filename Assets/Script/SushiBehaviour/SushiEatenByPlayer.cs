using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiEatenByPlayer : MonoBehaviour {

	public GameObject SoundController;
	public GameObject ScoreController;

	ParticleSystem FXHeart;

	public bool isEaten = false;

	void Start () {

		if (SoundController == null) {
			SoundController = GameObject.FindGameObjectWithTag ("SoundController");
		}
		if (ScoreController == null) {
			ScoreController = GameObject.FindGameObjectWithTag ("ScoreController");
		}

		FXHeart = GameObject.FindGameObjectWithTag ("HeartParticle").GetComponent<ParticleSystem> ();
	}

	// If getting consumed by player
	void OnTriggerEnter(Collider other){
		if (other.gameObject.layer == 10) { // Layer 10 is player layer
			if (gameObject.layer != 11 && isEaten == false) {
				
				// 1. Play chewing sound
				SoundController.GetComponent<SoundController> ().playCrunchSound ();

				foreach (Transform child in gameObject.transform) {
					if (child.CompareTag ("Sushi")) {

						// 2. Hide the sushi object, leave the plate
						child.gameObject.SetActive (false);
					}
				}

				// 3. Play particle effect
				FXHeart.Play();

				// 4. Sushi Combo + 1
				ScoreController.GetComponent<ScoreController>().SushiCombo += 1;

				// 5. Set the bool state to isEaten
				isEaten = true;

			} else if (gameObject.layer == 11) { // IF this is the non-edible item

				// 1. Play wrong buzzer sound
				SoundController.GetComponent<SoundController> ().playWrongBuzzSound ();

				// 2. Camera color shift
				GameObject.FindGameObjectWithTag("MainCamera").GetComponent<PostProcessingChange>().enabled = true;

				// 3. Sushi Combo reset to zero
				ScoreController.GetComponent<ScoreController>().SushiCombo = 0;
			}
		}
	} // End of getting consumed by player
}
