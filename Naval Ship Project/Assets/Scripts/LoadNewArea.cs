﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewArea : MonoBehaviour {

	public string levelToLoad;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Player") 
		{
			Application.LoadLevel (levelToLoad);
		}
	}
}
