using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Asteroid : MonoBehaviour {

	public GameObject particles;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col){
//		SoundSystem.PlayExplode ();
		Destroy (this.gameObject);
		Instantiate (particles, transform.position, transform.rotation);
		ScoreSystem.score += 1;
	}
}
