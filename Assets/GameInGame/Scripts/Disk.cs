﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disk : MonoBehaviour {

    private int hp;
    public RawImage[] diskHp;
    private AudioSource cdCrackAudio;
    public AudioClip cdCrackClip;

    private void Start()
    {
        hp = 3;
        cdCrackAudio = (gameObject.AddComponent<AudioSource>() as AudioSource);
        cdCrackAudio.clip = cdCrackClip;
    }

    public void LoseHp()
    {
        if (!this.IsBroken())
        {
            cdCrackAudio.Play();
            diskHp[hp].gameObject.SetActive(false);
            hp--;
            diskHp[hp].gameObject.SetActive(true);
            if (this.IsBroken())
                diskHp[hp].gameObject.SetActive(true);
        }
    }

    public bool IsBroken()
    {
        if (hp <= 0)
            return true;
        else return false;
    }

    public void RefillHp()
    {
        hp = 3;
        diskHp[hp].gameObject.SetActive(true);
        for (int i = 0; i < diskHp.Length - 2; i++)
            diskHp[i].gameObject.SetActive(false);
    }
}
