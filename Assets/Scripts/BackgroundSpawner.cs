using UnityEngine;
using System.Collections;

public class BackgroundSpawner : MonoBehaviour {
	
	public GameObject Platform;
	
	bool oneAtATime = true;
	
	float timePlayerChange = 15f;
	
	float timeTileChange = 1f;
	
	float speed = 0.1f;
	
	void Update(){
		timePlayerChange -= Time.deltaTime;
		
		if (timeTileChange <= 0){
			speed += 0.00133333f;
			GameObject.Find("Tiles").GetComponent<backGroundMover>().changeSpeed(speed);
			timeTileChange = 1f;
		}
		
		if (timePlayerChange <= 0){
			GameObject.Find("Player").GetComponent<Rigidbody2D>().gravityScale++;
			GameObject.Find("Player").GetComponent<PlayerBehaviour>().jumpHeight += 50;
			timePlayerChange = 15f;
		}
		
		timeTileChange -= Time.deltaTime;
	}
	
	void OnTriggerEnter2D(Collider2D other){
		
		if (oneAtATime){
			GameObject value = Instantiate(Platform,new Vector3(129f,2f,0), Quaternion.identity) as GameObject;
			value.transform.parent = GameObject.Find("Tiles").transform;
			Platform = value;
			Platform.name = "RandomPlatform";
			oneAtATime = false;
		}
	}
	
	void OnTriggerExit2D(Collider2D other){
	
		if (other.name == "Platform4"){
			oneAtATime = true;
			Destroy(other.transform.parent.gameObject);
		}
	}
}
