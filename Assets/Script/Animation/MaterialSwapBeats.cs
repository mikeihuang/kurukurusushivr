using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSwapBeats: MonoBehaviour {

	public Material material1;
	public Material material2;
	float duration = 1.332F/4F;
	public Renderer rend;

	int caseSwitch = 1;

	void Start () {
		rend = GetComponent<Renderer> ();
		caseSwitch = 1; // Set default to material1
		InvokeRepeating ("MaterialSwap", duration, duration);
	}



	void MaterialSwap () {
		if (caseSwitch == 1) {
			caseSwitch = 2;
		} else if (caseSwitch == 2) {
			caseSwitch = 1;
		}
	}

	void Update(){
		switch (caseSwitch) {
		case 1:
			rend.material = material1;
			break;
		case 2:
			rend.material = material2;
			break;
		default:
			Debug.Log ("Something went wrong with " + gameObject + " material.");
			break;
		}
	}
}
