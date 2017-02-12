using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public PlayerController thePlayer;
	private Vector3 lastPlayerPosition;
	private float distanceToMove;
	private float distanceToTarget;

	// Use this for initialization
	void Start () {

		thePlayer = FindObjectOfType<PlayerController> ();
		distanceToTarget = transform.position.x - thePlayer.transform.position.x;
	
	}
	
	// Update is called once per frame
	void Update () {
		float targetObjectX = thePlayer.transform.position.x;
		Vector3 newCameraPosition = transform.position;
		newCameraPosition.x = targetObjectX + distanceToTarget;
		transform.position = newCameraPosition;

//		distanceToMove = thePlayer.transform.position.x - lastPlayerPosition.x;
//		transform.position = new Vector3 (transform.position.x + distanceToMove, transform.position.y, transform.position.z);
//		lastPlayerPosition = thePlayer.transform.position;
//
	
	}
}
