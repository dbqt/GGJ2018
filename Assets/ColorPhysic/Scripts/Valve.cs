using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valve : MonoBehaviour {
    public GameObject LightBallSpawnPoint;
    public GameObject LightBall;

	// Use this for initialization
	void Start () {
		
	}

    private void OnMouseUp()
    {
        GameObject go = (GameObject)Instantiate(LightBall, LightBallSpawnPoint.transform.position, LightBallSpawnPoint.transform.rotation);

    }
}
