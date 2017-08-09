using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialLerpBeats : MonoBehaviour {

	public Material material1;
	public Material material2;
	float duration = 1.332F;
	public Renderer rend;


	void Start () {
		rend = GetComponent<Renderer> ();
		rend.material = material1;
	}

	void Update () {
		float lerp = Mathf.PingPong (Time.time, duration) / duration;
		rend.material.Lerp (material1, material2, lerp);
	}
}
