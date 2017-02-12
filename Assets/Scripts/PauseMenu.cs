using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public string mainMenuLevel;
	public GameObject pauseMenu;
	public void RestartGame(){
		pauseMenu.SetActive (false);
		ResumeGame ();
		FindObjectOfType<GameManager> ().Reset ();
		
	}
	public void QuitToMainmenu(){
		Application.LoadLevel (mainMenuLevel);
		
	}
	public void PauseGame(){
		Time.timeScale = 0f;
		pauseMenu.SetActive (true);

	}
	public void ResumeGame(){

		Time.timeScale = 1f;
		pauseMenu.SetActive (false);
	}
}
