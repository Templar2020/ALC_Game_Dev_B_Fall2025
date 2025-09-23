using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float speed = 3.0f;
    public float upperBound = 15.0f;
    public ScoreManager scoreManager; //Reference the scoremanager
    public Balloon balloon;//Reference the balloon script to get the score amount



    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        balloon = GetComponent<Balloon>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime); // Move the balloon at a fixed rate of speed up on the Y axis. 

        if (transform.position.y >= upperBound)
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive);// Reduces the score for allowing the balloons to leave the screen.
            Destroy(gameObject); // Pop the balloons that leave the top of the screen  
        }
    }
}
