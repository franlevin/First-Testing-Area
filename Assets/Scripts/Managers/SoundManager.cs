using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource mainTheme;
    
    // Start is called before the first frame update
    void Start()
    {
        InitializeAudio();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitializeAudio(){
        AudioSource[] audios = GetComponents<AudioSource>();
        mainTheme = audios[0];
    }
}
