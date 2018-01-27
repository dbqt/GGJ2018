using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    public float playerSpeed;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        move();
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    transform.Translate(new Vector3(0.0f, 0.0f, 1.0f) * speed * Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.Translate(new Vector3(0.0f, 0.0f, -1.0f) * speed * Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Translate(new Vector3(1.0f, 0.0f, 0.0f) * speed * Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Translate(new Vector3(-1.0f, 0.0f, 0.0f) * speed * Time.deltaTime);
        //}
    }

    private void move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(x, 0f, z);

        this.transform.LookAt(this.transform.position + direction);
        this.transform.Translate(direction * playerSpeed, Space.World);
    }
}
