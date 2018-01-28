using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerSound : MonoBehaviour {

	public AudioSource audio;

	void OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.tag == "Player") {
			audio.Play ();
			Debug.Log ("cooooooooool");
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
