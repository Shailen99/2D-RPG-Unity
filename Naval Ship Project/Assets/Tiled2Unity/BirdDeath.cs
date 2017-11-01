﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdDeath : MonoBehaviour {
	public int damageToGive;
	public GameObject damageBurst;
	public Transform hitPoint;

	public GameObject food;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Enemy") {
			other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);
			Instantiate (damageBurst, hitPoint.position, hitPoint.rotation);
		}
	}
}