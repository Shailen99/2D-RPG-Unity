using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitcher : MonoBehaviour {

	private MusicManager theMC;

	public int newTrack;

	public bool switchOnStart;
	// Use this for initialization
	void Start () {
		theMC = FindObjectOfType<MusicManager> ();

		if (switchOnStart) {
			theMC.SwitchTrack (newTrack);

		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.name == "Player") {
			theMC.SwitchTrack (newTrack);
			gameObject.SetActive (false);
		}
	}
}
