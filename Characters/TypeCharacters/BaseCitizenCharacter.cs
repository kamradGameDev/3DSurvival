using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCitizenCharacter : MonoBehaviour
{
    protected IMovable movable;
    protected ITradable tradable;
    protected ISpeakable speakable;

    protected abstract void InitBehaviours();
}
