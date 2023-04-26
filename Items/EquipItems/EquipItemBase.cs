using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EquipItemBase : ItemBase
{
    public string NameItem { get; set; }

    [SerializeField] protected AbilityBase abilityItem;

    public Sprite Icon { get; set; }

    public Vector3 angles { get; set; }
    public Vector3 localPos { get; set; }

    public Mesh Mesh { get; set; }

    public abstract void Action();

    public void UseItem()
    {
        
    }
    public void PickUpItem()
    {
        Debug.Log("Подобрали предмет");
        MainEventBus.EquipItemPlayerItem(this);
    }

    public string GetNameAndStatus() => ToString();
}
