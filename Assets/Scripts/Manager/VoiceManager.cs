using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class VoiceManager : MonoBehaviour
{
    [SerializeField]
    string[] keywords;

    private KeywordRecognizer recognizer;

	// Use this for initialization
	void Start ()
    {
        recognizer = new KeywordRecognizer(keywords);
        recognizer.OnPhraseRecognized += OnPhraseRecognized;
        recognizer.Start();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {

        switch(args.text)
        {
            case "Select Object":
                if (GazeManager.Instance.DidGazeHit())
                {
                    GazeManager.Instance.GetHitObject().SendMessage("CustomAction", null, SendMessageOptions.DontRequireReceiver);
                }
                break;

            case "Add Water Bottle":
                // Add Water to Kettle only
                StepManager.Instance.GetFirstObject().SendMessage("CustomAction", null, SendMessageOptions.DontRequireReceiver);
                break;

            case "Switch On Kettle":
                // Boil the kettle only
                StepManager.Instance.GetFirstObject().SendMessage("CustomAction", null, SendMessageOptions.DontRequireReceiver);
                break;

            case "Add Tea Bag":
                // Add a tea bag to the cup only
                StepManager.Instance.GetFirstObject().SendMessage("CustomAction", null, SendMessageOptions.DontRequireReceiver);
                break;

            case "Add Sugar":
                // Add sugar to the cup only
                StepManager.Instance.GetFirstObject().SendMessage("CustomAction", null, SendMessageOptions.DontRequireReceiver);
                break;

            case "Add Milk":
                // Add milk to the cup only
                StepManager.Instance.GetFirstObject().SendMessage("CustomAction", null, SendMessageOptions.DontRequireReceiver);
                break;

            case "Add Hot Water":
                // Add hot water to the cup only
                StepManager.Instance.GetFirstObject().SendMessage("CustomAction", null, SendMessageOptions.DontRequireReceiver);
                break;

            case "Remove Tea Bag":
                // Remove the tea bag from the cup
                StepManager.Instance.GetFirstObject().SendMessage("CustomAction", null, SendMessageOptions.DontRequireReceiver);
                break;

            case "Mix Tea":
                // Stir the tea with the spoon
                StepManager.Instance.GetFirstObject().SendMessage("CustomAction", null, SendMessageOptions.DontRequireReceiver);
                break;

            default:
                // N/A
                break;
        }
    }
}
