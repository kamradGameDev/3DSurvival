using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SystemEvents 
{
    public static event Action<Vector3> EventRotatePlayerHead;
    public static event Action<StatusGame> GameStatusEvent;
    public static void RotatePlayerHead(Vector3 eulerRotate) =>
        EventRotatePlayerHead?.Invoke(eulerRotate);
    public static void GameStatus(StatusGame statusGame)
    {
        StaticVariables.statusGame = statusGame;
        GameStatusEvent?.Invoke(statusGame);
    }
}
