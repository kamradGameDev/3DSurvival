using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AYellowpaper;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance { get; private set; }

    [RequireInterface(typeof(IPickUpObj))]
    public List<Object> items;

    private void Awake()
    {
        if (!Instance)
            Instance = this;
    }
}
