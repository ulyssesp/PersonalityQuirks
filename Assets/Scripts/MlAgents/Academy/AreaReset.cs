using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;

public abstract class AreaReset : ScriptableObject
{
    public abstract void Init(PersonalityQuarksArea area);

    public abstract void ResetArea(PersonalityQuarksArea area);
}
