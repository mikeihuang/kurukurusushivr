using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadjustBillPos : MonoBehaviour {

	public Transform NVRPlayer;

	void Start () {
		transform.position = new Vector3 (NVRPlayer.position.x, transform.position.y, NVRPlayer.position.z + 12F);
	}

	void Update () {
		
	}
}
