using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

[CustomEditor(typeof(WeaponLibrary))]
[CanEditMultipleObjects]
public class DataBaseWeaponEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Debug.Log("OnInspectorGUI");
        WeaponLibrary library = (WeaponLibrary)target;
        List<WeaponBase> weapons = library.weapons;

        EditorGUILayout.BeginHorizontal();

        if(GUILayout.Button("Add weapon", GUILayout.Width(170)))
        {
            WeaponBase weapon = CreateInstance<WeaponBase>();
            weapons.Add(weapon);
        }

        if(GUILayout.Button("Saved weapons", GUILayout.Width(170)))
        {
            for(int i = 0; i < weapons.Count; i++)
                if (weapons[i].NameItem == "")
                    weapons.RemoveAt(i);
                else
                {
                    if(weapons[i].NameItem.Equals(string.Empty))
                    {
                        weapons.RemoveAt(i);
                    }

                    if (weapons[i].Icon == null)
                    {
                        Debug.LogError(weapons[i].NameItem + ": icon null");
                        continue;
                    }
                    if (weapons[i].DistAttack == 0)
                    {
                        Debug.LogError(weapons[i].NameItem + ": distance should not be equal to 0");
                        continue;
                    }

                    if(File.Exists("Assets/Data/Items/EquipItems/" + weapons[i].NameItem + ".asset"))
                    {
                        Debug.LogError("Is already: " + weapons[i].NameItem);
                        continue;
                    }

                    AssetDatabase.CreateAsset(weapons[i], "Assets/Data/Items/EquipItems/" + weapons[i].NameItem + ".asset");
                    AssetDatabase.SaveAssets();

                    EditorUtility.FocusProjectWindow();

                    Selection.activeObject = weapons[i];
                }


        }

        EditorGUILayout.EndHorizontal();

        for(int i = 0; i < weapons.Count; i++)
        {
            WeaponBase weapon = weapons[i];

            weapon.NameItem = EditorGUILayout.TextField("Name Item", weapon.NameItem);
            weapon.Icon = (Sprite)EditorGUILayout.ObjectField("Icon", weapon.Icon, typeof(Sprite), false);
            weapon.Mesh = (Mesh)EditorGUILayout.ObjectField("Mesh", weapon.Mesh, typeof(Mesh), false);

            weapon.DistAttack = (float)EditorGUILayout.FloatField("Dist Attack", weapon.DistAttack);
            weapon.DamageWeapon = EditorGUILayout.IntField("Damage", weapon.DamageWeapon);

            EditorGUILayout.LabelField("_____________________________________________");
        }

        EditorGUILayout.HelpBox("Count type weapons: " + weapons.Count, MessageType.Info);

    }
}
