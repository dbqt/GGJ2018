using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    public float playerSpeed;

    private void Update()
    {
        move();
    }

    private void move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        Vector3 direction;

        if (Mathf.Abs(x) > Mathf.Abs(z))
        {
            direction = new Vector3(x, 0.0f, 0.0f);
        }

        else
        {
            direction = new Vector3(0.0f, 0f, z);
        }
        
        this.transform.Translate(direction * playerSpeed, Space.World);
    }
}
