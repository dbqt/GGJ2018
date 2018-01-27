using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalBehavior : MonoBehaviour {

    private bool contactFlag; // prevents second contact
            
    void Start()
    {
        contactFlag = false;
    }

	void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "LightBall")
        {

            if (collision.gameObject.GetComponent<Renderer>().material.color == this.GetComponent<Renderer>().material.color)
            {
                if (!contactFlag)
                {
                    contactFlag = false;
                    //inc. in main
                }
            }
            else
            {
            }
        }
    }

}
