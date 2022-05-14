using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpFast : MonoBehaviour
{
    [SerializeField] Transform[] spawnPoitns;
    [SerializeField] GameObject fast;
    [SerializeField] float v;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFast", 1f, v);
    }
    
    void SpawnFast()
    {
        int index = Random.Range(0, spawnPoitns.Length);
        Instantiate(fast, spawnPoitns[index].position , Quaternion.identity);
    }
}
