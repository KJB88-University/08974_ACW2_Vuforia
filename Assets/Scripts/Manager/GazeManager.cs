using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeManager : Singleton<GazeManager>
{
    bool objectHit = false;
    RaycastHit hitInfo;

    GameObject focusedObject;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hitInfo, 20.0f, Physics.DefaultRaycastLayers))
        {
            // If we hit a game object
            if (hitInfo.collider != null)
            {
                NoGazeHit();
            }
            // If our gaze is not on an object
            else
            {
                GazeHit();
            }
        }
    }

    void NoGazeHit()
    {
        // Set our bool to false
        objectHit = false;
        // Revert our focusedObject to null
        if (focusedObject != null)
        {
            focusedObject = null;
        }
    }

    void GazeHit()
    {
        // Set our bool to true
        objectHit = true;

        // Update focusedObject with the hit object
        focusedObject = hitInfo.collider.gameObject;
    }

    public bool DidGazeHit()
    {
        return objectHit;
    }

    public RaycastHit GetHitInfo()
    {
        return hitInfo;
    }

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
