using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class GestureManager : MonoBehaviour
{
    GestureRecognizer recognizer;

    Material debug;

    GameObject heldObject;

    // Use this for initialization
    void Start()
    {
        recognizer = new GestureRecognizer();
        recognizer.SetRecognizableGestures(GestureSettings.Tap);
        //recognizer.SetRecognizableGestures(GestureSettings.Hold);

        recognizer.Tapped += GestureRecognizer_Tapped;

        StartGestures();
    }

    void GestureRecognizer_Tapped(TappedEventArgs args)
    {
        if (WorldManager.Instance.gameState == GameState.PLACE_TRAY)
        {
            WorldManager.Instance.StartGame();
        }
        else if (WorldManager.Instance.gameState == GameState.MAKE_TEA)
        {
            if (GazeManager.Instance.DidGazeHit())
            {
                if (GazeManager.Instance.GetHitObject() != null)
                {
                    GameObject focusedObject = GazeManager.Instance.GetHitObject();
                    focusedObject.SendMessage("CustomAction", null, SendMessageOptions.DontRequireReceiver);
                    //focusedObject.GetComponent<Renderer>().material = debug;
                }
            }
        }
    }

    void StopGestures()
    {
        recognizer.CancelGestures();
    }

    void StartGestures()
    {
        recognizer.StartCapturingGestures();
    }
}
