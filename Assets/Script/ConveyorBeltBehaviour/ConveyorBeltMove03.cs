using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBeltMove03 : MonoBehaviour {

	float RotateAngle;
	public float Speed = 0.25F;

	void Start () {
		if (gameObject.name == "ConveyorBeltL") {
			RotateAngle = 133.2F;
		} else if (gameObject.name == "ConveyorBeltR") {
			RotateAngle = -133.2F;
		}
	}

	void Update () {
		transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z + RotateAngle * Speed * Time.deltaTime);
	}
}
