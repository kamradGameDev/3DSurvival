using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ResourceObjectBase : MonoBehaviour
{
    protected string nameObj;
    protected abstract void Start();
    protected abstract string GetTypeObj();
}
