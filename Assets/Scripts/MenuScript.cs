using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	float time = 0.3f;
	static Vector3 MenuPosition;
	static bool firstRun = true;
	
	void Start(){
		if (!firstRun){
			transform.position = MenuPosition;
			GameObject.Find("Player").rigidbody2D.isKinematic = false;
			audio.Play();
		}
	}

	void Update () {
		if (firstRun){
			if (gameObject.GetComponentInChildren<PlayButton>().getButtonClick()){
				time -= Time.deltaTime;
				if (transform.position.y <= 10f && time <= 0){
					transform.Translate(new Vector2(0f,2f) * 0.2f);
				}
				else if (transform.position.y > 10f){
					gameObject.GetComponentInChildren<PlayButton>().setButtonClick(false);
					time = 0.3f;
					MenuPosition = transform.position;
					firstRun = false;
					Application.LoadLevel(0);	
				}
			}
		}
		else{
			if (gameObject.GetComponentInChildren<PlayButton>().getButtonClick()){
				time -= Time.deltaTime;
				if (transform.position.y <= 10f && time <= 0){
					transform.Translate(new Vector2(0f,2f) * 0.2f);
				}
				else if (transform.position.y > 10f){
					gameObject.GetComponentInChildren<PlayButton>().setButtonClick(false);
					time = 0.3f;
					Application.LoadLevel(0);
				}
			}
			if (GameObject.Find("Player").GetComponent<PlayerBehaviour>().getPlayerDeath()){
				if (transform.position.y >= 1f){
					transform.Translate(new Vector2(0,-2f) * 0.2f);
				}
				else if (transform.position.y < 1f){
					GameObject.Find("Player").GetComponent<PlayerBehaviour>().setPlayerDeath(false);
				}	
			}
		}
	}
	
	public bool getFirstRun(){
		return firstRun;
	}
	
}
