using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponActivator : MonoBehaviour {

	public GameObject weapon;
	public GameObject trigger;

	public bool weaponActive;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (weaponActive && other.gameObject.name == "Player") {
		
			trigger.SetActive (false);
			weaponActive = true;
			weapon.SetActive (true);
		}
	}

}
