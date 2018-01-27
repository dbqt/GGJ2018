using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBreak : MonoBehaviour {

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Disk>().LoseHp();
        }
    }
}
