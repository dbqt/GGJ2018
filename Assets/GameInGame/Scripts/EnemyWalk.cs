using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk : MonoBehaviour {

    public float enemyspeed;
    public bool isBlocked;
    public bool isLeaving;
    public Vector3 direction;

    private void Start()
    {
        int startDir = Random.Range(0, 3);
        switch (startDir)
        {
            case 0:
                // UP
                direction = Vector3.forward;
                break;
            case 1:
                // DOWN
                this.transform.Rotate(Vector3.up * 180, Space.World);
                direction = Vector3.back;
                break;
            case 2:
                // RIGHT
                this.transform.Rotate(Vector3.up * 90, Space.World);
                direction = Vector3.right;
                break;
            case 3:
                // LEFT
                this.transform.Rotate(-Vector3.up * 90, Space.World);
                direction = Vector3.left;
                break;
        }

        isBlocked = false;
        isLeaving = false;
    }

    private void Update()
    {
        this.transform.Translate(direction * enemyspeed * Time.deltaTime, Space.World);
        
        if (isBlocked)
        {

            int nextDir = Random.Range(0, 2);
            switch (nextDir)
            {
                case 0:
                    // RIGHT
                    this.transform.Rotate(Vector3.up * 90, Space.World);
                    turnRight();
                    break;
                case 1:
                    // LEFT
                    this.transform.Rotate(-Vector3.up * 90, Space.World);
                    turnLeft();
                    break;
                case 2:
                    // OPPOSITE
                    this.transform.Rotate(Vector3.up * 180, Space.World);
                    direction = -direction;
                    break;
            }
        }
    }

    private void turnRight()
    {
        if (direction == Vector3.forward)
        {
            direction = Vector3.right;
        }
        else if (direction == Vector3.right)
        {
            direction = Vector3.back;
        }
        else if (direction == Vector3.back)
        {
            direction = Vector3.left;
        }
        else
        {
            direction = Vector3.forward;
        }
    }

    private void turnLeft()
    {
        if (direction == Vector3.forward)
        {
            direction = Vector3.left;
        }
        else if (direction == Vector3.left)
        {
            direction = Vector3.back;
        }
        else if (direction == Vector3.back)
        {
            direction = Vector3.right;
        }
        else
        {
            direction = Vector3.forward;
        }
    }
}
