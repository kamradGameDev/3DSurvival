using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WeaponLibrary : MonoBehaviour
{
    public static WeaponLibrary Instance { get; private set; }
    public List<WeaponBase> weapons;
    private void Awake()
    {
        if (!Instance) Instance = this;
    }
}
