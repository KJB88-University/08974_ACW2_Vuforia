using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugDrag : MonoBehaviour
{
    bool dragging = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            dragging = !dragging;
        }

        if (dragging)
        {
            if (GazeManager.Instance.DidGazeHit())
            {
                if (GazeManager.Instance.GetHitObject() != null)
                {
                    GameObject focusedObject = GazeManager.Instance.GetHitObject();
                    focusedObject.SendMessage("OnHoldStart", null, SendMessageOptions.DontRequireReceiver);
                }
            }
            else
            {
                GameObject focusedObject = GazeManager.Instance.GetHitObject();
                focusedObject.SendMessage("OnHoldStart", null, SendMessageOptions.DontRequireReceiver);
            }
        }
    }
}
