using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataItemsManager : MonoBehaviour
{
    public static DataItemsManager Instance { get; private set; }
    private void Awake()
    {
        if (!Instance)
            Instance = this;
    }
}
