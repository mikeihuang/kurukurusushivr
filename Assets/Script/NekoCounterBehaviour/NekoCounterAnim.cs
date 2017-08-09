using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NekoCounterAnim : MonoBehaviour {

	Vector3 NekoCounterOriginalPos; // Down
	Vector3 NekoCounterRightPos;  // Right
	Vector3 NekoCounterTopPos; // Top
	Vector3 NekoCounterLeftPos; // Left

	int caseSwitch = 1;

	void Start () {
		NekoCounterOriginalPos = GetComponent<ReadjustNekoCounter> ().NekoCounterOriginalPos;

		NekoCounterRightPos = new Vector3 (NekoCounterOriginalPos.x + 15F, NekoCounterOriginalPos.y + 7.5F, NekoCounterOriginalPos.z + 5F);
		NekoCounterTopPos = new Vector3 (NekoCounterOriginalPos.x, NekoCounterOriginalPos.y + 15F, NekoCounterOriginalPos.z);
		NekoCounterLeftPos = new Vector3 (NekoCounterOriginalPos.x - 15F, NekoCounterOriginalPos.y + 7.5F, NekoCounterOriginalPos.z + 5F);

		InvokeRepeating ("ChangeCase", 4F, 4F);
	}

	void ChangeCase (){
		if (caseSwitch < 4) {
			caseSwitch += 1;
		} else {
			caseSwitch = 1;
		}
	}

	void Update ()
	{
		switch (caseSwitch) {
		case 1:
			// Move to Right
			transform.position = Vector3.MoveTowards(transform.position, NekoCounterRightPos, 4F * Time.deltaTime);

			break;
		case 2:
			// Move to Top
			transform.position = Vector3.MoveTowards(transform.position, NekoCounterTopPos, 4F * Time.deltaTime);

			break;
		case 3:
			// Move to Left
			transform.position = Vector3.MoveTowards(transform.position, NekoCounterLeftPos, 4F * Time.deltaTime);

			break;
		case 4:
			// Move to Down
			transform.position = Vector3.MoveTowards(transform.position, NekoCounterOriginalPos, 4F * Time.deltaTime);

			break;
		default:
			Debug.Log ("Neko Counter animation is broken");
			break;
		}
	}
}
