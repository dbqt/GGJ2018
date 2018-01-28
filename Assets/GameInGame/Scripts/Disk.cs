using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disk : MonoBehaviour {

    private int hp;
    public RawImage[] diskHp;
    public RawImage damageEffect;
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
            this.ScreenDamage();
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

    IEnumerator DamageEffectFade()
    {
        float alpha = transform.renderer.material.color.a;
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
        {
            Color newColor = new Color(1, 1, 1, Mathf.Lerp(alpha, aValue, t));
            transform.renderer.material.color = newColor;
            yield return null;
        }
    }
}
