using UnityEngine;
using System.Collections;

public class randomPlatformSpawner : MonoBehaviour {

	public float upperMaxHeight;
	public float upperMinHeight;
	public float lowerMaxHeight;
	public float lowerMinHeight;
	
	GameObject platfrom;
	Vector3 platformHeight;
	
	void Start () {
		string platfromName;
		for (int i = 1; i <= 4; i++){
			platfromName = "Platform" + (i.ToString());
			getPlatforms(platfromName);
			setPlatformHeight(Random.Range(0,2));
		}
	}
	
	void getPlatforms(string name){
		platfrom = transform.Find(name).gameObject;
	}
	
	void setPlatformHeight(float heightNumber){
		if (heightNumber >= 0.5f){
			platformHeight = platfrom.transform.position;
			platformHeight.y = Random.Range(upperMaxHeight, upperMinHeight);
			platfrom.transform.position = platformHeight;
		}
		else{
			platformHeight = platfrom.transform.position;
			platformHeight.y = Random.Range(lowerMaxHeight, lowerMinHeight);
			platfrom.transform.position = platformHeight;
		}
	}
	
}
