using UnityEngine;
using System.Collections;

public class PlatformGenerator : MonoBehaviour {

	public GameObject thePlatform;
	public Transform generationPoint;
	public float distanceBetween;

	private float platformWidth;

	// Use this for initialization
	void Start () {
	
		platformWidth = thePlatform.GetComponent<BoxCollider2D> ().size.x;
		//Instantiate (thePlatform, new Vector2 (38.01245f, 1.264723f), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
		if (transform.position.x < generationPoint.position.x) {
			transform.position = new Vector3(transform.position.x + platformWidth+distanceBetween, thePlatform.transform.position.y, thePlatform.transform.position.z);
			Instantiate(thePlatform, transform.position, Quaternion.identity);
		}
	}

}
