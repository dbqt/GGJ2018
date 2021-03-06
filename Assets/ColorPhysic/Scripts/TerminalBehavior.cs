﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalBehavior : MonoBehaviour {

    [SerializeField]
    private bool colorLock; // flag prevents color change
    public Color color;
    public AudioSource bing;
            
    void Start()
    {
        colorLock = false;
        this.GetComponent<Renderer>().material.color = color;
        this.GetComponent<Renderer>().material.SetColor("_EmissionColor", color/2);
    }

	void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "LightBall")
        {
            Destroy(collision.gameObject);

            Debug.Log("collision terminal");
            Debug.Log("terminal color: " + this.color);
            Debug.Log("terminal material color: " + this.GetComponent<Renderer>().material.color);
            Debug.Log("light ball color: " + collision.gameObject.GetComponent<Renderer>().material.color);

            if (collision.gameObject.GetComponent<Renderer>().material.color.Equals(this.GetComponent<Renderer>().material.color))
            {
                Debug.Log("correct color");
                bing.Play();
                this.GetComponent<Renderer>().material.SetColor("_EmissionColor", color * 2);
                if (!colorLock)
                {
                    colorLock = true;
                    dropGM.instance.incrementCount();
                    //STAYS THE same color once correct ball hits
                }
            }
        }
    }

}
