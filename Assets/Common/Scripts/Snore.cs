using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snore : MonoBehaviour {
    [SerializeField] AudioClip snoreClip;
    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = snoreClip;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            source.Play();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            source.Stop();
        }
    }
}
