using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBase : EquipItemBase, IPickUpObj
{
    public float DistAttack { get; set; }

    public int DamageWeapon { get; set; }

    public override void Action()
    {
        
    }

    public void PickUpItem(EquipItemBase item)
    {
        InventoryManager.Instance.items.Add(item);
    }
}
