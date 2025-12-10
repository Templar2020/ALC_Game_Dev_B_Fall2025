using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;

    public float spawnRangeX;
    public float spawnPosY;

    public float startDelay;
    public float spawnInterval;


    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnRandomEnemy",startDelay,spawnInterval); 
    }

    void SpawnRandomEnemy()
    {
        //Generate a position to spawn at
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),spawnPosY,0);
        //Pick a random enemy from the array
        int enemyIndex = Random.Range(0,enemyPrefabs.Length);
        //Spawn the enemy indexed from the array
        Instantiate(enemyPrefabs[enemyIndex], spawnPos,enemyPrefabs[enemyIndex].transform.rotation);
    }
}