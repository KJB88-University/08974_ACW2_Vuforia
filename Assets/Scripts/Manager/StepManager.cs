using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepManager : MonoBehaviour
{
    [Serializable]
    public struct InteractionObjects
    {
        public GameObject first;
        public GameObject second;
    }

    [SerializeField]
    InteractionObjects[] steps;

    int currentStep = 0;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void NextStep()
    {
        if (currentStep < steps.Length)
        {
            currentStep++;
        }

    }

    void ResetSteps()
    {
        currentStep = 0;
    }
}
