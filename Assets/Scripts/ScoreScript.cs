using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {
	string number;
	float ScoreCounter;
	float maxScoreThreshold = 10f;
	float lastScore;
	float currentThreshold = 0f;
	float nextNumber = 0;
	// Update is called once per frame
	void Update () {
		lastScore = ScoreCounter;
		if (GameObject.Find("Player").GetComponent<PlayerBehaviour>().getScore() >= maxScoreThreshold){
			if (nextNumber >= 1){
				transform.FindChild("Number"+nextNumber+"(Clone)").gameObject.SetActive(false);
			}
			GameObject value = Instantiate(transform.FindChild("Number"+(++nextNumber)).gameObject,new Vector3(101.5f,3.45f,0), Quaternion.identity) as GameObject;
			value.transform.parent = GameObject.Find("Score").transform;
			value.SetActive(true);
			currentThreshold = maxScoreThreshold;
			maxScoreThreshold += 10f;
		}
		ScoreCounter = GameObject.Find("Player").GetComponent<PlayerBehaviour>().getScore() - currentThreshold;
		if ( GameObject.Find("Player").GetComponent<PlayerBehaviour>().getScore() != 0){
			transform.FindChild("Number"+lastScore).gameObject.SetActive(false);
			number = "Number"+ScoreCounter;
			transform.FindChild(number).gameObject.SetActive(true);
		}
		unlockAchievement();
	}
	
	void unlockAchievement(){
		float score = GameObject.Find("Player").GetComponent<PlayerBehaviour>().getScore();
		
		if (GameObject.Find("Player").GetComponent<PlayerBehaviour>().getPlayerDeath()){
			Social.ReportScore((long)PlayerPrefs.GetFloat("score"), "CgkIsZeu5LEeEAIQBg", (bool success) => {
			});
			if (PlayerPrefs.GetFloat("score") < score){
				PlayerPrefs.SetFloat("score", score);
				PlayerPrefs.Save();
			}
		}
		
		if (score > 1){
			Social.ReportProgress("CgkIsZeu5LEeEAIQAQ", 100.0f, (bool success) => {
				// handle success or failure
			});
		}
		
		if (score > 10){
			Social.ReportProgress("CgkIsZeu5LEeEAIQAg", 100.0f, (bool success) => {
				// handle success or failure
			});
		}
		
		if (score > 30){
			Social.ReportProgress("CgkIsZeu5LEeEAIQAw", 100.0f, (bool success) => {
				// handle success or failure
			});
		}
		
		if (score > 50){
			Social.ReportProgress("CgkIsZeu5LEeEAIQBA", 100.0f, (bool success) => {
				// handle success or failure
			});
		}
		
		if (score > 70){
			Social.ReportProgress("CgkIsZeu5LEeEAIQBQ", 100.0f, (bool success) => {
				// handle success or failure
			});
		}
		
	}
}
