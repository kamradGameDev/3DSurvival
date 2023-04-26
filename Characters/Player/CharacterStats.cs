using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterStats : ScriptableObject
{
    private int currentHeatlh;
    public int maxHeatlh = 100;

    private void OnEnable()
    {
        currentHeatlh = maxHeatlh;

        MainEventBus.EventCollisionPartPlayerItem += CheckStatusDamage;
    }

    private void OnDisable()
    {
        MainEventBus.EventCollisionPartPlayerItem -= CheckStatusDamage;
    }

    private void CheckStatusDamage(GameObject obj, int damage)
    {
        currentHeatlh -= damage;
        if (currentHeatlh < 0)
            return;
    }
}
