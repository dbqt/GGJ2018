using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalBehavior : MonoBehaviour {

    [SerializeField]
    private bool colorLock; // flag prevents color change
    public Color color;
            
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
            if (collision.gameObject.GetComponent<Renderer>().material.color == this.GetComponent<Renderer>().material.color)
            {
                Debug.Log("correct color");
                this.GetComponent<Renderer>().material.SetColor("_EmissionColor", color * 2);
                if (!colorLock)
                {
                    colorLock = true;
                    dropGM.instance.terminalCounter++;
                    //STAYS THE same color once correct ball hits
                }
            }
        }
    }

}
