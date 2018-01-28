using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCheck : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("WallCheck OnTriggerEnter!");

        if (other.gameObject.tag == "Wall")
        {
            Debug.Log("WallCheck OnTriggerEnter if Wall!");

            GetComponentInParent<EnemyWalk>().isBlocked = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("WallCheck OnTriggerExit!");

        if (other.gameObject.tag == "Wall")
        {
            Debug.Log("WallCheck OnTriggerExit if Wall!");

            GetComponentInParent<EnemyWalk>().isBlocked = false;
            GetComponentInParent<EnemyWalk>().isLeaving = false;
        }
    }
}
