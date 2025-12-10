using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
      public ParticleSystem explosionParticle; // * add particle system
      public int scoreToGive; // *add scoreToGive
      private ScoreManager scoreManager; // *add scoreManager
      private GameManager gameManager; // *add GameManager

    // Start is called before the first frame update
    void Start()
    {
       scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // *Reference the scoremanager script component
       gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();// *Reference the gamemanager script component
    }

    void OnTriggerEnter2D(Collider2D other)
    {
         Explosion();// *Call the explosion function, which will play the particle effect.
         scoreManager.IncreaseScore(scoreToGive);// *Increase score
        //Destroy the enemy (UFO)
        Destroy(gameObject);
        //Destroy the projectile
        Destroy(other.gameObject);

        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("PlayerHit");
            gameManager.isPlayerDead = true;
        }
    }
    
    void Explosion()
    {
        Instantiate(explosionParticle, transform.position, Quaternion.identity);
    }
}
