using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {
	private AudioSource BombBGM;
	Animator anime;
	//GameObject tile;

	public float explodeRadius = 0.75f;
	private int count = 0;
	// Use this for initialization
	void Start () {
		BombBGM = GetComponent<AudioSource> ();
		anime = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.SetActive (true);
		if (anime.GetCurrentAnimatorStateInfo (0).IsName ("Bomb_Dead")) {

//			Debug_log("Hello");
			Debug.Log("Hello");
			Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position,explodeRadius);

			foreach(Collider2D Col in colliders){
				count++;
				Debug.Log ("in col");
				if(Col.tag != "Player" && Col.tag!="ThePlatform"){

					BombBGM.Play();
					Destroy(Col.gameObject);

					//Destroy(tile.gameObject);
				}

			}
			Destroy(this.gameObject);
			Debug.Log(count);
		}
		
	}
}
	 	