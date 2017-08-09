using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRoach : MonoBehaviour {

	float CountdownToDeath;

	void Start () {
		CountdownToDeath = 0F;
	}

	void Update () {

		if (CountdownToDeath > 4F) {
			DestroyNow ();
		}

		CountdownToDeath = CountdownToDeath + 1F * Time.deltaTime;
	}

	public void DestroyNow(){
		transform.Find ("Electro").gameObject.SetActive (true);
		transform.Find ("Electro").parent = null;
		Destroy (gameObject);
	}
}