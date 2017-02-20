using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {
	public RectTransform panel; 
	public Economy eco  ;
	public bool payed= false;
	public Text Cost;
	public int build = 0;
	public void Start(){
		eco = GetComponent<Economy> ();
		}
	public void Update (){
		switch(build){
		case 1:
			GameObject.Find("Spawnpoint").GetComponent<SpawnerScript>().wave = 0;
			break;
		case 2:
			GameObject.Find("Spawnpoint").GetComponent<SpawnerScript>().wave = 1;
			break;
		case 3:
			GameObject.Find("Spawnpoint").GetComponent<SpawnerScript>().wave = 2;
			break;
		case 4:
			GameObject.Find("Spawnpoint").GetComponent<SpawnerScript>().wave = 3;
			break;

		case 5:
			GameObject.Find("Spawnpoint").GetComponent<SpawnerScript>().wave = 4;
			break;
		case 6:
			GameObject.Find("Spawnpoint").GetComponent<SpawnerScript>().wave = 5;
			break;
		}
		int cost = 500 * build;
		Cost.text = "Building Cost: " + cost.ToString();
	}
	
public void Build(GameObject Tower){
			if (eco.pay (500 * build) ==  true ) {
			Tower.SetActive (true);
			payed = true ;
			build ++;
		}
	}
	public void checkpayment(Button us){
		if (payed == true) {  
			us.interactable = false;

			payed = false;
		}
	}
}