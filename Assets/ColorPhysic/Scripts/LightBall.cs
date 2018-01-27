using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBall : MonoBehaviour {
    public GameObject newLightBall;
    private float distanceFromScreen = 20;
    private static bool hasInstantiated = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
        if(collision.gameObject.tag == "LightBall")
        {
            Debug.Log("spawn new light");
            ContactPoint contactPoint = collision.contacts[0];
            Vector3 contactPosition = contactPoint.point;
            Vector3 NewLightBallSpawnPoint = new Vector3(contactPosition.x, contactPosition.y, this.transform.position.z);
            Destroy(gameObject);
            if (!hasInstantiated)
            {
                GameObject go = (GameObject)Instantiate(newLightBall, NewLightBallSpawnPoint, Quaternion.identity);
               
                hasInstantiated = true;
                go.GetComponent<Renderer>().material.color = Color.yellow;
                go.GetComponent<Renderer>().material.set = Color.yellow;
            }
            else
            {
                hasInstantiated = false;
            }
            

        }
        
    }
}
