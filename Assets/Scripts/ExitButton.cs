using UnityEngine;
using System.Collections;
using GooglePlayGames;

public class ExitButton : MonoBehaviour {
	bool ExitButtonClicked = false;
	static bool playActive = false;
	static bool authenticateActive = false;
	
	void Start(){
		if (!playActive){
			PlayGamesPlatform.Activate();
			playActive = true;	
		}
		
		if (!authenticateActive){
			if (PlayerPrefs.GetInt("Authenticate") == 1){
				Social.localUser.Authenticate((bool success) => {
				});
				authenticateActive = true;
			}
		}
	}
	
	void OnMouseDown(){
		transform.FindChild("ExitButtonUnpressed").gameObject.SetActive(false);	
		transform.FindChild("ExitButtonPressed").gameObject.SetActive(true);
		audio.Play();
	}
	
	void OnMouseUp(){
		transform.FindChild("ExitButtonUnpressed").gameObject.SetActive(true);	
		transform.FindChild("ExitButtonPressed").gameObject.SetActive(false);
		((PlayGamesPlatform) Social.Active).ShowLeaderboardUI("CgkIsZeu5LEeEAIQBg");
		Social.localUser.Authenticate((bool success) => {
			if (success){
				PlayerPrefs.SetInt("Authenticate",1);
				((PlayGamesPlatform) Social.Active).ShowLeaderboardUI("CgkIsZeu5LEeEAIQBg");
			}
		});
	}
	
	public bool getExitButtonClicked(){
		return ExitButtonClicked;
	}
	public void setExitButtonClicked(bool value){
		ExitButtonClicked = value;
	}
}
