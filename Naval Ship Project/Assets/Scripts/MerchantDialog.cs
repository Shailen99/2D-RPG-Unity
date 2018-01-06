using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MerchantDialog : MonoBehaviour {

public GameObject dialogBox;
public GameObject dialogBox2;
public bool dialogActive;
public bool dialogSecondBoxActive;
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
	dialogBox2.SetActive(true);
	dialogSecondBoxActive = true;
}
if(dialogActive && Input.GetKeyDown(KeyCode.N))
{
	dialogBox.SetActive(false);
	dialogActive = false;
	dialogSecondBoxActive = false;
}
//Dialog Box 2
if(dialogSecondBoxActive && Input.GetKeyDown(KeyCode.Space))
{
	dialogBox2.SetActive(false);
	dialogSecondBoxActive = false;

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
