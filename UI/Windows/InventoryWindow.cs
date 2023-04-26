using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryWindow : WindowBase
{
    [SerializeField] private InvenSlotItem[] invenSlotItems;
    protected override void Start()
    {
        base.Start();
        UIEvents.EventNewStatusWindow += CheckStatusWindow;
        MainEventBus.PickUpItemEvent += AddNewItem;
    }

    protected override void CheckStatusWindow(TypeWindow typeWindow, bool newStatus)
    {
        base.CheckStatusWindow(typeWindow, newStatus);
        if(newStatus)
        {
            Debug.Log("load inventory items");
        }
    }

    private void AddNewItem(EquipItemBase equipItem)
    {
        for(var i = 0; i < invenSlotItems.Length; i++)
        {
            if(invenSlotItems[i].AddItem(equipItem))
            {
                Debug.Log("Добавлен новый предмет");
                return;
            }
        }

        Debug.Log("Нет свободный слотов.");
    }
}
