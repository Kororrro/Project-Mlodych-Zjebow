using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public float spawnSpeed;
    public float spawnRadius;
    public GameObject enemyPrefab;
    float timeForSpawn = 0f;

    void Update() {
        timeForSpawn += Time.deltaTime;
        if (timeForSpawn >= spawnSpeed) {
            timeForSpawn = 0;

            for (int i = 0; i < 2; i++) {
                Spawn();
            }
        }
    }
    void Spawn() {
        Vector3 spawnPos = transform.position + Random.insideUnitSphere * spawnRadius;
        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);

    }
}

