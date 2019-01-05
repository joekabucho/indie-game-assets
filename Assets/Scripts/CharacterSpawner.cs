using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour {

	// Use this for initialization
	public GameObject[] players;
	void Start () {
		if (PlayerPrefs.GetInt("SelectedCharacter")==0){
			Instantiate (players[(0)],Vector2.zero,Quaternion.identity);
		}
			if (PlayerPrefs.GetInt("SelectedCharacter")==1){
			Instantiate (players[(1)],Vector2.zero,Quaternion.identity);
		}
	}
	
	// Update is called once per frame

}
