using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalBehavior : MonoBehaviour {

    [SerializeField]
    private bool colorLock; // flag prevents color change
            
    void Start()
    {
        colorLock = false;
    }

	void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "LightBall")
        {

            if (collision.gameObject.GetComponent<Renderer>().material.color == this.GetComponent<Renderer>().material.color)
            {
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
