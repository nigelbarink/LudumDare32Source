using UnityEngine;
using System.Collections;
using  UnityEngine.UI;

public class Economy : MonoBehaviour {
	// public 
	public Text pt;
	public Text Exp;
	public Text Base;
	public GameObject Status;
	public RectTransform losed;
	public AudioSource Aud;
	public AudioClip clip ;
	// non- public 
	float points = 500f;
	float experience = 10;
	int lifes = 100;


	public void Update(){
		pt.text = "Points: " + points.ToString ();
		Exp.text = "Experience: " + experience.ToString ();
		Base.text = "Base: " + lifes.ToString() + "%";
	
		if (lifes <= 0) {
			Aud.clip=clip;
			Aud.Play();
			losed.gameObject.SetActive(true);
			Time.timeScale = 0;
		}
	}
	public bool pay(float amount){
		if (points >= amount) {
			points = points - amount;
			return true;
		} else {
			return false;
		}
	}
	public bool pay2(float amount){
		if (experience >= amount) {
			experience = experience - amount;
			return true;
		} else {
			return false;
		}
	}
	public void capture(int amount){
		lifes = lifes - amount;
	}

	public void retry(){
		Application.LoadLevel (Application.loadedLevel);
	}
	public void exit (){
		Application.Quit ();
	}
	public void mainmenu (){
		Application.LoadLevel (0);
	}
	public void addpnts(float amount){
		points += amount;
	}
	public void addexp(float amount){
		experience += amount;
	}
}
