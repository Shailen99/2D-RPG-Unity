using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueOpener : MonoBehaviour {

	public GameObject dialogBox;
	public GameObject EnemyHolder;
public GameObject DialogInitiator;
	public bool dialogActive;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
if(dialogActive && Input.GetKeyDown(KeyCode.Space))
{
	dialogBox.SetActive(false);
	dialogActive = false;
	EnemyHolder.SetActive(true);
	DialogInitiator.SetActive(false);
}
	}
public void ShowBox(string dialogue)
{
	dialogActive=true;
	dialogBox.SetActive(true);
}

void OnTriggerEnter2D(Collider2D other)
{
if(other.gameObject.name == "Player")
{
	dialogBox.SetActive(true);
	dialogActive = true;
	EnemyHolder.SetActive(true);

}
}

}
