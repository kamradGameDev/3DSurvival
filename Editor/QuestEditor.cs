using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class QuestEditor : EditorWindow
{
    [MenuItem("DataBase/QuestEditor")]
    public static void ShowWindow()=>
        GetWindow<QuestEditor>();

    private void OnGUI()
    {
        
    }
}
