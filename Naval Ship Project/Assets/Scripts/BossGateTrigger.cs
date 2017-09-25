using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossGateTrigger : MonoBehaviour {

	public GameObject Key;
	public GameObject Gate;

	public bool keyActive;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (keyActive && other.gameObject.tag == "Player" ) {
			keyActive = true;
			Gate.SetActive (false);
			Key.SetActive (false);
		}
	}
}
