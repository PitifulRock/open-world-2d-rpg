using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : GoblinStates
{
    public ChaseState chaseState;
    public bool canSeePlayer;

    public override GoblinStates RunCurrentState()
    {
        if (canSeePlayer)
        {
            return chaseState;
        }
        else
        {
            return this;
        }
    }
}
