using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugClick : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (WorldManager.Instance.gameState == GameState.MAKE_TEA)
            {
                if (GazeManager.Instance.DidGazeHit())
                {
                    if (GazeManager.Instance.GetHitObject() != null)
                    {
                        GameObject focusedObject = GazeManager.Instance.GetHitObject();
                        focusedObject.SendMessage("CustomAction", null, SendMessageOptions.DontRequireReceiver);
                    }
                }
            }
            else if (WorldManager.Instance.gameState == GameState.PLACE_TRAY)
            {
                WorldManager.Instance.StartGame();
            }
        }
    }
}
