using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public void Exit(){
		Application.Quit ();
	}
	public void StartGame(){
		Application.LoadLevel (1);
	}
	public void help (){

	}
}
