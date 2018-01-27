using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    public float timeLeft = 30.0f;

    void Update()
    {
        Countdown();
    }

    private void Countdown()
    {
        timeLeft -= Time.deltaTime;
        Debug.Log(timeLeft);
        if (timeLeft < 0)
        {
            // do something
        }
    }
}
