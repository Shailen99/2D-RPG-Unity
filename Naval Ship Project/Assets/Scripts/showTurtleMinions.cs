using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showTurtleMinions : MonoBehaviour {

	public GameObject Slime0;
	public GameObject Slime1;
	public GameObject Slime2;
	public GameObject Slime3;
	public GameObject Slime4;
	public GameObject trigger;

	public bool enemyActive;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (enemyActive && other.gameObject.name == "Player") {
			trigger.SetActive (false);
			enemyActive = true;
			Slime0.SetActive (true);
			Slime1.SetActive (true);
			Slime2.SetActive (true);
			Slime3.SetActive (true);
			Slime4.SetActive (true);

		}
	}

}
