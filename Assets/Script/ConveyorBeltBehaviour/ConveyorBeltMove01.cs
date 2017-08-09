using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBeltMove01 : MonoBehaviour {

	public int SwitchCase = 0;
	Vector3 originalConveyorBeltPos;
	Vector3 newConveyorBeltPos;
	float MoveDistance = 5F;
	float MoveSpeed = 1.332F;

	void Start () {
		originalConveyorBeltPos = transform.position;

		if (gameObject.name == "ConveyorBeltL") {
			newConveyorBeltPos = new Vector3 (transform.position.x + MoveDistance, transform.position.y, transform.position.z);
		} else if (gameObject.name == "ConveyorBeltR") {
			newConveyorBeltPos = new Vector3 (transform.position.x - MoveDistance, transform.position.y, transform.position.z);
		}

		InvokeRepeating ("LeftRightMove", 0F, MoveSpeed);
	}

	void Update () {
		
		switch (SwitchCase) {
		case 0: // When Conveyor Belt is moving BACK to original position
			transform.position = Vector3.MoveTowards(transform.localPosition, originalConveyorBeltPos, MoveSpeed*4F*Time.deltaTime);
			break;
		case 1: // When Conveyor Belt is moving AWAY to new position
			transform.position = Vector3.MoveTowards(transform.localPosition, newConveyorBeltPos, MoveSpeed*4F*Time.deltaTime);
			break;
		default:
			Debug.Log ("Something went wrong with Conveyor Belt Movement 01");
			break;	
		}

	}

	void LeftRightMove(){
		if (SwitchCase == 0) {
			SwitchCase = 1;
		} else {
			SwitchCase = 0;
		}
	}
}
