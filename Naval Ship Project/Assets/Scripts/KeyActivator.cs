using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyActivator : MonoBehaviour {

	public GameObject key;
	public bool keyActive;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (keyActive && other.gameObject.name == "Player") {
			key.SetActive (true);
			keyActive = false;
		}
	}

}
