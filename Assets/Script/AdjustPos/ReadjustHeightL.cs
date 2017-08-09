using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadjustHeightL : MonoBehaviour {

	public Transform NVRPlayer;

	void Start(){
		StartCoroutine (AdjustHeight ());
	}

	IEnumerator AdjustHeight(){
		yield return new WaitForSeconds (0.25F);
		transform.position = new Vector3 (transform.position.x, NVRPlayer.position.y - 5.5F, transform.position.z);
	}

}
