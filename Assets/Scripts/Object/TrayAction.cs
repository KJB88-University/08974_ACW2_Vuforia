using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrayAction : VCustomAction
{
    [SerializeField]
    Transform cursorTransf;

    Vector3 newdefaultPosition;

    private void Start()
    {
        newdefaultPosition = transform.position;
    }

    void Update()
    {
        if (WorldManager.Instance.gameState == GameState.PLACE_TRAY)
        {
            if (GazeManager.Instance.firstHit.collider != null)
            {
                transform.position = GazeManager.Instance.firstHit.point;
            }
            else
            {
                transform.position = newdefaultPosition;
            }
        }
    }

    public override void CustomAction()
    {
        // Do nothing
    }
}
