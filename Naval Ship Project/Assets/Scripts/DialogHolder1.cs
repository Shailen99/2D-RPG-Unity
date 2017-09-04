using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogHolder1 : MonoBehaviour {

	public string dialogue;
	private DialogueManager dCoconut;

	public string[] dialogueLines;

	// Use this for initialization
	void Start () {
		dCoconut = FindObjectOfType<DialogueManager> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay2D(Collider2D other)
	{
		if(other.gameObject.name == "Player")
		{
			if(Input.GetKey(KeyCode.Space))
			{
				//dCoconut.ShowBox (dialogue);
				if (!dCoconut.dialogActive) {
					dCoconut.dialogLines = dialogueLines;
					dCoconut.currentLine = 0;
					dCoconut.showDialogue();
				}
			}
		}
	}
}