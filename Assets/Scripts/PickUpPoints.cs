using UnityEngine;
using System.Collections;

public class PickUpPoints : MonoBehaviour {

	public int scoreToGive;
	private ScoreManager theScoreManager;
//	public AudioSource audio;
	// Use this for initialization
	void Start () {
		theScoreManager = FindObjectOfType<ScoreManager> ();
		//audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			GetComponent<AudioSource>().Play();
			theScoreManager.AddScore(scoreToGive);
			Destroy(this.gameObject);
		}

	}
}
