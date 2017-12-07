using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScrollActivator : MonoBehaviour {

	public GameObject Scroll;

	public bool scrollActive;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (scrollActive && Input.GetKeyDown (KeyCode.Space))
			{
			Scroll.SetActive (false);
			}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Player") {
			Scroll.SetActive (true);
			scrollActive = true;
		}
	}

}
