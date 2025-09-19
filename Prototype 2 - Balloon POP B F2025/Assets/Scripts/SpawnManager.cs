using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPrefabs; //Array to store balloon game objects
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;
    public float xRange = 10.0f;
    public float yPos = -10.0f;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);
    }

    void SpawnRandomBalloon()
    {
        // Get a random position on the x-axis
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), yPos, 0);
        // Pick a random balloon from the balloon array
        int balloonIndex = Random.Range(0, balloonPrefabs.Length);
        // Spawn the random balloon at the spawn position
        Instantiate(balloonPrefabs[balloonIndex], spawnPos, balloonPrefabs[balloonIndex].transform.rotation);
    }
    
}
