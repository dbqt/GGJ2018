using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valve : MonoBehaviour {
    public GameObject LightBallSpawnPoint;
    public GameObject LightBall;
    public Color valveColor;
    private Color color;
    private float cooldownTime = 3f;
    private float lastBallSpawn = 0f;

	// Use this for initialization
	void Start () {
        this.GetComponent<Renderer>().material.color = valveColor;
        this.GetComponent<Renderer>().material.SetColor("_EmissionColor", valveColor);
    }

    private void OnMouseDown()
    {
        this.GetComponent<Renderer>().material.SetColor("_EmissionColor", valveColor * 2);
    }

    private void OnMouseUp()
    {
        this.GetComponent<Renderer>().material.SetColor("_EmissionColor", valveColor);
        if (Time.time > lastBallSpawn + cooldownTime)
        {
            GameObject go = (GameObject)Instantiate(LightBall, LightBallSpawnPoint.transform.position, LightBallSpawnPoint.transform.rotation);
            lastBallSpawn = Time.time;
            
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().material.color = valveColor;
        other.gameObject.GetComponent<Renderer>().material.SetColor("_EmissionColor", valveColor);
    }
}
