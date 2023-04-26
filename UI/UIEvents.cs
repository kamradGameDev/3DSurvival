using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UIEvents 
{
    public static event Action<string> EventInteractMessage;
    public static event Action<TypeWindow, bool> EventNewStatusWindow;
    public static void NewInteractMessage(string message) =>
        EventInteractMessage?.Invoke(message);
    public static void NewStatusWindow(TypeWindow typeWindow, bool newStatus) =>
        EventNewStatusWindow?.Invoke(typeWindow, newStatus);

}
