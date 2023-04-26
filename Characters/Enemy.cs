using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class Enemy : CharacterBase, ITargetQuestObj
{
    [SerializeField] private TypeEnemy typeEnemy;
    public TypeEnemy TypeEnemy => typeEnemy;

    public CharacterBase GetCharacter()
    {
        return this;
    }

    public int GetIdObj() => idObj;

    public Transform GetTransform() => transform;

    public void OnClickQuest()
    {

    }

    public void OnDisable()
    {
        DataQuestObjects.instance.targets.Remove(this);
    }

    public void OnEnable()
    {
        Debug.Log(DataQuestObjects.instance);
        DataQuestObjects.instance.targets.Add(this);
    }
}