using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusicCtrl : MonoBehaviour {

    public AudioClip BackgroundMusic;
    public AudioSource audioSource;

    void Start()
    {
        audioSource.PlayOneShot(BackgroundMusic, 0.4f);
    }
}
