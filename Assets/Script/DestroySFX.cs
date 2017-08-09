using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySFX : MonoBehaviour {

	float CountdownToDeath;

	void Start () {
		CountdownToDeath = 0F;
	}

	void Update () {

		if (CountdownToDeath > 3F) {
			Destroy (gameObject);
		}

		CountdownToDeath = CountdownToDeath + 1F * Time.deltaTime;
	}
}
