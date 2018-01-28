using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float timeLeft = 30.0f;
    public Text countdownText;

    private void Start()
    {
        countdownText.text = System.Math.Round(timeLeft).ToString();
    }

    void Update()
    {
        Countdown();
    }

    private void Countdown()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            countdownText.text = "";
            // do something
        }
        else countdownText.text = System.Math.Round(timeLeft).ToString();
    }
}
