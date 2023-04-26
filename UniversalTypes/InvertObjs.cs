using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InvertObjs 
{
    public static bool InvertBool(this ref bool b) => b = !b;
}
