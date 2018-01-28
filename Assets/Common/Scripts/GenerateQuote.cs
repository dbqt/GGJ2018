using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateQuote : MonoBehaviour{
    [SerializeField] bool IsMale;
    [SerializeField] AudioClip[] maleClips;
    [SerializeField] AudioClip[] femaleClips;

    private AudioSource source;

    void Start()
    {
        source.clip = ChooseQuote();
    }
	
    private AudioClip ChooseQuote()
    {
        if (IsMale)
        {
            return maleClips[Random.Range(0, maleClips.Length - 1)];
        }
        return femaleClips[Random.Range(0, femaleClips.Length - 1)];
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            source.Play();
        }
    }
}
