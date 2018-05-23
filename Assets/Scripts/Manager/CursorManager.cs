using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    [SerializeField]
    GameObject cursor;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GazeManager.Instance.DidGazeHit())
        {
            cursor.SetActive(true);
            cursor.transform.position = GazeManager.Instance.GetHitInfo().point;
            Debug.Log("GAZEHIT CURSOR");
        }
        else
        {
            cursor.SetActive(false);
            Debug.Log("NOHIT CURSOR");
        }
	}
}
