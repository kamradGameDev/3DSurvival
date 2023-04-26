using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class EventsQuests
{
    public static event Action<QuestBase> StartNewChapterEvent;

    public static void StartNewChapter(QuestBase quest) =>
        StartNewChapterEvent?.Invoke(quest);
}
