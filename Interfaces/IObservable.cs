using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObservable<T>
{
    event Action<T> OnChanged;
}
