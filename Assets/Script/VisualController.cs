using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VisualController : MonoBehaviour {

	[Header("Game Objects")]

	public GameObject Trees;
	public GameObject Waterfalls;
	public GameObject Goldfishes;
	public GameObject Lanterns;
	public GameObject StoneLanterns;
	public GameObject Fireworks;
	public GameObject Restaurant;
	public GameObject NEWRestaurant;
	public GameObject Nekos;
	public GameObject SushiFigures;
	public GameObject UFOs;
	public GameObject Sakura;
	public GameObject Grounds;

	public GameObject NekoCounter;
	public GameObject NekoCounterFireEmitter;

	public GameObject InverseSphere;

	public GameObject Wall01;
	public GameObject Wall02;
	public GameObject Wall03;
	public GameObject Wall04;
	public GameObject Ceiling;
	public GameObject Floor;

	public GameObject ConveyorBeltL;
	public GameObject ConveyorBeltR;
	public GameObject SushiLaunchPortals;
	public GameObject SpawnSushiL;
	public GameObject SpawnSushiR;

	public GameObject RibbonRainbowL;
	public GameObject RibbonRainbowR;
	public GameObject WaterSurface0L;
	public GameObject WaterSurface1L;
	public GameObject WaterSurface2L;
	public GameObject WaterSurface0R;
	public GameObject WaterSurface1R;
	public GameObject WaterSurface2R;
	public Material RainbowCanal1;
	public Material RainbowCanal2;

	public GameObject Bill;

	public GameObject BlackHoleL;
	public GameObject BlackHoleR;

	public GameObject DragParticleL;
	public GameObject DragParticleR;

	public Transform NVRPlayer;

	[Header("BGM Controller")]

	public AudioSource BGM;

	[Header("Switch Case")]
	public int caseSwitch = 1;
	bool caseSwitchON2 = false;
	bool caseSwitchON3 = false;
	bool caseSwitchON4 = false;
	bool caseSwitchON5 = false;
	bool caseSwitchON6 = false;
	bool caseSwitchON7 = false;
	bool caseSwitchON8 = false;
	bool caseSwitchON9 = false;
	bool caseSwitchON10 = false;
	bool caseSwitchON11 = false;
	bool caseSwitchON12 = false;
	bool caseSwitchON13 = false;
	
	void Start(){

		caseSwitch = 1;
		SwitchIt ();
	}






	void Update () {

		if (BGM.time >= 26.00F && BGM.time < 27.00F) {
			caseSwitch = 2;

			// Move up Trees + Waterfalls
			Trees.transform.position = Vector3.MoveTowards (Trees.transform.position, new Vector3 (Trees.transform.position.x, -10.5F, Trees.transform.position.z), 10F * Time.deltaTime);
			Waterfalls.transform.position = Vector3.MoveTowards (Waterfalls.transform.position, new Vector3 (Waterfalls.transform.position.x, -10F, Waterfalls.transform.position.z), 10F * Time.deltaTime);

			// Move Up Stone Lanterns
			StoneLanterns.transform.position = Vector3.MoveTowards (StoneLanterns.transform.position, new Vector3 (StoneLanterns.transform.position.x, NVRPlayer.transform.position.y - 19F, StoneLanterns.transform.position.z), 10F * Time.deltaTime);

			if (caseSwitchON2 == false) {
				SwitchIt ();
				caseSwitchON2 = true;
			}
		}

		if (BGM.time >= 27.00F && BGM.time < 36.00F) {
			caseSwitch = 3;

			// Move up Trees + Waterfalls
			Trees.transform.position = Vector3.MoveTowards (Trees.transform.position, new Vector3 (Trees.transform.position.x, -10.5F, Trees.transform.position.z), 10F * Time.deltaTime);
			Waterfalls.transform.position = Vector3.MoveTowards (Waterfalls.transform.position, new Vector3 (Waterfalls.transform.position.x, -10F, Waterfalls.transform.position.z), 10F * Time.deltaTime);

			// Move Up Stone Lanterns
			StoneLanterns.transform.position = Vector3.MoveTowards (StoneLanterns.transform.position, new Vector3 (StoneLanterns.transform.position.x, NVRPlayer.transform.position.y - 19F, StoneLanterns.transform.position.z), 10F * Time.deltaTime);

			if (caseSwitchON3 == false) {
				SwitchIt ();
				caseSwitchON3 = true;
			}
		}

		if (BGM.time >= 36.00F && BGM.time < 48.04F) {
			caseSwitch = 4;

			// Move up Trees + Waterfalls
			Trees.transform.position = Vector3.MoveTowards (Trees.transform.position, new Vector3 (Trees.transform.position.x, -10.5F, Trees.transform.position.z), 10F * Time.deltaTime);
			Waterfalls.transform.position = Vector3.MoveTowards (Waterfalls.transform.position, new Vector3 (Waterfalls.transform.position.x, -10F, Waterfalls.transform.position.z), 10F * Time.deltaTime);

			if (caseSwitchON4 == false) {
				SwitchIt ();
				caseSwitchON4 = true;
			}
		}

		if (BGM.time >= 48.04F && BGM.time < 69.30F) {
			caseSwitch = 5;

			// Animate Lantern appearance
			if (Lanterns.transform.localScale.y < 1.5F){
				Lanterns.transform.localScale = new Vector3 (Lanterns.transform.localScale.x, Lanterns.transform.localScale.y + 1F * Time.deltaTime, Lanterns.transform.localScale.z);
			}

			if (caseSwitchON5 == false) {
				SwitchIt ();
				caseSwitchON5 = true;
			}
		}

		if (BGM.time >= 69.30F && BGM.time < 90.69F) {
			caseSwitch = 6;

			// Conveyor Belt Move Away
			ConveyorBeltL.transform.position = Vector3.MoveTowards (ConveyorBeltL.transform.position, new Vector3 (200F, ConveyorBeltL.transform.position.y, ConveyorBeltL.transform.position.z), 30F * Time.deltaTime);
			ConveyorBeltR.transform.position = Vector3.MoveTowards (ConveyorBeltR.transform.position, new Vector3 (-200F, ConveyorBeltR.transform.position.y, ConveyorBeltR.transform.position.z), 30F * Time.deltaTime);

			if (ConveyorBeltL.transform.position.x == 200F) {
				ConveyorBeltL.SetActive (false);
				ConveyorBeltR.SetActive (false);
			}

			// Sushi Figures floats up
			SushiFigures.transform.position = Vector3.MoveTowards (SushiFigures.transform.position, new Vector3 (SushiFigures.transform.position.x, 8.5F, SushiFigures.transform.position.z), 15F * Time.deltaTime);

			if (caseSwitchON6 == false) {
				SwitchIt ();
				caseSwitchON6 = true;
			}
		}

		if (BGM.time >= 90.69F && BGM.time < 109.00F) { // Time 01:30:69
			caseSwitch = 7;

			// Conveyor Belt Move Back to players
			ConveyorBeltL.transform.position = Vector3.MoveTowards (ConveyorBeltL.transform.position, new Vector3 (NVRPlayer.position.x, ConveyorBeltL.transform.position.y, NVRPlayer.position.z), 30F * Time.deltaTime);
			ConveyorBeltR.transform.position = Vector3.MoveTowards (ConveyorBeltR.transform.position, new Vector3 (NVRPlayer.position.x, ConveyorBeltR.transform.position.y, NVRPlayer.position.z), 30F * Time.deltaTime);

			// Animate GIANT neko up
			Nekos.transform.position = Vector3.MoveTowards (Nekos.transform.position, new Vector3 (Nekos.transform.position.x, -148F, Nekos.transform.position.z), 30F * Time.deltaTime);


			if (caseSwitchON7 == false) {
				SwitchIt ();
				caseSwitchON7 = true;
			}
		}

		if (BGM.time >= 109.00F && BGM.time < 112.00F) { // Time 01:49:00
			caseSwitch = 8;

			// Animate Inverse Sphere
			if (InverseSphere.transform.localScale.x < 3F) {
				InverseSphere.transform.localScale += new Vector3(0.75F*Time.deltaTime,0.75F*Time.deltaTime,0.75F*Time.deltaTime);
			}

			// Animate Trees + Waterfalls down
			Trees.transform.position = Vector3.MoveTowards (Trees.transform.position, new Vector3 (Trees.transform.position.x, -300F, Trees.transform.position.z), 60F * Time.deltaTime);
			Waterfalls.transform.position = Vector3.MoveTowards (Waterfalls.transform.position, new Vector3 (Waterfalls.transform.position.x, -300F, Waterfalls.transform.position.z), 60F * Time.deltaTime);

			// Animate Lantern moving up
			Lanterns.transform.position = Vector3.MoveTowards (Lanterns.transform.position, new Vector3 (Lanterns.transform.position.x, 150F, Lanterns.transform.position.z), 30F * Time.deltaTime);

			// Animate Goldfish moving up
			Goldfishes.transform.position = Vector3.MoveTowards (Goldfishes.transform.position, new Vector3 (Goldfishes.transform.position.x, 300F, Goldfishes.transform.position.z), 50F * Time.deltaTime);

			if (caseSwitchON8 == false) {
				SwitchIt ();
				caseSwitchON8 = true;
			}
		}

		if (BGM.time >= 112.00F && BGM.time < 133.37F) { // Time 01:52:00
			caseSwitch = 9;

			// Animate Trees + Waterfalls down
			Trees.transform.position = Vector3.MoveTowards (Trees.transform.position, new Vector3 (Trees.transform.position.x, -300F, Trees.transform.position.z), 60F * Time.deltaTime);
			Waterfalls.transform.position = Vector3.MoveTowards (Waterfalls.transform.position, new Vector3 (Waterfalls.transform.position.x, -300F, Waterfalls.transform.position.z), 60F * Time.deltaTime);
			if (Trees.transform.position.y <= -150F) {
				Trees.SetActive (false);
				Waterfalls.SetActive (false);
			}

			// Animate UFO coming down
			UFOs.transform.position = Vector3.MoveTowards (UFOs.transform.position, new Vector3 (UFOs.transform.position.x, 25F, UFOs.transform.position.z), 30F * Time.deltaTime);

			if (caseSwitchON9 == false) {
				SwitchIt ();
				caseSwitchON9 = true;
			}
		}

		if (BGM.time >= 133.37F && BGM.time < 152.75F) { // Time 02:13:37
			caseSwitch = 10;
			if (caseSwitchON10 == false) {
				SwitchIt ();
				caseSwitchON10 = true;
			}
		}

		if (BGM.time >= 152.75F && BGM.time < 154.75F) { // Time 02:32:75
			caseSwitch = 11;

			// Conveyor Belt Move Away
			ConveyorBeltL.transform.position = Vector3.MoveTowards (ConveyorBeltL.transform.position, new Vector3 (200F, ConveyorBeltL.transform.position.y, ConveyorBeltL.transform.position.z), 30F * Time.deltaTime);
			ConveyorBeltR.transform.position = Vector3.MoveTowards (ConveyorBeltR.transform.position, new Vector3 (-200F, ConveyorBeltR.transform.position.y, ConveyorBeltR.transform.position.z), 30F * Time.deltaTime);

			if (ConveyorBeltL.transform.position.x > 150F) {
				ConveyorBeltL.SetActive (false);
				ConveyorBeltR.SetActive (false);
			}

			if (caseSwitchON11 == false) {
				SwitchIt ();
				caseSwitchON11 = true;
			}
		}

		if (BGM.time >= 154.75F) { // Time 02:34:75
			caseSwitch = 12;

			// Animate Bill Come Down
			Bill.transform.position = Vector3.MoveTowards (Bill.transform.position, new Vector3 (Bill.transform.position.x, 20F, Bill.transform.position.z), 30F * Time.deltaTime);

			// Conveyor Belt Move Away
			ConveyorBeltL.transform.position = Vector3.MoveTowards (ConveyorBeltL.transform.position, new Vector3 (200F, ConveyorBeltL.transform.position.y, ConveyorBeltL.transform.position.z), 30F * Time.deltaTime);
			ConveyorBeltR.transform.position = Vector3.MoveTowards (ConveyorBeltR.transform.position, new Vector3 (-200F, ConveyorBeltR.transform.position.y, ConveyorBeltR.transform.position.z), 30F * Time.deltaTime);

			if (ConveyorBeltL.transform.position.x > 150F) {
				ConveyorBeltL.SetActive (false);
				ConveyorBeltR.SetActive (false);
			}

			if (caseSwitchON12 == false) {
				SwitchIt ();
				caseSwitchON12 = true;
			}
		}

		if (!BGM.isPlaying) {
			caseSwitch = 13; // Music ends

			// Animate Bill Come Down
			Bill.transform.position = Vector3.MoveTowards (Bill.transform.position, new Vector3 (Bill.transform.position.x, 15F, Bill.transform.position.z), 30F * Time.deltaTime);


			if (caseSwitchON13 == false) {
				SwitchIt ();
				caseSwitchON13 = true;
			}
		}

	} // End of Update
























	void SwitchIt(){
		switch (caseSwitch) {
		case 1:
			// Time 00:00:00

			break;
		case 2:
			// Time 00:26:00

			// Restaurant Animation
			Wall01.GetComponent<Animator> ().enabled = true;
			Wall02.GetComponent<Animator> ().enabled = true;
			Wall03.GetComponent<Animator> ().enabled = true;
			Wall04.GetComponent<Animator> ().enabled = true;
			Ceiling.GetComponent<Animator> ().enabled = true;
			Floor.GetComponent<Animator> ().enabled = true;

			// Enable Outdoor Scenary + Animate moving upwards (Update)
			Trees.SetActive (true);
			Waterfalls.SetActive (true);
			StoneLanterns.SetActive (true);
			Sakura.SetActive (true);

			// Start Conveyor Belt moving 01 ENABLE
			ConveyorBeltL.GetComponent<ConveyorBeltMove01>().enabled = true;
			ConveyorBeltR.GetComponent<ConveyorBeltMove01>().enabled = true;

			// Enable Neko Counter Anim
			NekoCounter.GetComponent<NekoCounterAnim>().enabled = true;

			// Enable Neko Counter Fire Emitter
			NekoCounterFireEmitter.SetActive(true);

			break;
		case 3:
			// Time 00:27:00

			// Activate Blackhole
			BlackHoleL.SetActive (true);
			BlackHoleR.SetActive (true);
			break;
		case 4:
			// Time 00:36:00

			// Deactivate Restaurant complete after 10 sec
			Restaurant.SetActive (false);
			break;
		case 5:
			// Time 00:48:04

			// Adding more objects to the scene
			Lanterns.SetActive (true);
			Fireworks.SetActive (true);
			Goldfishes.SetActive (true);

			// Animate appearance of Lanterns (see Update() )

			// Start Conveyor Belt moving 01 DISABLE
			ConveyorBeltL.GetComponent<ConveyorBeltMove01> ().enabled = false;
			ConveyorBeltR.GetComponent<ConveyorBeltMove01> ().enabled = false;

			// Start Conveyor Belt moving 02 ENABLE
			ConveyorBeltL.GetComponent<ConveyorBeltMove02> ().enabled = true;
			ConveyorBeltR.GetComponent<ConveyorBeltMove02> ().enabled = true;

			// Recenter to player position
			ConveyorBeltL.transform.position = new Vector3 (NVRPlayer.position.x, ConveyorBeltL.transform.position.y, NVRPlayer.position.z);
			ConveyorBeltR.transform.position = new Vector3 (NVRPlayer.position.x, ConveyorBeltR.transform.position.y, NVRPlayer.position.z);

			break;
		case 6:
			// Time 01:09:30

			// Start Conveyor Belt moving 02 DISABLE
			ConveyorBeltL.GetComponent<ConveyorBeltMove02> ().enabled = false;
			ConveyorBeltR.GetComponent<ConveyorBeltMove02> ().enabled = false;

			// Rotate Conveyor Belt Y axis back to 90F
			if (ConveyorBeltL.transform.eulerAngles.y != 90F) {
				ConveyorBeltL.transform.eulerAngles = new Vector3 (0F, 90F, 0F);
			}
			if (ConveyorBeltR.transform.eulerAngles.y != 90F) {
				ConveyorBeltR.transform.eulerAngles = new Vector3 (0F, 90F, 0F);
			}

			// MOVE AWAY CONVEYOR BELT *** Set in Update function

			// ENABLE SOME NEW COOL sushi launhcer
			SushiLaunchPortals.SetActive(true);

			// ENABLE SUSHI FIGURES
			SushiFigures.SetActive(true);

			break;
		case 7:
			// Time 01:30:69

			// RE-ENABLE CONVEYOR BELT
			ConveyorBeltL.SetActive (true);
			ConveyorBeltR.SetActive (true);

			// Animate Conveyor Belt BACK to player (Update)

			// Set Active Giant Kitty
			Nekos.SetActive (true);

			// Animate Giant Kitty (Update)

			// DESTROY sushi launcher
			SushiLaunchPortals.transform.Find("LaunchExplosions").gameObject.SetActive(true);
			SushiLaunchPortals.transform.Find("LaunchExplosions").parent = null;

			Destroy(SushiLaunchPortals);

			break;
		case 8:
			// Time 01:49:00

			// Set Active Inverse Sphere GALAXY
			InverseSphere.SetActive (true);

			// DISABLE MIRRORING ground
			Grounds.SetActive(false);

			// Animate Inverse Sphere (update)
			// Animate Lantern moving up away (update)
			// Move down Trees + Waterfalls (Update)

			break;
		case 9:
			// Time 01:52:00

			// Disable Sakura
			Sakura.SetActive (false);

			// Disable Lanterns + Stone Lanterns
			Lanterns.SetActive (false);
			StoneLanterns.SetActive (false);

			// Disable Goldfishes
			Goldfishes.SetActive (false);

			// DISABLE sushi figure + Explosion
			SushiFigures.transform.Find ("SushiFiguresExplosions").gameObject.SetActive (true);
			SushiFigures.transform.Find ("SushiFiguresExplosions").parent = null;

			SushiFigures.SetActive (false);

			// Activate UFOs
			UFOs.SetActive (true);

			// Animate UFOs coming down (Update)

			// Start Conveyor Belt moving 03 ENABLE
			ConveyorBeltL.GetComponent<ConveyorBeltMove03> ().enabled = true;
			ConveyorBeltR.GetComponent<ConveyorBeltMove03> ().enabled = true;

			// Conveyor Belt Moving 03 Speed 0.25F
			ConveyorBeltL.GetComponent<ConveyorBeltMove03> ().Speed = 0.25F;
			ConveyorBeltR.GetComponent<ConveyorBeltMove03> ().Speed = 0.25F;

			break;
		case 10:
			// Time 02:13:37

			// BONUS ROUND

			// Conveyor Belt Moving 03 Speed 1F
			ConveyorBeltL.GetComponent<ConveyorBeltMove03> ().Speed = 0.75F;
			ConveyorBeltR.GetComponent<ConveyorBeltMove03> ().Speed = 0.75F;

			// BLackhole Rainbow comes out
			BlackHoleL.transform.Find("RibbonRainbow").gameObject.SetActive(true);
			BlackHoleR.transform.Find("RibbonRainbow").gameObject.SetActive(true);

			// Change Water Canal to Rainbow Canal
			WaterSurface0L.GetComponent<Renderer>().material = RainbowCanal1;
			WaterSurface0R.GetComponent<Renderer>().material = RainbowCanal1;

			WaterSurface1L.GetComponent<Renderer>().material = RainbowCanal2;
			WaterSurface1R.GetComponent<Renderer>().material = RainbowCanal2;
			WaterSurface2L.GetComponent<Renderer>().material = RainbowCanal2;
			WaterSurface2R.GetComponent<Renderer>().material = RainbowCanal2;

			break;
		case 11:
			// Time 02:32:75 (2 second Fade Out)

			// Conveyor Belt Move Away to end game (see Update)

			// FADE OUT
			NVRPlayer.GetComponent<OVRScreenFade>().StartFadeOut();

			break;
		case 12:
			// Time 02:34:75 (almost ending the game)

			// FADE IN
			NVRPlayer.GetComponent<OVRScreenFade>().StartFadeIn();

			// Disable Neko Counter
			NekoCounter.SetActive (false);

			// Disable Fireworks
			Fireworks.SetActive(false);

			// Diable UFOs
			UFOs.SetActive (false);

			// Disable Nekos
			Nekos.SetActive (false);

			// Disable Inverse Sphere
			InverseSphere.SetActive(false);

			// Enable Bill
			Bill.SetActive(true);

			// Enable NEW Restaurant
			NEWRestaurant.SetActive(true);


			break;
		case 13:
			// Music Ends

			DragParticleL.SetActive (true);
			DragParticleR.SetActive (true);

			ConveyorBeltL.SetActive (false);
			ConveyorBeltR.SetActive (false);

			StartCoroutine (ReturnToTitle ());

			break;
		default:
			Debug.Log ("Visual Controller is buggy!");
			break;
		}
	} // End of void SwitchIt


	IEnumerator ReturnToTitle(){
		yield return new WaitForSeconds (15);

		// Start Fade Out
		NVRPlayer.GetComponent<OVRScreenFade>().StartFadeOut();
		yield return new WaitForSeconds (2);

		SceneManager.LoadScene ("KuruKuruTitleScreen"); // Return to title screen
	}

} // End of Everything
