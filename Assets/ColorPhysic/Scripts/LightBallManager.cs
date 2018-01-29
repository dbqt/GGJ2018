using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBallManager : MonoBehaviour {

    public static LightBallManager instance { get; set; }
    public AudioSource fuze;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public GameObject lightBall;
	
    public void InstantiateLightBallOnCollision(Vector3 position, Color color)
    {
        fuze.Play();
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
