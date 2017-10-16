using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelathUpgraderFood : MonoBehaviour {

	public int healthToGive;
	public GameObject food;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter2D(Collision2D other)
	{ 
		if (other.gameObject.name == "Player") {
			food.SetActive (false);
			other.gameObject.GetComponent<PlayerHealthSystem>().PlayerHeal(healthToGive);
		}
	}
}
