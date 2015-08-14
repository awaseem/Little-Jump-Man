using UnityEngine;
using System.Collections;

public class backGroundMover : MonoBehaviour {

	public float objectSpeed;
	Vector2 left = new Vector2(-1,0);
	bool tileMovement = true;
	
	// Update is called once per frame
	void Update () {
		if (getTileMovement()){
			transform.Translate(left * objectSpeed);	
		}
	}
	
	public void changeSpeed(float value){
		objectSpeed = value;
	}
	
	public void setTileMovement(bool value){
		tileMovement = value;
	}
	
	public bool getTileMovement(){
		return tileMovement;
	}
}
