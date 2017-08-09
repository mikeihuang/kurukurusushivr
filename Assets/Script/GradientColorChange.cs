using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradientColorChange : MonoBehaviour {
	
	public float hue = 0F;
	private Renderer rend;

	void Start () {
		rend = GetComponent<Renderer> ();
	}
	

	void Update () {
		hue += 0.5F * Time.deltaTime;
		if (hue >= 1F) { hue = 0F; }
		rend.material.color = Color.HSVToRGB (hue, 1F, 1F);
	}
}
