using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadjustNekoCounter : MonoBehaviour {
	
	public Transform NVRPlayer;
	public Vector3 NekoCounterOriginalPos;

	void Start(){
		StartCoroutine (Recenter ());
	}

	IEnumerator Recenter(){
		yield return new WaitForSeconds (0.25F);
		NekoCounterOriginalPos = new Vector3 (NVRPlayer.position.x - 5F, transform.position.y, NVRPlayer.position.z + 26F);
		transform.position = NekoCounterOriginalPos;
	}

}
