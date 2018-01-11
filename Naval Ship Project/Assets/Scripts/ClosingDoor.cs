using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosingDoor : MonoBehaviour {

public GameObject HiddenWall;
public GameObject closingWall;
public GameObject closingWall2;

	// Use this for initialization
	void Start () {

	}


	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D (Collider2D other)
	{
if(other.gameObject.name == "Player")
{
	HiddenWall.SetActive(true);
	closingWall.SetActive(true);
	closingWall2.SetActive(true);
}
	}
}
