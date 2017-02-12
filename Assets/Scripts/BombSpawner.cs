using UnityEngine;
using System.Collections;

public class BombSpawner : MonoBehaviour {

	public GameObject obj;
	public float spawnMin = 3f;
	public float spawnMax = 2f;

	// Use this for initialization
	void Start () {
		Spawn ();

	}
	void Spawn(){
	//	float rand = Random.Range (0, 1000);
	//	if (rand > 500) {
			Instantiate(obj, transform.position, Quaternion.identity);
	//	}
		Invoke("Spawn", Random.Range(spawnMin, spawnMax));
	}
}
