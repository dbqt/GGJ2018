using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSlow : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerController>().playerSpeed = collision.gameObject.GetComponent<PlayerController>().decreasedSpeed;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerController>().playerSpeed = collision.gameObject.GetComponent<PlayerController>().defaultPlayerSpeed;
        }
    }
}
