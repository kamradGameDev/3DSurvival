using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System;

public class DataBaseManager : MonoBehaviour
{
    public static DataBaseManager Instance { get; set; }

    public List<WeaponBase> weapons = new List<WeaponBase>();

    private void Awake()
    {
        if(!Instance)
            Instance = this;
    }
}
