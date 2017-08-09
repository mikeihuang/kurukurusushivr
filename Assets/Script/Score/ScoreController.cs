using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	public float CurrentScore;
	public float CurrentPlate;
	public float CurrentDamage;

	public float Multiplier;
	public int SushiCombo;
	public GameObject FX_MultiFlame01;
	public GameObject FX_MultiFlame02;
	public GameObject FX_MultiFlame03;

	public TextMesh AmountOfPlate;
	public TextMesh AmountOfDamage;
	public TextMesh TotalAmount;
	public Text HighScoreText;
	public TextMesh NekoPlateCounter;
	public TextMesh MultiplierText;
	public TextMesh ComboText;


	// Particle (New High Score)
	public GameObject FX_Fireworks;

	// Sound Controller
	public GameObject SoundController;

	// NEW Restaurant
	public GameObject NEWRestaurant;

	// HighScore 3D Model
	public GameObject HighScore;

	// Bool new high score update
	bool isNewHighScoreUpdated = false;

	void Start () {

		if (SoundController == null) {
			SoundController = GameObject.FindGameObjectWithTag ("SoundController");
		}


		CurrentScore = 0F;
		CurrentPlate = 0F;
		CurrentDamage = 0F;

		Multiplier = 1F;
		SushiCombo = 0;

		HighScoreText.text = PlayerPrefs.GetInt ("HighScore", 0).ToString ("00000000");
	}

	void Update () {

		// Multiplier Equation
		if (SushiCombo <= 0) {
			ComboText.gameObject.SetActive (false);
			Multiplier = 1F;
		} else if (SushiCombo > 0 && SushiCombo < 5) {
			ComboText.gameObject.SetActive (true);
			Multiplier = 1F;
			FX_MultiFlame01.SetActive (false);
			FX_MultiFlame02.SetActive (false);
			FX_MultiFlame03.SetActive (false);
		} else if (SushiCombo >= 5 && SushiCombo < 10) {
			Multiplier = 2F;
			FX_MultiFlame01.SetActive (true);
		} else if (SushiCombo >= 10 && SushiCombo < 20) {
			Multiplier = 4F;
			FX_MultiFlame01.SetActive (false);
			FX_MultiFlame02.SetActive (true);
		} else if (SushiCombo >= 20) {
			Multiplier = 8F;
			FX_MultiFlame02.SetActive (false);
			FX_MultiFlame03.SetActive (true);
		}

		// Write score on bill
		AmountOfPlate.text = CurrentPlate.ToString ();
		NekoPlateCounter.text = CurrentPlate.ToString ("000"); // Two digit
		AmountOfDamage.text = CurrentDamage.ToString ();
		TotalAmount.text = CurrentScore.ToString ("C0");
		MultiplierText.text = "x" + Multiplier.ToString ();
		ComboText.text = SushiCombo.ToString () + " Combo";

		// Write score on High Score board
		if (NEWRestaurant.activeInHierarchy && isNewHighScoreUpdated == false) {

			if (CurrentScore > PlayerPrefs.GetFloat ("HighScore", 0)) {

				// Save new high score to Preferences
				PlayerPrefs.SetFloat ("HighScore", CurrentScore);
				HighScoreText.text = CurrentScore.ToString ("00000000");

				// Play congrats sound
				SoundController.GetComponent<SoundController> ().playNewHighScoreSound ();

				// Play Confetti fireworks
				FX_Fireworks.SetActive(true);

				// Activate Text Color Change
				HighScore.GetComponent<MaterialSwapBeats> ().enabled = true;

			} else if (CurrentScore <= PlayerPrefs.GetFloat ("HighScore", 0)) {

				// Display high score on board
				HighScoreText.text = PlayerPrefs.GetInt ("HighScore", 0).ToString ("00000000");

				// Play boo sound
				SoundController.GetComponent<SoundController> ().playSorryTryAgainSound ();
			}

			isNewHighScoreUpdated = true;
		}

		// Reset highscore
		if (Input.GetKeyDown (KeyCode.J)) {
			PlayerPrefs.DeleteAll ();
			HighScoreText.text = "00000000";
		}

	} // End of Update
}
