using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewArea : MonoBehaviour {

	public string levelToLoad;

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name == "Player") 
		{
			SceneManager.LoadScene(levelToLoad);
			//Destroy(col.gameObject);
		}
	}
}
