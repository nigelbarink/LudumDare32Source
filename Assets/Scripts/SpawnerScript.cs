using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SpawnerScript : MonoBehaviour {
	// public 
	public GameObject[] types  = new GameObject[2] ;
	public Vector3 spawnvec;
	//non-public 
	float spawnrate = 0;
	float time;
	int spawncount = 1;
	public bool win = false;
	public int wave = 0;
	public GameObject winstate;
	public AudioClip clip ;
	public AudioSource Aud;
	public void Start() {
		spawnrate = spawncount *10 /5 ;
		time = spawnrate;
		spawnvec = this.transform.position;
	}
	public void Update () {
		time -= Time.deltaTime;
	if(win){
			Aud.clip = clip;
			Aud.Play();
			Time.timeScale = 0;
			winstate.SetActive (true);
		}
		if (time <= 0f) {
			switch (wave) {
			case 0:
				spawn (types [0]);
				break;
			case 1:
				spawn (types [0]);
				break;
			// TODO: make 3 enemies 
			case 2:
				spawn (types [1]);
				break;
			case 3:
				spawn (types [2]);
				break;
			case 4:
				spawn (types [3]);
				break;
			case 5:
				spawn (types [Random.Range (0, types.Length)]);
				break;
			case 6:
				Aud.clip = clip;
				Aud.Play();
				Time.timeScale = 0;
				winstate.SetActive (true);
				break;
			}
		}
	}
public void spawn(GameObject Enemy){
		time = spawnrate;
		GameObject.Instantiate (Enemy, spawnvec , Quaternion.identity);
		spawncount++;
		return;
	}
}

