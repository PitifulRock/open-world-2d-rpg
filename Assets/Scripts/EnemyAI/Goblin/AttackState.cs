using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : GoblinStates
{
    public override GoblinStates RunCurrentState()
    {
        return this;
    }
}
