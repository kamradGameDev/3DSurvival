using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICallEvents : MonoBehaviour
{
    public void OpenWindow(GetEnumWindow getEnumWindow)
    {
        TypeWindow typeWindow = getEnumWindow.TypeWindow;

        UIEvents.NewStatusWindow(typeWindow, true);

        SystemEvents.GameStatus(StatusGame.pause);
    }

    public void CloseWindow(GetEnumWindow getEnumWindow)
    {
        TypeWindow typeWindow = getEnumWindow.TypeWindow;

        UIEvents.NewStatusWindow(typeWindow, false);

        SystemEvents.GameStatus(StatusGame.process);
    }
}
