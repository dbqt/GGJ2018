using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFLash : MonoBehaviour {
    private Color noAlphaWhite;
    private Color white;
    private float lastExecution = 0f;
	// Use this for initialization
	void Start () {
        noAlphaWhite = Color.white;
        noAlphaWhite.a = 0;
        white = Color.white;
       
	}
	
	// Update is called once per frame
	void Update () {
        if(Time.time > lastExecution + 1)
        {
            lastExecution = Time.time;
            StartCoroutine(flashText());
        }
    }

    IEnumerator flashText()
    {
        Debug.Log("off");
        this.GetComponent<Text>().color = noAlphaWhite;
        yield return new WaitForSeconds(0.5f);
        Debug.Log("on");
        this.GetComponent<Text>().color = white;
        yield return new WaitForSeconds(0.5f);
        Debug.Log("done");
    }
}
