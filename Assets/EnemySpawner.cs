using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 2f; // Rate at which enemies spawn
    private float nextSpawnTime = 0f;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        nextSpawnTime += Time.deltaTime;
        if (nextSpawnTime >= spawnRate)
        {
            SpawnEnemy();
            nextSpawnTime = 0;
        }
    }

    void SpawnEnemy()
    {
        float y = 2 * Random.Range(-2, 3); // Randomize the y position of the spawn

        Vector3 spawnPosition = new Vector3(mainCamera.transform.position.x + 10, y, 0); // Spawn position is 10 units to the right of the camera


        // Instantiate enemy at the spawn position
        GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        // You can add more configurations or scripts to your enemy here if needed
    }
}
