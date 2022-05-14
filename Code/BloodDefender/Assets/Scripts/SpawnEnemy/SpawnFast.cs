using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFast : MonoBehaviour
{
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject fast;
    [SerializeField] float v;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemies", 0f, v);
    }

    void SpawnEnemies()
    {
        int index = Random.Range(0, spawnPoints.Length);
        Instantiate(fast, spawnPoints[index].position, spawnPoints[index].rotation);
    }
}
