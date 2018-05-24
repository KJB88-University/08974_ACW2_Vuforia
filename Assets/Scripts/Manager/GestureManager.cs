using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class GestureManager : MonoBehaviour
{
    GestureRecognizer recognizer;

    // Use this for initialization
    void Start()
    {
        recognizer = new GestureRecognizer();
        recognizer.SetRecognizableGestures(GestureSettings.Tap);
        recognizer.Tapped += GestureRecognizer_Tapped;
        StartGestures();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GestureRecognizer_Tapped(TappedEventArgs args)
    {
        // TODO - Object functionality if tapped
        if (GazeManager.Instance.DidGazeHit())
        {
            if (GazeManager.Instance.GetHitObject() != null)
            {
                GameObject focusedObject = GazeManager.Instance.GetHitObject();
                focusedObject.SendMessage("GestureAction", null, SendMessageOptions.DontRequireReceiver);
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

    void OnTapped(TappedEventArgs args)
    {

    }
}
