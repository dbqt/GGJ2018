using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBall : MonoBehaviour {
    public GameObject newLightBall;
    public GameObject collisionEffect;
    private float distanceFromScreen = 20;
    private static bool hasInstantiated = false;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < -20)
        {
            Destroy(gameObject);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("collision");
        if(collision.gameObject.tag == "LightBall")
        {
            Color color1 = this.GetComponent<Renderer>().material.color;
            Color color2 = collision.gameObject.GetComponent<Renderer>().material.color;
            float r = (color1.r + color2.r) / (2f);
            float g = (color1.g + color2.g) / (2f);
            float b = (color1.b + color2.b) / (2f);

            

            Destroy(gameObject);
            if (!hasInstantiated)
            {
                Debug.Log("spawn new light");
                ContactPoint contactPoint = collision.contacts[0];
                Vector3 contactPosition = contactPoint.point;
                Vector3 NewLightBallSpawnPoint = new Vector3(contactPosition.x, contactPosition.y, this.transform.position.z);
               // LightBall go = new LightBall();
                GameObject go = (GameObject)Instantiate(newLightBall, NewLightBallSpawnPoint, Quaternion.identity);
                GameObject effect = (GameObject)Instantiate(collisionEffect, NewLightBallSpawnPoint, Quaternion.identity);
                hasInstantiated = true;

                //Color newBallColor = (ballColor1 + ballColor1) / 2;
                //Debug.Log("ball1 color: " + ballColor1);
                //Debug.Log("ball2 color: " + ballColor2);
                //Debug.Log("new ball color: " + newBallColor);
                Color newBallColor = new Color(r, g, b, 1.0f);
                go.GetComponent<Renderer>().material.color = newBallColor;
                go.GetComponent<Renderer>().material.SetColor("_EmissionColor", newBallColor * 3);
                //Instantiate(go, NewLightBallSpawnPoint, Quaternion.identity);
            }
            else
            {
                hasInstantiated = false;
            }
            

        }
        
    }

}
