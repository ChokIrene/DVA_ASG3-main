using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    public AudioSource clickAudioSource;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button
        {
            PlayClickSound();
        }
    }

    void PlayClickSound()
    {
        if (clickAudioSource != null)
        {
            clickAudioSource.Play();
        }
    }
}
