using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour {

	// Audio
	AudioSource audio;

	[Header("Game Objects")]
	public AudioClip collideSound;
	public AudioClip crunchSound;
	public AudioClip explodeSound;
	public AudioClip laserSound;
	public AudioClip squeakySound;
	public AudioClip wrongBuzzSound;
	public AudioClip newHighScoreSound;
	public AudioClip sorryTryAgainSound;


	[Header("Motion Controllers")]
	public AudioClip pressTriggerSound;
	public AudioClip laserWriteSound;


	void Start () {
		audio = GetComponent<AudioSource>();
	}
	





	// Call functions for sound:

	public void playCollideSound(){
		audio.pitch = 1F;
		audio.PlayOneShot (collideSound, 0.5F);
	}

	public void playCrunchSound(){
		audio.pitch = 1F;
		audio.PlayOneShot (crunchSound, 0.95F);
	}

	public void playExplodeSound(){
		audio.pitch = 1F;
		audio.PlayOneShot (explodeSound, 0.85F);
	}

	public void playLaserSound(){
		audio.pitch = 1F;
		audio.PlayOneShot (laserSound, 0.45F);
	}

	public void playSqueakySound(){
		audio.pitch = 1F;
		audio.PlayOneShot (squeakySound, 0.85F);
	}

	public void playWrongBuzzSound(){
		audio.pitch = 1F;
		audio.PlayOneShot (wrongBuzzSound, 0.75F);
	}

	public void playNewHighScoreSound(){
		audio.pitch = 1F;
		audio.PlayOneShot (newHighScoreSound, 1F);
	}

	public void playSorryTryAgainSound(){
		audio.pitch = 1F;
		audio.PlayOneShot (sorryTryAgainSound, 1F);
	}

	public void playPressTriggerSound(){
		audio.pitch = Random.Range (0.5F, 1.5F);
		audio.PlayOneShot (pressTriggerSound, 0.5F);
	}

	public void playLaserWriteSound(){
		audio.PlayOneShot (laserWriteSound, 1F);
	}

}// End
