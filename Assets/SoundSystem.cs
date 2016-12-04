using UnityEngine;
using System.Collections;

public class SoundSystem : MonoBehaviour {
	
	public AudioClip shoot;
	public AudioClip explode;
	
	public void PlayShoot(){
		GetComponent<AudioSource> ().PlayOneShot (shoot);
	}

	public void PlayExplode(){
		GetComponent<AudioSource> ().PlayOneShot (explode);
	}
}
