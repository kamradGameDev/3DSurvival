using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface ITargetQuestObj
{
    public void OnClickQuest();
    public Transform GetTransform();
    public int GetIdObj();
    void OnEnable();
    void OnDisable();
}
