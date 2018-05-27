using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorFollow : MonoBehaviour
{
    Vector3 defaultPosition;

	// Use this for initialization
	void Start ()
    {
        defaultPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GazeManager.Instance != null)
        {
            if (GazeManager.Instance.DidGazeHit())
            {
                transform.position = GazeManager.Instance.GetHitInfo().point;
            }
        }
	}
}
