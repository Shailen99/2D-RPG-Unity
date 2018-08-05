using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAI : MonoBehaviour {

	public float attackRange;
	public Transform target;
	Transform currentPatrolPoint;
	int currentPatrolIndex;
	public Transform[] patrolPoints;

	public int damage;
	private float lastAttackTime;
	public float attackDelay;
	public GameObject projectile;
	public float shotForce;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		float distanceToPlayer = Vector3.Distance (transform.position, target.position);
		if (distanceToPlayer < attackRange) {
			Vector3 targetDir = target.position - transform.position;
			float angle = Mathf.Atan2 (targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
			Quaternion q = Quaternion.AngleAxis (angle, Vector3.forward);
			transform.rotation = Quaternion.RotateTowards (transform.rotation, q, 90 * Time.deltaTime);
			if (Time.time > lastAttackTime + attackDelay) {
				RaycastHit2D hit = Physics2D.Raycast (transform.position, transform.up, attackRange);
				if(hit.transform == target){
					GameObject NewShot = Instantiate (projectile, transform.position, transform.rotation);
					NewShot.GetComponent <Rigidbody2D>().AddRelativeForce (new Vector2(0f,shotForce));
					lastAttackTime = Time.time;
				}
			}
		}
	}
}
