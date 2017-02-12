using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPoolForlevels : MonoBehaviour {

	public GameObject poledObject;
	public int pooledAmount;

	List<GameObject> pooledObjects;

	// Use this for initialization
	void Start () {
		pooledObjects = new List<GameObject> ();

		for (int i=0; i<pooledAmount; i++) {
			GameObject obj = (GameObject)Instantiate(poledObject);
			obj.SetActive(false);
			pooledObjects.Add(obj);
		}
	}
	
	// Update is called once per frame

	public GameObject GetPoolObject(){
		Debug.Log ("Printing count" +pooledObjects.Count);
		for (int i=0; i < pooledObjects.Count; i++) {
		  
			if(!pooledObjects[i].activeInHierarchy){
				Debug.Log("If Active In hierechy");
				return pooledObjects[i];
			}
		}
		GameObject obj = (GameObject)Instantiate(poledObject);
		obj.SetActive(false);
		pooledObjects.Add(obj);
		return obj;

	}

}
