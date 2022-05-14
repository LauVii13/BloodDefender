using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpFast : MonoBehaviour
{
    [SerializeField] Transform[] spawnPoitns;
    [SerializeField] GameObject fast;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFast", 1f, 1.5f);
    }
    
    void SpawnFast()
    {
        int index = Random.Range(0, spawnPoitns.Length);
        Instantiate(fast, spawnPoitns[index].position , Quaternion.identity);
    }
}
