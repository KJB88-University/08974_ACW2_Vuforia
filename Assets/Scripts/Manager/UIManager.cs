using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    // Instructions for current step
    [SerializeField]
    TextMesh objectiveTextMesh;
    string objectiveText;
    float yOffset;

    // Name Tag of objects
    [SerializeField]
    TextMesh nameTagTextMesh;
    bool nameTagActive = false;

    [SerializeField]
    string[] objectives;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (nameTagTextMesh.gameObject.activeSelf)
        {
            nameTagTextMesh.gameObject.transform.position = GazeManager.Instance.GetHitInfo().point;
        }

        objectiveTextMesh.text = objectives[StepManager.Instance.GetStep()];
	}

    // Update nametag and toggle it on
    public void ToggleNameTag(string nameTagText)
    {
        nameTagTextMesh.text = nameTagText;
        nameTagTextMesh.gameObject.SetActive(!nameTagActive);
    }
}
