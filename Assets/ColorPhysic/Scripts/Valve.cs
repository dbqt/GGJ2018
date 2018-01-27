using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valve : MonoBehaviour {
    public GameObject LightBallSpawnPoint;
    public GameObject LightBall;
    public Color valveColor;

	// Use this for initialization
	void Start () {
        this.GetComponent<Renderer>().material.color = valveColor;
        this.GetComponent<Renderer>().material.SetColor("_EmissionColor", valveColor);
    }

    private void OnMouseUp()
    {
        GameObject go = (GameObject)Instantiate(LightBall, LightBallSpawnPoint.transform.position, LightBallSpawnPoint.transform.rotation);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().material.color = valveColor;
        other.gameObject.GetComponent<Renderer>().material.SetColor("_EmissionColor", valveColor);
    }
}
