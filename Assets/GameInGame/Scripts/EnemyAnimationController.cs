using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationController : MonoBehaviour
{

    private Animator animator;
    private Vector3 walkDir;
    Quaternion rot;

    private void Awake()
    {
        // Keep a reference of the original rotation
        rot = this.transform.rotation;
    }

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Make the sprite not rotate if his parent is rotating
        this.transform.rotation = rot;

        // Give the animator the information about the direction
        walkDir = GetComponentInParent<EnemyWalk>().direction;
        animator.SetFloat("xInput", walkDir.x);
        animator.SetFloat("zInput", walkDir.z);
    }
}
