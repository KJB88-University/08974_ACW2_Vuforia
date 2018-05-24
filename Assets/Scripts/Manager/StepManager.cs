using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepManager : MonoBehaviour
{
    /*
    [SerializeField]
    GameObject[] firstObjects;

    [SerializeField]
    GameObject[] secondObjects;
    */

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
        currentStep++;
    }

    void ResetSteps()
    {
        currentStep = 0;
    }
}
