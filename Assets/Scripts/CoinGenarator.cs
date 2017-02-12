using UnityEngine;
using System.Collections;

public class CoinGenarator : MonoBehaviour {

	public GameObject coin;
	public float distanceBetweenCoins;

	public void SpawnCoins(Vector3 startPosition){
		//int random = Random.Range (0, 3);

		//Instantiate (coin, startPosition, Quaternion.identity);
		Instantiate (coin, new Vector3 (startPosition.x - distanceBetweenCoins, startPosition.y+3, 0), Quaternion.identity);
		Instantiate(coin, new Vector3(startPosition.x - distanceBetweenCoins, startPosition.y+3,0),Quaternion.identity);
	
		        	
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
