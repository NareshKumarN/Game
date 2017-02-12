using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float movementSpeed;
	private Rigidbody2D myRigidbod;
	private int enmeyLifePoints=3;

	// Use this for initialization
	void Start () {
		myRigidbod = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		myRigidbod.velocity = new Vector2 (-movementSpeed, myRigidbod.velocity.y);


	
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "kunai") {
			Destroy(other.gameObject);
			enmeyLifePoints--;
		}
		if (enmeyLifePoints == 0) {
			Destroy (other.gameObject);
			Destroy(this.gameObject);

		}
	}

}
