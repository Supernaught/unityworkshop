using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	Rigidbody2D rigidbody;

	public float speed = 10;
	public GameObject bullet;

	// Use this 
	void Start () {
		rigidbody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		// move left and right
		if (Input.GetKey (KeyCode.LeftArrow)) {
			rigidbody.velocity = new Vector2 (-speed, 0);
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			rigidbody.velocity = new Vector2 (speed, 0);
		} else {
			rigidbody.velocity = new Vector2 (0, 0);
		}
			
		// shoot controls
		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject newBullet = Instantiate (bullet, transform.position, transform.rotation) as GameObject;
			Physics2D.IgnoreCollision(newBullet.GetComponent<Collider2D>(), GetComponent<Collider2D>());
//			SoundSystem.PlayShoot ();
		}
	}
}
