using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolAI : MonoBehaviour {

	public Transform[] patrolPoints;
	public float speed;
	Transform currentPatrolPoint;
	int currentPatrolIndex; 
	// Use this for initialization
	void Start () {
		currentPatrolIndex = 0;
		currentPatrolPoint = patrolPoints [currentPatrolIndex];
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.up * Time.deltaTime* speed);
		//Check to see if we reached the patrol point
		if (Vector3.Distance (transform.position, currentPatrolPoint.position) < .1f) {//Go to next patrol point after reaching the prior one.
			if (currentPatrolIndex + 1 < patrolPoints.Length) {
				currentPatrolIndex++;
			} else {
				currentPatrolIndex = 0;
			}
			currentPatrolPoint = patrolPoints [currentPatrolIndex];
		}

		Vector3 patrolPointDir = currentPatrolPoint.position - transform.position;
		float angle = Mathf.Atan2 (patrolPointDir.y, patrolPointDir.x) * Mathf.Rad2Deg - 90f;

		Quaternion q = Quaternion.AngleAxis (angle, Vector3.forward);
		transform.rotation = Quaternion.RotateTowards (transform.rotation, q, 180f);
	}
}
