using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScrollActivator : MonoBehaviour {

	public GameObject OldScroll;

	public bool scrollActive;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (scrollActive && Input.GetKeyDown (KeyCode.Space))
			{
			OldScroll.SetActive (false);
			}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Player") {
			OldScroll.SetActive (true);
			scrollActive = true;
		}
	}

}
