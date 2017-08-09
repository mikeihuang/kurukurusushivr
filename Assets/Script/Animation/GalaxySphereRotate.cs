using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalaxySphereRotate : MonoBehaviour {

	void Update () {
		transform.Rotate (5F * Time.deltaTime, 0F, 0F);
	}
}
