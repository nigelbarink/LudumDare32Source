using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

	public float lives = 25; 
	public GameObject target ;

	NavMeshAgent nav ;
	Economy eco ;
	public void Start(){
		eco = GameObject.Find("Gamemanager").GetComponent<Economy> ();
		nav = GetComponent<NavMeshAgent> ();
		target = GameObject.Find ("Human's Base");
		if (target != null) {
			nav.SetDestination (target.transform.position);
		}
	}

	public void Update (){
		if (lives <= 0) {
			eco.addexp( 10);
			eco.addpnts( 200);
			Destroy(this.gameObject);
		}
	}
	public void takedamage(int Amount){
		lives = lives - Amount;
	}

}
