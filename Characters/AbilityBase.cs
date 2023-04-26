using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbilityBase : ScriptableObject
{
    public int exp, expToLevel, level;
    public abstract void Action();
    public void AddExp(int newExp)
    {
        exp += newExp;
        if (exp >= expToLevel)
            level++;

        int diffExp = exp - expToLevel;
        exp = diffExp;
    }
}
