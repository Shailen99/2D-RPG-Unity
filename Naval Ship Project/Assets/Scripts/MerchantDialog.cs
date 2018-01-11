using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MerchantDialog : MonoBehaviour {

public GameObject WeaponAxe;

public GameObject dialogBox;
public bool dialogActive;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//Dialog Box 1
if(dialogActive && Input.GetKeyDown(KeyCode.Y))
 {
	dialogBox.SetActive(false);
	dialogActive = false;
	WeaponAxe.SetActive(true);

 }
if(dialogActive && Input.GetKeyDown(KeyCode.N))
 {
	dialogBox.SetActive(false);
	dialogActive = false;
 }
}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.name == "Player")
			{
			dialogBox.SetActive(true);
			dialogActive = true;
			}
		}
	}
