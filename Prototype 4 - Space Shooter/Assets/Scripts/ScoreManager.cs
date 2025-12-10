using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // include the UI library namespace

public class ScoreManager : MonoBehaviour
{
    public int score; // Store the score
    public TextMeshProUGUI scoreText; // Reference visual text UI element to change / update

    public void IncreaseScore(int amount)
    {
        score += amount; // add amount to the score
        UpdateScoreText(); // Update the score UI text
    }

    public void DecreaseScore(int amount)
    {
        score -= amount; // subtract amount of the score
        UpdateScoreText(); // Update the score UI text
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: "+ score; //Update the score text UI
    }
}