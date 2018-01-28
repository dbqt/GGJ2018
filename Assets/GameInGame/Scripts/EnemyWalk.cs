using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk : MonoBehaviour {

    public float enemyspeed;
    public bool isBlocked;
    public bool isLeaving;
    private Vector3 direction;
    private Rigidbody rb;


    private void Start()
    {
        direction = new Vector3(0.0f, 0.0f, 1.0f);
        isBlocked = false;
        isLeaving = false;
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        this.transform.Translate(direction * enemyspeed * Time.deltaTime, Space.World);

        if (isBlocked && !isLeaving)
        {
            isLeaving = true;

            int nextDir = Random.Range(0, 3);
            switch (nextDir)
            {
                case 0:
                    // UP
                    direction = new Vector3(0.0f, 0.0f, 1.0f);
                    break;
                case 1:
                    // DOWN
                    direction = new Vector3(0.0f, 0.0f, -1.0f);
                    break;
                case 2:
                    // RIGHT
                    direction = new Vector3(1.0f, 0.0f, 0.0f);
                    break;
                case 3:
                    // LEFT
                    direction = new Vector3(-1.0f, 0.0f, 0.0f);
                    break;
            }
        }
    }
}
