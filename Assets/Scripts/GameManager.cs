using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Transform platformGenerator;
	private Vector3 platformStartPoint;
	public PlayerController thePlayer;
	private Vector3 playerStartPoint;
	private PlatformDestroyer[] platformList;
	public ScoreManager theScoreManager;
	public DeatMenu deathScreen;

	// Use this for initialization
	void Start () {
		platformStartPoint = platformGenerator.position;
		playerStartPoint = thePlayer.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void RestartGame(){
		thePlayer.gameObject.SetActive (false);
		theScoreManager.scoreIncreasing = false;
		//StartCoroutine ("RestartGameCo");
		deathScreen.gameObject.SetActive (true);
	}
	public void Reset(){
		deathScreen.gameObject.SetActive (false);
		thePlayer.transform.position = playerStartPoint;
		platformList = FindObjectsOfType<PlatformDestroyer> ();
		for (int i = 0; i < platformList.Length; i++) {
			Destroy(platformList[i].gameObject);
		}
		platformGenerator.position = platformStartPoint;
		thePlayer.gameObject.SetActive (true);
		theScoreManager.scoreIncreasing = true;
		theScoreManager.scoreCount = 0;
	}
	/*public IEnumerator RestartGameCo(){

		thePlayer.gameObject.SetActive (false);
		theScoreManager.scoreIncreasing = false;
		yield return new WaitForSeconds (0.5f);
		thePlayer.transform.position = playerStartPoint;
		platformList = FindObjectsOfType<PlatformDestroyer> ();
		for (int i = 0; i < platformList.Length; i++) {
			Destroy(platformList[i].gameObject);
		}
		platformGenerator.position = platformStartPoint;
		thePlayer.gameObject.SetActive (true);
		theScoreManager.scoreIncreasing = true;
		theScoreManager.scoreCount = 0;
	}*/
}
