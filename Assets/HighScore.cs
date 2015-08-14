using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {

	string score;
	// Update is called once per frame
	void Update () {
		score = PlayerPrefs.GetFloat("score").ToString();
		
		if (PlayerPrefs.GetFloat("score") != 0){
			for (int x=0; x<=9; x++){
				transform.FindChild("LowerNumber").FindChild("Number"+x).gameObject.SetActive(false);
				transform.FindChild("HigherNumber").FindChild("Number"+x).gameObject.SetActive(false);	
				transform.FindChild("CenterNumber").FindChild("Number"+x).gameObject.SetActive(false);
			}
			
			if (score.Length == 1){
				transform.FindChild("CenterNumber").FindChild("Number"+score).gameObject.SetActive(true);
			}
			
			if (score.Length == 2){
				transform.FindChild("LowerNumber").FindChild("Number"+score[1]).gameObject.SetActive(true);
				transform.FindChild("HigherNumber").FindChild("Number"+score[0]).gameObject.SetActive(true);	
			}
		}
	}
}
