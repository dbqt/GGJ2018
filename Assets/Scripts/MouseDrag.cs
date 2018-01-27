﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour {
    public float distanceFromScreen = 10;

    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanceFromScreen);
        Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        this.transform.position = objectPosition;
    }
}
