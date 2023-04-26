using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "Data/Items/New Water")]
public class WaterEat : ItemBase, IEat, IHealth
{
    public void Damage<T>(T t, float damage)
    {
        
    }

    public IHealth GetHealth()
    {
        return this;
    }

    public string GetNameAndStatus()
    {
        return ToString();
    }

    public void PickUpItem(EquipItemBase item)
    {
        InventoryManager.Instance.items.Add(item);
    }

    public void UseItem()
    {
        
    }
}

