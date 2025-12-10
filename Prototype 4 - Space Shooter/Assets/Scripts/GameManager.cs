using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public bool isPlayerDead;
    public TextMeshProUGUI endGameText; // Reference visual text UI element to change / update

   // Start is called before the first frame update
    void Start()
    {
        endGameText = GameObject.Find("EndGameText").GetComponent<TextMeshProUGUI>();// Initialize, Find, and Reference End Game UI Text
        endGameText.enabled = false; // Hide the Text via Text Renderer
        isPlayerDead = false; // Reset Player Bool
        Time.timeScale = 1; // Reset Time to normall

    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayerDead)
        {
            endGameText.enabled = true;// Show GameOver text
            Time.timeScale = 0; // Stop Game Time

        }
    }
}
