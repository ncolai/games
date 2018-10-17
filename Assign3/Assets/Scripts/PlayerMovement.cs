using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 100f;
    public float sidewaysTorque = 3f;

	// Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKey("d")) 
        {
            //rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            rb.AddTorque(0, sidewaysTorque, 0);
        } else if (Input.GetKey("a"))
        {
            rb.AddTorque(0, -sidewaysTorque, 0);
        } else if (Input.GetKey("w"))
        {
            rb.AddRelativeForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
            //rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        } else if (Input.GetKey("s")) 
        {
            rb.AddRelativeForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
