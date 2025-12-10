using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header ("Player Attributes")]
    public float speed = 10.0f;
    // Get input variables from the keyboard  
    private float hInput;
    

    //X-Range: How wide the player is going to move across the screen
    public float xRange;

    // Fire Mechanic Variables
    public GameObject projectile;
    public Transform firePoint;    
    
    public ParticleSystem explosionParticle; // * add particle system

    // Update is called once per frame
    void Update()
    {
        // Setup input connections to keymaps
        hInput = Input.GetAxis("Horizontal"); // 0 = no movement 1 = Right -1 = Left

        // Move the player left and right
        transform.Translate(Vector3.right * speed * hInput * Time.deltaTime);
        
        // Create a wall on the right side
        if(transform.position.x > xRange)
        {
            //Reset the players position to inside the boundry
            transform.position = new Vector3(xRange,transform.position.y,transform.position.z);
        }
        // Left wall
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }
       
        //Fire a projectile when space bar is pressed
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, firePoint.transform.position, firePoint.transform.rotation);
        }      

    }

     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Explosion();
        }
    }

    void Explosion()
    {
        Instantiate(explosionParticle, transform.position, Quaternion.identity);
    }
}
