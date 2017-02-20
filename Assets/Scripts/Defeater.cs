using UnityEngine;
using System.Collections;

public class Defeater : MonoBehaviour {
	public GameObject PS ;
	public AudioSource Aud;

		void OnTriggerEnter (Collider col)
		{
			if(col.gameObject.tag == "BOT")
			{
				Destroy(col.gameObject);
			Aud.Play();
			Economy eco = GameObject.Find("Gamemanager").GetComponent<Economy>();
			PS.GetComponent<ParticleSystem>().Play();
			eco.capture(5);
			}
	}
}
