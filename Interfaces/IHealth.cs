using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealth
{ 
    public virtual float Health { get { return Health; } }
    public virtual float MaxHealth { get { return MaxHealth; } }
    public void Damage<T>(T type, float damage);
}
