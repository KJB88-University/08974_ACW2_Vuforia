using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    [SerializeField]
    GameObject cursor;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GazeManager.Instance != null)
        {
            if (WorldManager.Instance.gameState == GameState.MAKE_TEA)
            {
                if (GazeManager.Instance.DidGazeHit())
                {
                    cursor.SetActive(true);
                    cursor.transform.position = GazeManager.Instance.GetHitInfo().point;
                }
                else
                {
                    cursor.SetActive(false);
                }
            }
            else if (WorldManager.Instance.gameState == GameState.PLACE_TRAY)
            {
                if (GazeManager.Instance.firstHit.collider != null)
                {
                    cursor.SetActive(true);
                    cursor.transform.position = GazeManager.Instance.firstHit.point;
                }
                else
                {
                    cursor.SetActive(false);
                }
            }
        }
    }
}
