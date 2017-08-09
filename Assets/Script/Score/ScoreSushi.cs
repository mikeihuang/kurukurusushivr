using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSushi : MonoBehaviour {

	public GameObject ScoreController;
	float SushiValue;
	bool ScoreAdded = false;

	void Start () {
		if (ScoreController == null) {
			ScoreController = GameObject.FindGameObjectWithTag ("ScoreController");
		}

		if (gameObject.name == "Plate01(Clone)") {
			SushiValue = 1.25F;
		} else if (gameObject.name == "Plate02(Clone)") {
			SushiValue = 1.25F;
		} else if (gameObject.name == "Plate03(Clone)") {
			SushiValue = 1.50F;
		} else if (gameObject.name == "Plate04(Clone)") {
			SushiValue = 2.50F;
		} else if (gameObject.name == "Plate05(Clone)") {
			SushiValue = 3.50F;
		} else if (gameObject.name == "Plate06(Clone)") {
			SushiValue = 5.25F;
		} else if (gameObject.name == "Plate07(Clone)") {
			SushiValue = 5.75F;
		} else if (gameObject.name == "Plate08(Clone)") {
			SushiValue = 5.75F;
		} else if (gameObject.name == "Plate09(Clone)") {
			SushiValue = 6.25F;
		} else if (gameObject.name == "Plate10(Clone)") {
			SushiValue = 0F;
		} else if (gameObject.name == "Plate11(Clone)") {
			SushiValue = 0F;
		} else if (gameObject.name == "Plate12(Clone)") {
			SushiValue = 0F;
		} else if (gameObject.name == "Plate13(Clone)") {
			SushiValue = 0F;
		} else if (gameObject.name == "Plate14(Clone)") {
			SushiValue = 0F;
		} else if (gameObject.name == "Plate15(Clone)") {
			SushiValue = 0F;
		} else if (gameObject.name == "Plate16(Clone)") {
			SushiValue = 8.50F;
		} else if (gameObject.name == "Plate17(Clone)") {
			SushiValue = 8.50F;
		} else if (gameObject.name == "Plate18(Clone)") {
			SushiValue = 12.75F;
		} else if (gameObject.name == "Plate19(Clone)") {
			SushiValue = 18.25F;
		} else if (gameObject.name == "Plate20(Clone)") {
			SushiValue = 24.25F;
		} else if (gameObject.name == "Plate21(Clone)") {
			SushiValue = 33.25F;
		} else if (gameObject.name == "Plate22(Clone)") {
			SushiValue = 40.50F;
		} 
			
	}














	void Update ()
	{
		if (GetComponent<SushiEatenByPlayer> ().isEaten == true) {
			if (ScoreAdded == false) {
				if (SushiValue > 0F) {
					ScoreController.GetComponent<ScoreController> ().CurrentScore += SushiValue * ScoreController.GetComponent<ScoreController> ().Multiplier;
					ScoreController.GetComponent<ScoreController> ().CurrentPlate += 1F * ScoreController.GetComponent<ScoreController> ().Multiplier;
				}

				ScoreAdded = true;
			}
		}
	}
}
