using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : GoblinStates
{
    public override GoblinStates RunCurrentState()
    {
        return this;
    }
}
