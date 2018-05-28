using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepManager : Singleton<StepManager>
{
    [Serializable]
    struct InteractionObjects
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

    public int GetStep()
    {
        return currentStep;
    }

    public GameObject GetFirstObject()
    {
        return steps[currentStep].first;
    }

    public bool CheckStep(GameObject first, GameObject second)
    {
        if (steps[currentStep].first == first && steps[currentStep].second == second)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void NextStep()
    {
        if (currentStep < steps.Length)
        {
            currentStep++;
        }
    }
}
