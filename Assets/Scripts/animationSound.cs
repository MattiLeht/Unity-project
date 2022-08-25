using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationSound : MonoBehaviour
{
    public AudioSource audioSource;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play_sound()
    {
        audioSource.Play();
    }
}
