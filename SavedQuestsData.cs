using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class SavedQuestsData : MonoBehaviour
{
    public static SavedQuestsData instance { get; private set; }
    [Serializable]
    public struct Quests
    {
        public int statusQuest;
        public int[] countActionsTask;
    }
    public Quests[] quests;

    private string path;

    private void Awake()
    {
        if (!instance)
            instance = this;

        path = Application.persistentDataPath + "StatusQuests.json";
        Load();
    }

    private void Load()
    {
        if (!File.Exists(path)) return;

        string json = ReadFromFile();

        LoadData loadData = JsonUtility.FromJson<LoadData>(json);
        for(int i = 0; i < quests.Length; i++)
        {
            quests[i].statusQuest = loadData.quests[i].statusQuest;

            for (int j = 0; j < quests[i].countActionsTask.Length; j++)
                quests[i].countActionsTask[j] = loadData.quests[i].countActionsTask[j];
        }
    }

    public void Saved()
    {
        StreamWriter streamWriter = new StreamWriter(path);
        streamWriter.WriteLine(JsonUtility.ToJson(this));
        streamWriter.Close();
    }

    private string ReadFromFile()
    {
        using (StreamReader reader = new StreamReader(path))
        {
            string json = reader.ReadToEnd();
            return json;
        }
    }

    private class LoadData
    {
        [Serializable]
        public struct Quests
        {
            public int statusQuest;
            public int[] countActionsTask;
        }
        public Quests[] quests;
    }
}
