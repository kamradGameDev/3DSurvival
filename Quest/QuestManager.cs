using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System.Linq;

public class QuestManager : MonoBehaviour
{
    public static QuestManager instance { get; private set; }

    private List<QuestBase> activeChapterQuests, activeAnotherQuests;

    [SerializeField] private ChapterQuestsData[] chapters;
    public ChapterQuestsData[] Chapters => chapters;
    
    private void Awake()
    {
        if (!instance)
            instance = this;
    }
    private void Start()
    {
        activeChapterQuests = new List<QuestBase>();
        activeAnotherQuests = new List<QuestBase>();
    }
    public void AddQuest(QuestBase quest)
    {
        activeChapterQuests.Add(quest);
        quest.InitQuest();
    }
    public void RemoveQuest(QuestBase quest)
    {
        activeAnotherQuests.Remove(quest);
        quest.InitQuest();
    }

    private async void Update()
    {
        await Task.Delay(100);

        foreach (var quest in activeAnotherQuests.ToList())
        {
            if (quest.CheckStatusQuest())
                activeAnotherQuests.Remove(quest);
        }

        foreach (var quest in activeChapterQuests.ToList())
        {
            if (quest.CheckStatusQuest())
                activeChapterQuests.Remove(quest);
        }
    }
}
