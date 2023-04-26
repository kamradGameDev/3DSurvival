using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class QuestBaseTasks : ScriptableObject
{
    public int countActionsTask { get; protected set; }
    public abstract void Init();
    public abstract bool CheckStatus();
    public abstract void CheckStatusUI();
}
