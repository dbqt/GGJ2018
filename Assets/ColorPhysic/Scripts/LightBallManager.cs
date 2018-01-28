using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBallManager : MonoBehaviour {
    public GameObject lightBall;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InstantiateLightBallOnCollision(Vector3 position, Color color)
    {
        GameObject go = (GameObject)Instantiate(lightBall, position, Quaternion.identity);
        go.GetComponent<Renderer>().material.color = color;
        go.GetComponent<Renderer>().material.SetColor("_EmissionColor", color * 3);
    }

    public void instantiateLightBallOnClick(Vector3 position, Color color)
    {
        GameObject go = (GameObject)Instantiate(lightBall, position, Quaternion.identity);
        go.GetComponent<Renderer>().material.color = color;
        go.GetComponent<Renderer>().material.SetColor("_EmissionColor", color);
    }
}
