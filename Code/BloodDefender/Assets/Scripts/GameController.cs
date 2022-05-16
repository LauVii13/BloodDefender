using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float TotalScore;
    public bool pain;
    public bool comeca;
    public int kill = 0;

    public bool destruir = true;

    public static GameController instance;

    

// Start is called before the first frame update
void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
