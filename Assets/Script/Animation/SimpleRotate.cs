using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotate : MonoBehaviour {

	float Speed = 90F;

	void Update () {
		transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y + Speed * Time.deltaTime, transform.eulerAngles.z);
	}
}
