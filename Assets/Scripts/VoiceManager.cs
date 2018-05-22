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

            case ""
        }
    }

    void CheckObjectNull()
    {

    }
}
