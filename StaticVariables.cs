using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatusGame
{
    loading, start, process, pause
}
public static class StaticVariables 
{
    public static StatusGame statusGame;
}
