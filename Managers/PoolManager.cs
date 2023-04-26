using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public static PoolManager Instance { get; private set; }
    private void Awake()
    {
        if (!Instance)
            Instance = this;
    }
}
