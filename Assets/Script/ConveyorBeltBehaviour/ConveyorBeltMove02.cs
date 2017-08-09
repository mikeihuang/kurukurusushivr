using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBeltMove02 : MonoBehaviour {

	float RotateAngle = 133.2F/4F;

	void Start () {
	}

	void Update () {
		transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y - RotateAngle * Time.deltaTime, transform.eulerAngles.z);
	}
}
