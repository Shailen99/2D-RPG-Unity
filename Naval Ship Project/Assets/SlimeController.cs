using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlimeController : MonoBehaviour {

	public float moveSpeed;
	private Rigidbody2D myRigidBody2D;
	private bool moving;
	public float timeBetweenMove;
	private float timeBetweenMoveCounter;
	public float timeToMove;
	private float timeToMoveCounter;

	private Vector3 moveDirection;

	public float waitToReload;
	private bool reloading;

	// Use this for initialization
	void Start () {
		myRigidBody2D = GetComponent<Rigidbody2D> ();

		timeBetweenMove = timeBetweenMoveCounter;
		timeToMove = timeToMoveCounter;
		
	}

	// Update is called once per frame
	void Update () {

		if (moving) {
			timeBetweenMoveCounter -= Time.deltaTime;
			myRigidBody2D.velocity = moveDirection;
			if (timeBetweenMoveCounter < 0f) {
				moving = false;
				timeBetweenMoveCounter = timeBetweenMove;
			}
		} else {
			timeBetweenMoveCounter -= Time.deltaTime;
			myRigidBody2D.velocity = Vector2.zero;
			if (timeBetweenMoveCounter < 0f) {
				moving = true;
				timeToMove = timeToMoveCounter;

				moveDirection = new Vector3 (Random.Range (-1f, 1f) * moveSpeed,Random.Range(1f,-1f) * moveSpeed, 0f);
			}
		}
		if (reloading = true) {
			waitToReload -= Time.deltaTime;
			if (waitToReload < 0) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}
		}
		
	}
	void OnCollisionEnter2D(Collision2D other)
	{ 
		if (other.gameObject.name == "Player") {
			//Destroy (other.gameObject);
			other.gameObject.SetActive(false);
			reloading = true;
		}
	}
}
