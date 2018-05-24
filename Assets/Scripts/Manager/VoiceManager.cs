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
            case "Reset World":
                WorldManager.Instance.ResetWorld();
                break;

            case "Select Object":
                // TODO - General step forward
                break;

            case "Add Water":
                // TODO - Add Water to Kettle only
                break;

            case "Boil Kettle":
                // TODO - Boil the kettle only
                break;

            case "Add Tea Bag":
                // TODO - Add a tea bag to the cup only
                break;

            case "Add Sugar":
                // TODO - Add sugar to the cup only
                break;

            case "Add Milk":
                // TODO - Add milk to the cup only
                break;

            case "Add Hot Water":
                // TODO - Add hot water to the cup only
                break;

            case "Remove Tea Bag":
                // TODO - Remove the tea bag from the cup
                break;

            case "Mix Tea":
                // TODO - Stir the tea with the spoon
                break;

            default:
                // N/A
                break;
        }
    }

    void CheckObjectNull()
    {

    }
}
