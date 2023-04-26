using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Threading.Tasks;

public abstract class QuestBase : ScriptableObject
{
    public int statusQuest { get; set; }

    [SerializeField] private QuestRewardBase[] questRewards;

    [SerializeField] private int idQuest;

    [SerializeField] private QuestBaseTasks[] questTasks;
    public QuestBaseTasks[] QuestTasks => questTasks;

    private List<QuestBaseTasks> _questTasks;

    [SerializeField] private DialogueBase dialogueBase;
    public void InitDialogueWindow()
    {
        //Debug.Log("start dialogue");
    }
    public void InitQuest()
    {
        _questTasks = questTasks.ToList();

        foreach (var task in _questTasks)
            task.Init();
    }

    private bool CheckStatusTasks()
    { 
        foreach (var task in _questTasks.ToList())
        {
            if (task.CheckStatus())
                _questTasks.Remove(task);

            task.CheckStatusUI();
        }

        if (_questTasks.Count > 0)
            return false;

        return true;
    }

    public bool CheckStatusQuest()
    {
        if (!CheckStatusTasks())
            return false;

        return true;
    }

    public void GetReward()
    {
        foreach (var item in questRewards)
            item.GetReward();
    }
}
