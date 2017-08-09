using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionYLerpBeatsDown : MonoBehaviour {

	Vector3 position1;
	Vector3 position2;

	float duration = 1.332F;

	void Start () {
		position1 = new Vector3 (transform.localPosition.x, -4F, transform.localPosition.z);
		position2 = new Vector3 (transform.localPosition.x, 4F, transform.localPosition.z);
	}

	void Update () {
		float lerp = Mathf.PingPong (Time.time, duration) / duration;
		transform.localPosition = Vector3.Lerp (position1, position2, lerp);
	}
}
