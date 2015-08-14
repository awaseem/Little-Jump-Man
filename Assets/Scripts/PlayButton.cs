using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {
	bool playButtonClicked = false;
	
	void OnMouseDown(){
		transform.FindChild("ButtonUnpressed").gameObject.SetActive(false);	
		transform.FindChild("ButtonPressed").gameObject.SetActive(true);
	}
	
	void OnMouseUp(){
		transform.FindChild("ButtonUnpressed").gameObject.SetActive(true);	
		transform.FindChild("ButtonPressed").gameObject.SetActive(false);
		setButtonClick(true);
		audio.Play();
	}
	
	public bool getButtonClick(){
		return playButtonClicked;
	}
	public void setButtonClick(bool value){
		playButtonClicked = value;
	}
}
