using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float timeLeft = 30.0f;
    public Text countdownText;
    public float criticalTimeTreshold;
    private bool isTimeCritical;
    private AudioSource warningAudio, bellRingAudio;
    public AudioClip warningClip, bellRingClip;

    private void Start()
    {
        isTimeCritical = false;
        countdownText.text = "Time Left: " + System.Math.Round(timeLeft).ToString();
        warningAudio = (gameObject.AddComponent<AudioSource>() as AudioSource);
        warningAudio.clip = warningClip;
        bellRingAudio = (gameObject.AddComponent<AudioSource>() as AudioSource);
        bellRingAudio.clip = bellRingClip;
    }

    void Update()
    {
        if (timeLeft > 0f) {
            Countdown();
        } else {
            Debug.Log("Game Over");
        }
    }

    private void Countdown()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0.0f)
        {
            bellRingAudio.Play();
            warningAudio.Stop();
            countdownText.text = "";
            // do something
        }
        else if (timeLeft <= criticalTimeTreshold)
        {
            if (!isTimeCritical)
            {
                warningAudio.Play();
                countdownText.color = Color.red;
                StartCoroutine(CriticalTextFlash());
            }
        }
        else countdownText.text = "Time Left: " + System.Math.Round(timeLeft).ToString();
    }

    private IEnumerator CriticalTextFlash()
    {
        isTimeCritical = true;
        for (int i = 0; i < criticalTimeTreshold; i++)
        {
            countdownText.text = "";
            yield return new WaitForSeconds(0.5f);
            countdownText.text = "Time Left: " + System.Math.Round(timeLeft).ToString();
            yield return new WaitForSeconds(0.5f);
        }
    }
}
