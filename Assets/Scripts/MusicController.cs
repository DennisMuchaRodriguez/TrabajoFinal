using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{

    private AudioSource _compAudioSource;
    // Start is called before the first frame update
    void Awake()
    {
        _compAudioSource = GetComponent<AudioSource>();

    }

    public void PlayMusic()
    {

        _compAudioSource.Play();
    }
}
