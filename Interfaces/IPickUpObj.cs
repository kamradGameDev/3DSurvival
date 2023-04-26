using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AYellowpaper;
using System;

public interface IInteractObj
{
    void Interact();
    string GetNameAndStatus();
    IHealth GetHealth();
}

public interface IPickUpObj
{
    void UseItem();
    void PickUpItem(EquipItemBase item);
}
