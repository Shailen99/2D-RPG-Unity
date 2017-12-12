using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateTrigger : MonoBehaviour {

	public GameObject Gate1;
	public GameObject Gate2;
	public GameObject Gtrigger;
	public GameObject Enemy;
	public GameObject HiddenPath;


	public bool GateActive;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (GateActive && other.gameObject.name == "Player") {
			Gtrigger.SetActive (false);
			GateActive = true;
			Gate1.SetActive (true);
			Gate2.SetActive(true);
			Enemy.SetActive (true);
			HiddenPath.SetActive(false);
			}
		}
	}
