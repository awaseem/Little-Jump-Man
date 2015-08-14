using UnityEngine;
using System.Collections;

public class DeathScript : MonoBehaviour {

	public bool isPlayerDeath = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerExit2D(Collider2D Player){
		if (Player.name == "Player"){
			Player.transform.GetComponent<PlayerBehaviour>().setPlayerDeath(true);
			Player.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
			Player.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
		}
	}
}
