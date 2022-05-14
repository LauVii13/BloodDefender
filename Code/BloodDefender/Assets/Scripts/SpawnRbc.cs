using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRbc : MonoBehaviour
{
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject rbc;
    [SerializeField] float v;

    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnEnemies", 0f, v);
    }
    
    void SpawnEnemies()
    {
        int index = Random.Range(0, spawnPoints.Length);
        Instantiate(rbc, spawnPoints[index].position, Quaternion.identity);
    }
}
