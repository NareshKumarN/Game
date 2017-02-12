using UnityEngine;
using System.Collections;

public class KunaiScript : MonoBehaviour {

	private Rigidbody2D myRigidBody;
		

	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		myRigidBody.velocity = new Vector2 (20.0f, myRigidBody.velocity.y);
	
	}

	void OnCollisionEnter2D(Collision2D other){

		if (other.gameObject.tag != "Enemy"&&other.gameObject.tag!="Player") {
			Destroy (this.gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "killkunai") {
			Destroy (this.gameObject);
		}
		
	}
}
