using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySushi : MonoBehaviour {

	float CountdownToDeath;
	public float DeathTimer = 10F;

	void Start () {
		CountdownToDeath = 0F;
	}

	void Update () {

		if (CountdownToDeath > DeathTimer) {
			Destroy (gameObject);
		}

		CountdownToDeath = CountdownToDeath + 1F * Time.deltaTime;
	}
}
