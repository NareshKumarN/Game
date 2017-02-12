using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float moveSpeed;
	public float jumpForce;
	private Rigidbody2D myRigidBody;
	//public Transform gameObject12;

	public bool grounded;
	private float moveSpeedStore;
	public LayerMask whatIsGround;
	//private Collider2D myCollider;
	private Animator myAnimator;
	public Transform groundCheckTransform;
	private bool doubleJump = false;
	public AnimationClip animeClip;
	public Transform playerDead;
	private float speedMultiplier = 1.05f;
	private float speedMleStoneCount = 100f;
	public GameManager theGameManager;
	private float speedMileStoneCountStore;
	public Transform kunai;
	public Transform kunaiSpawnPoint;

	public AudioSource KunaiSound;

	// Use this for initialization
	void Start () {

//		GetComponent<SpriteRenderer>().enabled = true;
//		GetComponent<CircleCollider2D>().enabled = true;
		//Instantiate (gameObject12, new Vector3 (transform.position.x + 2, transform.position.y + 5, transform.position.z), Quaternion.identity);
		myRigidBody = GetComponent<Rigidbody2D> ();
		//myCollider = GetComponent<Collider2D>();
		myAnimator = GetComponent<Animator> ();
		moveSpeedStore = moveSpeed;
		speedMileStoneCountStore = speedMleStoneCount;
	
	}
	
	// Update is called once per frame
	void Update () {


		if (transform.position.x > speedMleStoneCount) {
		
			speedMleStoneCount += speedMleStoneCount;
			speedMleStoneCount += speedMultiplier*speedMleStoneCount;
			moveSpeed = moveSpeed * speedMultiplier;
		}
		//grounded = Physics2D.IsTouchingLayers (myCollider, whatIsGround);
		grounded = Physics2D.OverlapCircle (groundCheckTransform.transform.position, 0.1f, whatIsGround);
		   //transform.Translate(moveSpeed*Time.deltaTime*Input.GetAxis("Horizontal"), 0,0);
		if (grounded) {
			doubleJump = false;
		
		}

		myRigidBody.velocity = new Vector2 (moveSpeed, myRigidBody.velocity.y);

			if(Input.GetKeyDown(KeyCode.Space) && (grounded||!doubleJump))
		   {
			myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, jumpForce);
			if(!grounded){
				doubleJump = true;
			}
			}
		myAnimator.SetFloat ("Speed", myRigidBody.velocity.x);
		myAnimator.SetBool ("Grounded", grounded);

		if (Input.GetKeyDown (KeyCode.A)) {
			KunaiSound.Play();
			Instantiate(kunai, kunaiSpawnPoint.transform.position, Quaternion.Euler(0,0,-90));
		}
	
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Enemy" || coll.gameObject.tag == "EvilPlatform") {
			if(coll.gameObject.tag == "Enemy"){
				Destroy(coll.gameObject);}
			//Destroy(this.gameObject);
//			GetComponent<SpriteRenderer>().enabled = false;
//			GetComponent<CircleCollider2D>().enabled = false;

			GameObject anim = Instantiate(Resources.Load("PlayerDead"),new Vector2(this.gameObject.transform.position.x,this.gameObject.transform.position.y), Quaternion.identity) as GameObject;
			Destroy(anim.gameObject,animeClip.length);
			theGameManager.RestartGame();
			moveSpeed = moveSpeedStore;
			speedMleStoneCount = speedMileStoneCountStore;
		}

	}
}
