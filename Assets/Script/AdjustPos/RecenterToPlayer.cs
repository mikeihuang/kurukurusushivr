using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecenterToPlayer : MonoBehaviour {

	public Transform NVRPlayer;

	void Start(){
		StartCoroutine (Recenter ());
	}

	IEnumerator Recenter(){
		yield return new WaitForSeconds (0.25F);
		transform.position = new Vector3 (NVRPlayer.position.x, transform.position.y, NVRPlayer.position.z);
	}
}
