using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUttingTree : MonoBehaviour {

	public GameObject tree;
	public GameObject wood;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Tree") {
			tree.SetActive (false);
			wood.setActive (true);
		}

}
