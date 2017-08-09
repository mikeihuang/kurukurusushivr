using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		RenderSettings.skybox.SetFloat("_AtmosphereThickness", (Mathf.Sin(Time.time * Mathf.Deg2Rad * 133.2F)/3F) + 1F);

	}
}
