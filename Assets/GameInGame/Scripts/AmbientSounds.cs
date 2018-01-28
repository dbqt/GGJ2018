using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSounds : MonoBehaviour {

    private AudioSource snoringAudio;
    public AudioClip snoringClip;

    private void Start()
    {
        snoringAudio = (gameObject.AddComponent<AudioSource>() as AudioSource);
        snoringAudio.clip = snoringClip;
        snoringAudio.loop = true;

        snoringAudio.Play();
    }
}
