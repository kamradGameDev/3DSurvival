using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetEnumWindow : MonoBehaviour
{
    [SerializeField] private TypeWindow typeWindow;
    public TypeWindow TypeWindow => typeWindow;
}
