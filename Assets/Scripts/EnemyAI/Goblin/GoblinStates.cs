using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GoblinStates : MonoBehaviour
{
    public abstract GoblinStates RunCurrentState();
}
