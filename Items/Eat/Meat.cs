using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Items/New meat")]
public class Meat : ItemBase, IEat, IHealth
{
    [SerializeField] private int satiationOfHunger = 5;

    public void Damage<T>(T t, float damage)
    {
        
    }

    public IHealth GetHealth()
    {
        return this;
    }

    public string GetNameAndStatus()
    {
        return name;
    }

    public void PickUpItem(EquipItemBase item)
    {
        InventoryManager.Instance.items.Add(item);
    }
    public void UseItem()
    {
        Debug.Log("Уровень сытости восстановлен: " + satiationOfHunger);
    }
}
