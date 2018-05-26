using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugClick : MonoBehaviour
{
    GameObject oldFocusedObject;
    GameObject focusedObject;

    RaycastHit hitInfo;
    bool objectHit;

    float maxDistance = 20f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("LMB pressed");

            // TODO - Object functionality if tapped
            if (GazeManager.Instance.DidGazeHit())
            {
                if (GazeManager.Instance.GetHitObject() != null)
                {
                    GameObject focusedObject = GazeManager.Instance.GetHitObject();
                    focusedObject.SendMessage("GestureAction");
                }
            }
        }
    }
}
