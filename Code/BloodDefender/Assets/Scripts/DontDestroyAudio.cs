using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour
{
    private bool ligado = false;

    
    private static DontDestroyAudio instance = null;

    public static DontDestroyAudio Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    public void Start()
    {



    }

    //public void PlayMusic()
    //{
    //    if (_audioSource.isPlaying) return;
    //    _audioSource.Play();
    //}

    //public void StopMusic()
    //{
    //    _audioSource.Stop();
    //}


}

