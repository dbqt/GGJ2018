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
        countdownText.text = System.Math.Round(timeLeft).ToString();
        if (timeLeft < 0)
        {
            // do something
        }
    }
}
