using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour {
private float timeleft=120;
public int playerScore=0;
public GameObject timeleftUI;
public GameObject playerScoreUI;
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
		timeleftUI.gameObject.GetComponent<Text>().text=("Time Left:" + (int)timeleft);
		playerScoreUI.gameObject.GetComponent<Text>().text=("Score:" + playerScore);
		timeleft-=Time.deltaTime;
		if (timeleft < 0.1f){
			SceneManager.LoadScene("prototype1");
		}
		
	}
	void OnTriggerEnter2D(Collider2D trig)
	{
		if (trig.gameObject.name =="EndLevel"){
           CountScore();
		}
		if (trig.gameObject.name=="coin"){
            playerScore += 10;
			Destroy (trig.gameObject);
		}
		
	}
	void CountScore(){
		playerScore=playerScore + (int)(timeleft * 10);
		
	}
}
