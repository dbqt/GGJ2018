using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionDetection : MonoBehaviour {

    private Animator animator;

    void Start () {
        animator = GetComponent<Animator>();
	}

	void Update () {
        // Debouncer to avoid sprite to flip when the joystick is flicked
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.2 || Mathf.Abs(Input.GetAxis("Vertical")) > 0.2)
        {
            animator.SetFloat("xInput", Input.GetAxis("Horizontal"));
            animator.SetFloat("zInput", Input.GetAxis("Vertical"));
        }
    }
}
