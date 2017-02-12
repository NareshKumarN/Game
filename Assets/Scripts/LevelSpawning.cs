using UnityEngine;
using System.Collections;

public class LevelSpawning : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;
	private bool checkIfFirstLevelInstantiated= false;
	//private GameObject tempGameObject;
	private bool yesInstatiated = false;
//	private int levelSelector;
	private CoinGenarator theCoinGenerator;
	public float coinThreshhold;
	
	// Use this for initialization
	void Start () {
		theCoinGenerator = FindObjectOfType<CoinGenarator> ();
		Spawn ();
	
	}

	void Spawn(){
		if (!checkIfFirstLevelInstantiated) {


			GameObject obj1 = Instantiate (obj [Random.Range (0, obj.GetLength (0))], new Vector3(transform.position.x,transform.position.y-Random.Range(0,3),transform.position.z), Quaternion.identity) as GameObject;

			if(Random.Range(0,100) < coinThreshhold){
			theCoinGenerator.SpawnCoins(obj1.transform.position);
			}

			yesInstatiated = true;
			Debug.Log (yesInstatiated);
			Debug.Log(checkIfFirstLevelInstantiated);
			Debug.Log ("Iam Instantiated");
		}
//		checkIfFirstLevelInstantiated = true;
		if (!checkIfFirstLevelInstantiated && yesInstatiated) {
		Debug.Log("Im in higherLevel");
		GameObject obj1 = Instantiate(obj[Random.Range (0, obj.GetLength(0))], new Vector3(transform.position.x+Random.Range(8,12), transform
			                                                                 .position.y+6,transform.position.z),Quaternion.identity) as GameObject;	
			if(Random.Range(0,100) < coinThreshhold){
				theCoinGenerator.SpawnCoins(obj1.transform.position);

			}

		}

		checkIfFirstLevelInstantiated = false;
		yesInstatiated = false;
		Invoke ("Spawn", Random.Range(spawnMin,spawnMax));

	}
	
	// Update is called once per frame
}
