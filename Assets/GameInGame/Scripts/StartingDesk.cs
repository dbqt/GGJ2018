using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingDesk : MonoBehaviour {

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Disk>().RefillHp();
        }
    }
}
