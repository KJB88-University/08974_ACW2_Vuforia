using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeManager : Singleton<GazeManager>
{
    bool objectHit = false;
    RaycastHit hitInfo;

    public float maxDistance;

    GameObject focusedObject;
    GameObject oldFocusedObject;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Update objects for this frame
        oldFocusedObject = focusedObject;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hitInfo, maxDistance, Physics.DefaultRaycastLayers))
        {
            // If we hit a game object
            if (hitInfo.collider != null)
            {
                // Set our bool to true
                objectHit = true;

                // Update focusedObject with the hit object
                focusedObject = hitInfo.collider.gameObject;

            }
            // If our gaze is not on an object
            else
            {
                // Set our bool to false
                objectHit = false;
                // Revert our focusedObject to null
                if (focusedObject != null)
                {
                    focusedObject = null;
                }
            }
        }

        // If this is a different object,
        if (focusedObject != oldFocusedObject)
        {
            // Send message to old object that we're not looking at it
            ResetOldFocus();

            // If the new object is not null,
            if (focusedObject != null)
            {
                // And it has the correct component,
                if (focusedObject.GetComponent<ObjectAction>() != null)
                {
                    // Send message to object that we're looking at it
                    focusedObject.SendMessage("OnGazeEnter");
                }
            }
        }
    }

    void ResetOldFocus()
    {
        if (oldFocusedObject != null)
        {
            if (oldFocusedObject.GetComponent<ObjectAction>() != null)
            {
                oldFocusedObject.SendMessage("OnGazeExit");
            }
        }
    }
    /// <summary>
    /// Check if gaze is currently hitting
    /// </summary>
    /// <returns>Boolean representing hit state</returns>
    public bool DidGazeHit()
    {
        return objectHit;
    }

    /// <summary>
    /// Return HitInfo
    /// </summary>
    /// <returns>HitInfo</returns>
    public RaycastHit GetHitInfo()
    {
        return hitInfo;
    }

    /// <summary>
    /// Return the hit object
    /// </summary>
    /// <returns>Hit object</returns>
    public GameObject GetHitObject()
    {
        if (objectHit)
        {
            return hitInfo.collider.gameObject;
        }
        else
        {
            return null;
        }
    }
}
