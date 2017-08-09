using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NekoCounterHit : MonoBehaviour {

	public GameObject SoundController;
	float OriginalScaleY;

	void Start () {

		if (SoundController == null) {
			SoundController = GameObject.FindGameObjectWithTag ("SoundController");
		}

		OriginalScaleY = transform.localScale.y;
	}

	void OnCollisionEnter(Collision collision){

		if (collision.gameObject.tag == "SushiPlate") {

			// 1. Play squeaky sound
			SoundController.GetComponent<SoundController> ().playSqueakySound ();

			// 2. Animate = make Y scale bigger
			transform.localScale = new Vector3 (transform.localScale.x, transform.localScale.y + 0.15F, transform.localScale.z);

			// 4. +1 on Bill
			GameObject.FindGameObjectWithTag ("ScoreController").GetComponent<ScoreController> ().CurrentDamage += 1F;
			GameObject.FindGameObjectWithTag ("ScoreController").GetComponent<ScoreController> ().CurrentScore += Random.Range(5F, 20F);
		}
	}

	void Update(){
		
		// 3. Make Y scale back to normal
		if (transform.localScale.y > OriginalScaleY){
			transform.localScale = new Vector3 (transform.localScale.x, transform.localScale.y - 0.5F*Time.deltaTime, transform.localScale.z);
		}
	}
}
