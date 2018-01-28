using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float defaultPlayerSpeed;
    public float playerSpeed;
    public float decreasedSpeed;
    private AudioSource footstepsAudio;
    public AudioClip footstepsClip;

    private void Start()
    {
        playerSpeed = defaultPlayerSpeed;
        footstepsAudio = (gameObject.AddComponent<AudioSource>() as AudioSource);
        footstepsAudio.clip = footstepsClip;

        footstepsAudio.loop = true;
        footstepsAudio.Play();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
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

        if (!(this.IsMoving()))
            footstepsAudio.mute = false;
        else footstepsAudio.mute = true;
    }

    private bool IsMoving()
    {
        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
            return true;
        else return false;
    }
}
