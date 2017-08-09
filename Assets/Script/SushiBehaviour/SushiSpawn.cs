using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiSpawn : MonoBehaviour {

	public GameObject prefab;
	float SpawnRate = 1.332F;
	int plateNum;
	float SpeedMultiplier = 1F;

	public GameObject ScoreController;
	public AudioSource BGM;

	public GameObject ConveyorBeltL;
	public GameObject ConveyorBeltR;

	public GameObject Plate01;
	public GameObject Plate02;
	public GameObject Plate03;
	public GameObject Plate04;
	public GameObject Plate05;
	public GameObject Plate06;
	public GameObject Plate07;
	public GameObject Plate08;
	public GameObject Plate09;
	public GameObject Plate10;
	public GameObject Plate11;
	public GameObject Plate12;
	public GameObject Plate13;
	public GameObject Plate14;
	public GameObject Plate15;
	public GameObject Plate16;
	public GameObject Plate17;
	public GameObject Plate18;
	public GameObject Plate19;
	public GameObject Plate20;
	public GameObject Plate21;
	public GameObject Plate22;

	public GameObject Roach;

	void Start () {
		InvokeRepeating ("SushiSpawnNow", 0F, SpawnRate);
		InvokeRepeating ("RoachSpawnNow", 0F, SpawnRate / 3F);

		if (ScoreController == null) {
			ScoreController = GameObject.FindGameObjectWithTag ("ScoreController");
		}
	}

	void SushiSpawnNow () {
		if (BGM.isPlaying) {

			// 1. Randomize which plate to spawn

			float CurrentAmountOfPlate = ScoreController.GetComponent<ScoreController> ().CurrentPlate;



			// Setup boolean for bonus round
			if (BGM.time < 133.37F) {

				// STAGE 01
				plateNum = Random.Range (1, 14); // Inclusive/Exclusive

				// STAGE 01.5 Troll with Rubber Duck
				if (CurrentAmountOfPlate >= 10F && CurrentAmountOfPlate < 15F) {
					int GiveMeARandomNum = Random.Range (1, 7); // Inclusive/Exclusive
					if (GiveMeARandomNum != 6) {
						plateNum = 14;
					} else {
						plateNum = 7;
					}
				}

				// STAGE 02
				if (CurrentAmountOfPlate >= 15F && CurrentAmountOfPlate < 25F) {
					int GiveMeARandomNum = Random.Range (1, 3); // Inclusive/Exclusive
					if (GiveMeARandomNum == 1) {
						plateNum = Random.Range (10, 16); // Inclusive/Exclusive
					} else {
						plateNum = Random.Range (1, 19); // Inclusive/Exclusive
					}
				}

				// STAGE 02.5 Troll with SIGN
				if (CurrentAmountOfPlate >= 25F && CurrentAmountOfPlate < 30F) {
					int GiveMeARandomNum = Random.Range (1, 7); // Inclusive/Exclusive
					if (GiveMeARandomNum != 6) {
						plateNum = Random.Range (12, 14); // Inclusive/Exclusive
					} else {
						plateNum = 16; // Inclusive/Exclusive
					}
				}

				// STAGE 03
				if (CurrentAmountOfPlate >= 30F && CurrentAmountOfPlate < 40F) {

					SpeedMultiplier = 1.5F;
					plateNum = Random.Range (1, 23); // Inclusive/Exclusive
				}

				// STAGE 04
				if (CurrentAmountOfPlate >= 40F) {

					SpeedMultiplier = 2F;
					int GiveMeARandomNum = Random.Range (1, 3); // Inclusive/Exclusive
					if (GiveMeARandomNum == 1) {
						plateNum = 10;
					} else {
						plateNum = Random.Range (16, 23); // Inclusive/Exclusive
					}
				}
			} else {
			
				// STAGE 05 BONUS ROUND
				SpeedMultiplier = 1F;
				plateNum = Random.Range (20, 23); // Inclusive/Exclusive
			}










			if (plateNum == 1) {
				prefab = Plate01;
			} else if (plateNum == 2) {
				prefab = Plate02;
			} else if (plateNum == 3) {
				prefab = Plate03;
			} else if (plateNum == 4) {
				prefab = Plate04;
			} else if (plateNum == 5) {
				prefab = Plate05;
			} else if (plateNum == 6) {
				prefab = Plate06;
			} else if (plateNum == 7) {
				prefab = Plate07;
			} else if (plateNum == 8) {
				prefab = Plate08;
			} else if (plateNum == 9) {
				prefab = Plate09;
			} else if (plateNum == 10) {
				prefab = Plate10;
			} else if (plateNum == 11) {
				prefab = Plate11;
			} else if (plateNum == 12) {
				prefab = Plate12;
			} else if (plateNum == 13) {
				prefab = Plate13;
			} else if (plateNum == 14) {
				prefab = Plate14;
			} else if (plateNum == 15) {
				prefab = Plate15;
			} else if (plateNum == 16) {
				prefab = Plate16;
			} else if (plateNum == 17) {
				prefab = Plate17;
			} else if (plateNum == 18) {
				prefab = Plate18;
			} else if (plateNum == 19) {
				prefab = Plate19;
			} else if (plateNum == 20) {
				prefab = Plate20;
			} else if (plateNum == 21) {
				prefab = Plate21;
			} else if (plateNum == 22) {
				prefab = Plate22;
			} else {
				prefab = null;
				Debug.Log ("Randomize error with sushi plate!");
			}

			// 2. Spawn the new object
			if (prefab != null) {
				GameObject newObj = Instantiate (prefab, transform.position, transform.rotation);

				// 3. Parent it to conveyorbelt
				newObj.transform.parent = transform;

				// 4. Multiply speed 
				newObj.GetComponent<Animator> ().speed = 1F * SpeedMultiplier;

				// 5. Check if it is a launch portal (sushi jumps out instead of following conveyor belt)
				if (transform.parent.gameObject.tag == "SushiLaunchPortal"){
					newObj.GetComponent<Animator> ().enabled = false;
					newObj.GetComponent<Rigidbody> ().useGravity = true;
					newObj.GetComponent<Rigidbody> ().isKinematic = false;
					newObj.GetComponent<DestroySushi> ().DeathTimer = 4F; // Destory in 4 sec instead of 10 sec
					newObj.transform.parent = null; // Does not have parent

					// 6. Only has 33% chance of survival
					int GiveRandomNumber = Random.Range(0,3); // Inclusive/Exclusive
					if (GiveRandomNumber != 0){
						Destroy (newObj);
					} else {
						// 7. Add force to make sushi jump up
						newObj.GetComponent<Rigidbody> ().AddForce (transform.up * 2200F);}
				}
			}
		}
	}





	void RoachSpawnNow(){
		if (transform.parent.gameObject == ConveyorBeltL || transform.parent.gameObject == ConveyorBeltR) {
			if (transform.parent.GetComponent<ConveyorBeltMove03> ().isActiveAndEnabled) {
				// 1. Spawn Roach Object
				GameObject newObj = Instantiate (Roach,
					                   new Vector3 (transform.position.x, transform.position.y - 1F, transform.position.z),
					                   Quaternion.Euler (180F, 180F, 0F)
				                   );

				// 2. Parent it to conveyorbelt
				newObj.transform.parent = transform;
			}
		}
	}
}