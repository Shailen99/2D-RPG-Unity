using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateTrigger : MonoBehaviour {

	public GameObject Gate;
	public GameObject Gtrigger;
	public GameObject Enemy;

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
			Gate.SetActive (true);
			Enemy.SetActive (true);
		}
	}

}
