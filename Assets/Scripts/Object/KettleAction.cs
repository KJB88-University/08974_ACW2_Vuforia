using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KettleAction : VCustomAction
{
    bool secondStep = false;

    [SerializeField]
    AudioClip secondAudio;

    public override void CustomAction()
    {
        if (!secondStep)
        {
            if (StepManager.Instance.CheckStep(this.gameObject, this.gameObject))
            {
                FirstStep();
                StepManager.Instance.NextStep();
            }
        }
        else
        {
            if (StepManager.Instance.CheckStep(this.gameObject, objectToMoveTo))
            {
                SecondStep();
                StepManager.Instance.NextStep();
            }
        }
    }
    void FirstStep()
    {
        base.PlaySound();
        secondStep = true;
    }

    void SecondStep()
    {
        transform.position = new Vector3(objectToMoveTo.transform.position.x, objectToMoveTo.transform.position.y + base.yOffset, objectToMoveTo.transform.position.z);
        base.PlayAnimation();
        PlaySecondAudio();
    }

    void PlaySecondAudio()
    {
        GetComponent<AudioSource>().clip = secondAudio;
        GetComponent<AudioSource>().Play();
    }
}
