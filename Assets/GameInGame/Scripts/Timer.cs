using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float timeLeft = 30.0f;
    public Text countdownText;
    public float criticalTimeTreshold;
    private bool isTimeCritical;

    private void Start()
    {
        isTimeCritical = false;
        countdownText.text = "Time Left: " + System.Math.Round(timeLeft).ToString();
    }

    void Update()
    {
        if (timeLeft > 0f) {
            Countdown();
        } else {
            // Game over cut scene.
        }


    }

    private void Countdown()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            countdownText.text = "";
            // do something
        }
        else if (timeLeft <= criticalTimeTreshold)
        {
            if (!isTimeCritical)
            {
                countdownText.color = Color.red;
                StartCoroutine(CriticalTime());
            }
        }
        else countdownText.text = "Time Left: " + System.Math.Round(timeLeft).ToString();
    }

    private IEnumerator CriticalTime()
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
