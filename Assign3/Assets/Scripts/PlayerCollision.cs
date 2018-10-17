using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    public PlayerMovement movement;
    public Score playerScore;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        } else if (collisionInfo.collider.tag == "Collectible")
        {
            playerScore.IncreaseScore();
            Destroy(collisionInfo.gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
