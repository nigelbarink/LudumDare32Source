using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class clickchecker : MonoBehaviour {
	Shoot s ;
	Economy eco ;
	public Text cCounter;
	float cost= 0;
	int Upgrade=1;
	float Durability = 180f; 
	public GameObject button;
	public AudioSource Aud;
	public AudioClip[] clip;

	public void Start(){
		s = GetComponent<Shoot> ();
		eco = GameObject.Find ("Gamemanager").GetComponent<Economy> (); 
	}
	public void Update(){
		cost = 20 * Upgrade;
		if (cCounter != null && cost != 0)
		cCounter.text = "Upgrade Cost: " + cost.ToString (); 
		Durability -= Time.deltaTime;
		if (Durability <= 0) {
			Aud.clip = clip [1];
			Aud.Play ();
			this.gameObject.SetActive(false);
			button.GetComponent<Button>().interactable=true;
			Durability = 180f;
		}
	}
	void OnMouseOver(){
		if (Input.GetMouseButtonDown (0)) {
			if (eco.pay2 (20 * Upgrade)&& s.reload >= 2 ) {
				s.reload -= 0.25f * Upgrade - 0.25f;
				Aud.clip=clip[0];
				Aud.Play();
				Upgrade++;
			}
		}
	}
}
