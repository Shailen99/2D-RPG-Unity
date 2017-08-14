using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewArea : MonoBehaviour {

	public string loadToLevel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void onTriggerEnter(Collider2D other)
	{
		if (other.gameObject.name == "Player") {
			SceneManager.LoadScene(loadToLevel);﻿
		}
	}
}
