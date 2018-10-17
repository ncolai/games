using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public Rigidbody enemyRb;
    public Transform enemyLoc;
    public Transform playerLoc;
    public float enemyForce = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void Update () {
        enemyLoc.LookAt(playerLoc);
        enemyRb.AddRelativeForce(0, 0, enemyForce * Time.deltaTime, ForceMode.VelocityChange);
	}
}
