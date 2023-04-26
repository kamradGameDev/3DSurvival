using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public enum TypeWindow
{
    inventoryWindow = 0, 
    characterWindow = 1
}

public abstract class WindowBase : MonoBehaviour
{

    protected virtual void Start()
    {
        UIEvents.EventNewStatusWindow += CheckStatusWindow;

    }

    protected virtual void CheckStatusWindow(TypeWindow typeWindow, bool newStatus)
    {
        if (newStatus)
            transform.DOScale(Vector3.one, 0.5f);
        else
            transform.DOScale(Vector3.zero, 0.5f);

        //statusOpen = InvertBool(ref statusOpen);
    }
    //private bool InvertBool(this ref bool b) => b = !b;
}
