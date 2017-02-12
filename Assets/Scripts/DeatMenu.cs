using UnityEngine;
using System.Collections;

public class DeatMenu : MonoBehaviour {

	public string mainMenuLevel;

	public void RestartGame(){
		FindObjectOfType<GameManager> ().Reset ();

	}
	public void QuitToMainmenu(){
		Application.LoadLevel (mainMenuLevel);

	}
	// Use this for initialization

}
