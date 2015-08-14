using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {
	float time = 1f;
	int i = 3;
	string number;
	// Use this for initialization
	void Start () {
		GameObject.Find("Player").rigidbody2D.isKinematic = true;
		GameObject.Find("Tiles").GetComponent<backGroundMover>().setTileMovement(true);
	}
	
	// Update is called once per frame
	void Update () {
		if (!GameObject.Find("Menu").GetComponent<MenuScript>().getFirstRun()){
			number = "Number"+i;
			transform.FindChild(number).gameObject.SetActive(true);
			if ( time <= 0f){
				transform.FindChild(number).gameObject.SetActive(false);
				if (i != 1){
					i--;
				}
				else if( i == 1){
					transform.FindChild(number).gameObject.SetActive(false);
					GameObject.Find("Player").rigidbody2D.isKinematic = false;
					GameObject.Find("Tiles").GetComponent<backGroundMover>().setTileMovement(true);
					Destroy(gameObject);
				}
				time = 1f;
			}
			time -= Time.deltaTime;
		}
	}
}
