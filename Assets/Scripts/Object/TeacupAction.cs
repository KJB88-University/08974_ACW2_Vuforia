﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacupAction : VCustomAction
{
    public override void CustomAction()
    {
        if (StepManager.Instance.CheckStep(this.gameObject, this.gameObject))
        {
            StepManager.Instance.NextStep();
        }
    }
}
