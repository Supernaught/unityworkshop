using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public GameObject asteroid;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnAsteroid", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SpawnAsteroid() {
		Vector3 spawnPoint = new Vector3 (Random.Range (-8, 8), 6, 0);
		Instantiate (asteroid, spawnPoint, transform.rotation);
	}
}
