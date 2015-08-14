using UnityEngine;
using System.Collections;

public class SoundButton : MonoBehaviour {
	static bool SoundButtonClicked = false;
	static bool soundOff = false;
	
	void Update(){
		if (SoundButtonClicked){
			transform.FindChild("SoundOff").gameObject.SetActive(true);
			transform.FindChild("SoundOn").gameObject.SetActive(false);
			AudioListener.volume = 0.0f;
			
		}
		else{
			transform.FindChild("SoundOff").gameObject.SetActive(false);
			transform.FindChild("SoundOn").gameObject.SetActive(true);
			AudioListener.volume = 1.0f;
		}
	}
	
	void OnMouseDown(){
		transform.FindChild("SoundButtonUnpressed").gameObject.SetActive(false);	
		transform.FindChild("SoundButtonPressed").gameObject.SetActive(true);
		if (SoundButtonClicked){
			setSoundButtonClicked(false);
			setSoundOff(false);
		}
		else{
			setSoundButtonClicked(true);
			setSoundOff(true);
		}
		audio.Play ();
		
	}
	
	void OnMouseUp(){
		transform.FindChild("SoundButtonUnpressed").gameObject.SetActive(true);	
		transform.FindChild("SoundButtonPressed").gameObject.SetActive(false);
	}
	
	public bool getSoundButtonClicked(){
		return SoundButtonClicked;
	}
	public void setSoundButtonClicked(bool value){
		SoundButtonClicked = value;
	}
	
	public bool getSoundOff(){
		return soundOff;
	}
	public void setSoundOff(bool value){
		soundOff = value;
	}
}
