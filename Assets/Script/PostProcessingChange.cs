using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

[RequireComponent(typeof(PostProcessingBehaviour))]
public class PostProcessingChange : MonoBehaviour {

	public PostProcessingProfile PP01;
	public PostProcessingProfile PP02;

	void OnEnable () {
		var behaviour = GetComponent<PostProcessingBehaviour> ();
		behaviour.profile = PP02;
		StartCoroutine(TimerToChangeBackPP());
	}

	IEnumerator TimerToChangeBackPP (){
		yield return new WaitForSeconds (0.5F);
		var behaviour = GetComponent<PostProcessingBehaviour> ();
		behaviour.profile = PP01;
		GetComponent<PostProcessingChange> ().enabled = false;
	}
}
