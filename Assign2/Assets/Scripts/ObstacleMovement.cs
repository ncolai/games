using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

    //public float obstacleForce = 10f;
    private float obstacleForce = 10f;
    private readonly float obstacleBounds = 7f;
    public Rigidbody rb;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(obstacleForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (rb.position.x > obstacleBounds && obstacleForce > 0) {
            obstacleForce *= -1;
        }
        if (rb.position.x < -obstacleBounds && obstacleForce < 0) {
            obstacleForce *= -1;
        }
    }
}
