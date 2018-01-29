using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour {
    private float distanceFromScreen = 20;
    /**
    private void OnMouseDrag()
    {
        if(GameObject.FindGameObjectWithTag("LightBall") == null)
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanceFromScreen);
            Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            this.transform.position = objectPosition;
        }
        
    }
    **/
    Vector3 localHeldPosition;
    bool held;

    void OnMouseDrag()
    {
        if (GameObject.FindGameObjectWithTag("LightBall") == null)
        {
            // get mouse position
            Vector2 screenMousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            //convert to world space (on z=0 plane)
            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(screenMousePosition);
            worldMousePosition.z = distanceFromScreen; //this is to make sure the position stays on the z=0 plane

            //if weren't holding last frame, remember where we grabbed it in local space
            if (!held)
            {
                localHeldPosition = transform.InverseTransformPoint(worldMousePosition);
                held = true;
            }

            //calculate the current position of the grabbed point in world space
            Vector3 worldHeldPosition = transform.TransformPoint(localHeldPosition);

            //calculate the 'error' - i.e. how much we need to move that point to fix things
            Vector3 worldDelta = worldMousePosition - worldHeldPosition;

            //fix it just by moving out object
            transform.position += worldDelta;
            held = true;
        }

            
    }

    void OnMouseUp()
    {
        held = false;
    }

}
