using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public void PlayGame(){

		Application.LoadLevel ("PlayGame");
	}
	public void Instruction(){

		Application.LoadLevel ("Instruction");
	}
	public void QuitGame(){
		Application.Quit ();

	}

}
