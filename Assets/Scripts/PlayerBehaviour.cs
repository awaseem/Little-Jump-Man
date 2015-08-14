using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {
	
	bool buttonPushed;
	bool didJump;
	Animator animate;
	bool isPlayerDead = false;
	public float jumpHeight;
	float score;
	// Use this for initialization
	void Start () {
		animate = transform.GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (didJump == true){
			animate.SetTrigger("Jump");
		}
		if (didJump == false){
			animate.SetTrigger("Running");
		}
		if (PlayerControls.buttonInput() && buttonPushed == false){
			rigidbody2D.AddForce(Vector2.up * jumpHeight);
			audio.Play();
			buttonPushed = true;
		}
	}
	
	void OnCollisionEnter2D(Collision2D collision){
		buttonPushed = false;
		didJump = false;
		score++;
	}
	
	void OnCollisionExit2D(Collision2D collision){
		didJump = true;
		buttonPushed = true;
	} 
	
	public void setPlayerDeath(bool value){
		isPlayerDead = value;
	}
	
	public bool getPlayerDeath(){
		return isPlayerDead;
	}
		
	public float getScore(){
		return score;
	}
	
}
