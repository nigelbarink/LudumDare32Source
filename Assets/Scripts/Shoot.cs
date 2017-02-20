using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shoot : MonoBehaviour {
	float time =0; 
	public float reload = 6;
	public int Damage = 25;
	public GameObject PS ;
	public AudioSource Aud;
	public AudioClip clip;
	public void Update (){
		time -= Time.deltaTime ;

	}
		void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "BOT" && time <= 0) {
			Debug.Log("shot get fired!!");
			PS.GetComponent<ParticleSystem>().Play();
			Aud.clip=clip;
			Aud.Play();
			col.GetComponent<AI>().takedamage(Damage);
			time = reload;
			Debug.Log("shot happend");

		}
	}

}
