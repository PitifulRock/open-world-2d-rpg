using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinStateManager : MonoBehaviour
{
    GoblinStates currentState;

    void Update()
    {
        RunStateMachine();
    }

    private void RunStateMachine()
    {
        GoblinStates nextState = currentState?.RunCurrentState();

        if(nextState != null)
        {
            SwitchToNextState(nextState);
        }
    }

    private void SwitchToNextState(GoblinStates nextState)
    {
        currentState = nextState;
    }
}
