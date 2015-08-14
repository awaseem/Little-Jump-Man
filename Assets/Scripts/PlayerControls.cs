using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {
	
	public static bool buttonInput(){
	
		if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
			return true; 
		}
		else{
			return false;
		}
	
	}
}
