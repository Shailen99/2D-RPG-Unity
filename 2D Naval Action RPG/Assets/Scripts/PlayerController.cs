﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


	public float moveSpeed;
	private Rigidbody2D myRigidBody;
	// Use this for initialization
	void Start () 
	{
		myRigidBody = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
		{
			//transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
			myRigidBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, myRigidBody.velocity.y);
		}
		else
		{
			myRigidBody.velocity = new Vector2(0f, myRigidBody.velocity.y);
		}
		if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
		{
			//transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
			myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed);
		}
		else
		{
			myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, 0f);
		}﻿
	}

}
