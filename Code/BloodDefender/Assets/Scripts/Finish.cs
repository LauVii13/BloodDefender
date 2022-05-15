using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene("EndGame");
    }

    void Update()
    {
       if(Input.GetKey(KeyCode.Return) == true)
        {
            LoadNextLevel();
        }
    }
}
