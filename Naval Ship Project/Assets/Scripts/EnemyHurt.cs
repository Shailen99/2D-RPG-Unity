using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHurt : MonoBehaviour {

	public GameObject Entrance;
	public GameObject Exit;
	public GameObject OverworldEnter;
	public int damageToGive;
	public GameObject damageBurst;
	public Transform hitPoint;
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
			//Tutorial Area
			Exit.SetActive (false);
			OverworldEnter.SetActive (true);
			Entrance.SetActive (false);
			Instantiate (damageBurst, hitPoint.position, hitPoint.rotation);
		}
	}
}
