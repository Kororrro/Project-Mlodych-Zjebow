using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRadius = 5f;
    public float spawnRate = 5f;
    private float timeSinceLastSpawn = 0f;
    public GameObject target;

    void Update() {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= spawnRate)
        {
            timeSinceLastSpawn = 0;

            for (int i = 0; i < 2; i++)
            {
                SpawnEnemy();
            }
        }
    }
    void SpawnEnemy()
    {
        Vector3 spawnPos = transform.position + Random.insideUnitSphere * spawnRadius;
        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        
    }
}
