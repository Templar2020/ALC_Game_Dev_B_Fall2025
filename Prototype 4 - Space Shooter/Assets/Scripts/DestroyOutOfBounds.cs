using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float topBounds = 50.0f;
    public float lowerBounds = -20.0f;

    private ScoreManager scoreManager;// * Add ScoreManager
    private DetectCollisions detectCollisions;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // *Initialize scoreManager
        detectCollisions = GetComponent<DetectCollisions>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > topBounds)
        {
            Destroy(gameObject);  // Destroy the projectile              
        }

        else if(transform.position.y < lowerBounds)
        {
            scoreManager.DecreaseScore(detectCollisions.scoreToGive); //Everytime a ship sneeks past the lower bounds deduct points from the score. 
            Destroy(gameObject); // Destroy the enemy
        }
    }
}
