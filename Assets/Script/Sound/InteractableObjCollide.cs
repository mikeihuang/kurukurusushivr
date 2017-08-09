using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObjCollide : MonoBehaviour {

	public GameObject SoundController;

	void Start(){
		if (SoundController == null) {
			SoundController = GameObject.FindGameObjectWithTag ("SoundController");
		}
	}
	
	void OnCollisionEnter(Collision other){
		if( other.gameObject.tag == "Ground")
		{
			SoundController.GetComponent<SoundController> ().playCollideSound ();
		}	
	}
}
