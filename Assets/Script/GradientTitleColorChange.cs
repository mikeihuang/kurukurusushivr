using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradientTitleColorChange : MonoBehaviour {
	
	public float value = 0F;
	private Renderer rend;

	void Start () {
		rend = GetComponent<Renderer> ();
	}
	

	void Update () {

		Color newColor;

		value = Mathf.Lerp (0.5F, 1F, Mathf.PingPong(Time.time, 1));
		newColor = Color.HSVToRGB (0F, 0F, value);
		newColor.a = 0.5F;

		rend.material.SetColor ("_TintColor", newColor);
	}
}