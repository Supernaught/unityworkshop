using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreSystem : MonoBehaviour {

	public static int score = 0;

	Text textUI;

	// Use this for initialization
	void Start () {
		textUI = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		textUI.text = "SCORE: " + score;
	}
}
