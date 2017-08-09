using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewtonVR
{
public class HandTriggerSound : MonoBehaviour {

	public GameObject SoundController;
	public AudioSource BGM;

	void Start(){
		if (SoundController == null) {
			SoundController = GameObject.FindGameObjectWithTag ("SoundController");
		}
	}
	

	void Update () {
			
			if (transform.Find ("LeftHand").GetComponent<NVRHand> ().HoldButtonDown) {
				if (BGM.isPlaying) {
					transform.Find ("LeftHand/Ef_SparksParticle_01").GetComponent<ParticleSystem> ().Play ();
					SoundController.GetComponent<SoundController> ().playPressTriggerSound ();
				} else {
					SoundController.GetComponent<SoundController> ().playLaserWriteSound ();
				}
			}



			if (transform.Find ("RightHand").GetComponent<NVRHand> ().HoldButtonDown) {
				if (BGM.isPlaying) {
					transform.Find ("RightHand/Ef_SparksParticle_01").GetComponent<ParticleSystem> ().Play ();
					SoundController.GetComponent<SoundController> ().playPressTriggerSound ();
				} else {
					SoundController.GetComponent<SoundController> ().playLaserWriteSound ();
				}
			}




			if (!BGM.isPlaying) {

				transform.Find ("LeftHand/Ef_SparksParticle_01").gameObject.SetActive (false);
				transform.Find ("RightHand/Ef_SparksParticle_01").gameObject.SetActive (false);

				if (transform.Find ("LeftHand").GetComponent<NVRHand> ().HoldButtonPressed) {
					transform.Find ("LeftHand/Drag_01 Warp-strike Noise").gameObject.SetActive (true);
				} else {
					transform.Find ("LeftHand/Drag_01 Warp-strike Noise").gameObject.SetActive (false);
				}
				if (transform.Find ("RightHand").GetComponent<NVRHand> ().HoldButtonPressed) {
					transform.Find ("RightHand/Drag_01 Warp-strike Noise").gameObject.SetActive (true);
				} else {
					transform.Find ("RightHand/Drag_01 Warp-strike Noise").gameObject.SetActive (false);
				}
			}

	} // End of Update
} // End of Class
} // End of NewtonVR Wrapper
