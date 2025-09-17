using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{    
    public int clickToPop = 3; //How many clicks before balloon pops

    public float scaleToIncrease = 0.15f; //Scale increased each time the ballon is clicked

    public int scoreToGive;  // Score given for the popped balloon.

    private ScoreManager scoreManager; // A variable to reference the ScoreManger
    public GameObject popEffect; //Reference Pop Effect Particle System

    // Start is called before the first frame update
    void Start()
    {
        //Reference ScoreManager Component
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnMouseDown()
    {
        // Reduce clicks by one
        clickToPop -= 1;
        //Increase balloon size
        transform.localScale += Vector3.one * scaleToIncrease;
        // Check to see if the balloon has popped
        if(clickToPop == 0)
        {
            scoreManager.IncreaseScoreText(scoreToGive); // Increase Score
            //Instantiate(popEffect, transform.position, transform.rotation); // Instantiate Particle Effect - POP Effect*
            Destroy(gameObject);// POP Balloon
        }
    }
}