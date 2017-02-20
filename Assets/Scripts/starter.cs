using UnityEngine;
using System.Collections;

public class starter : MonoBehaviour {
	public GameObject intro;
	public GameObject buildMenu;
	public AudioSource Aud;
	public AudioClip[] clip;
	// Use this for initialization
	void Start () {
		Time.timeScale = 0;
		buildMenu.SetActive (false);
		Aud.clip= clip [0];
		Aud.Play ();
	}
	public void gamestart(){
		Aud.Stop ();
		Aud.clip = clip [1];
		Aud.Play ();
		Time.timeScale = 1;
		intro.SetActive (false);
		buildMenu.SetActive (true);

	}
}
