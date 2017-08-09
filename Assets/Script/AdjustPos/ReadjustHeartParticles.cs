using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadjustHeartParticles : MonoBehaviour {

	public Transform NVRPlayer;

	void Update () {
		transform.position = new Vector3 (NVRPlayer.position.x, NVRPlayer.position.y, NVRPlayer.position.z + 0.5F);
	}
}
