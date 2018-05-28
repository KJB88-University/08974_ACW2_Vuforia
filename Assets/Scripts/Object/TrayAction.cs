using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrayAction : VCustomAction
{
    [SerializeField]
    Transform cursorTransf;

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
                transform.position = cursorTransf.position;
            }
        }
    }

    public override void CustomAction()
    {
        // Do nothing
    }
}
