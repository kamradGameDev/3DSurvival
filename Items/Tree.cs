using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : ResourceObjectBase, IInteractObj, IHealth
{
    [SerializeField] private float health;
    public float Health { get { return health; } private set { health = value; } }

    [SerializeField] private float maxHealth = 100f;
    public float MaxHealth { get { return maxHealth; } }

    protected override void Start()
    {
        nameObj = GetTypeObj();
    }
    public string GetNameAndStatus()
    {
        float percent = (Health / MaxHealth) * 100f;

        string status = nameObj + ": " + percent + "%";

        return status;
    }

    public void Interact()
    {
        //if (t is AxeItem)
        //{
        //    Debug.Log("Рубим дерево");
        //    Health -= float.Parse(e.ToString());
        //}
    }

    protected override string GetTypeObj()
    {
        return GetType().ToString();
    }

    public IHealth GetHealth()
    {
        return this;    
    }

    public void Damage<T>(T t, float damage)
    {
        if(t is AxeItem)
        {
            Debug.Log("Рубим дерево");
            Health -= damage;
        }
    }
}
