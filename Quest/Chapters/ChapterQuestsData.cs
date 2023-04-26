using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AYellowpaper;

[CreateAssetMenu(menuName = "Data/Quests/Chapters/NewChapter", fileName = "NewChapter", order = 53)]
public sealed class ChapterQuestsData : ScriptableObject
{
    [RequireInterface(typeof(IChapterQuest))]
    [SerializeField] private ScriptableObject[] quests;
    //public void ActiveChapter() =>
    //    EventsQuests.StartNewChapter(quests);

    //private int FindTheLastCompletedQuest()
    //{
    //    int idQuest = 0;

    //    for (int i = 0; i < quests.Length; i++)
    //        if (SavedQuestsData.instance.quests[i].statusQuest != 0)
    //            idQuest = i;

    //    return idQuest;
    //}
}
