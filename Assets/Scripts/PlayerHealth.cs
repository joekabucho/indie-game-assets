﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {


public bool hasDied;

	
	// Update is called once per frame
	void Update () {
	 if(gameObject.transform.position.y < -7){
		Die();
	 }
	
	}

	void Die () {
	SceneManager.LoadScene("prototype1");

	}
}
