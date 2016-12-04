using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	Rigidbody2D rigidbody;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody2D> ();
		rigidbody.velocity = new Vector2(0, 15);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
