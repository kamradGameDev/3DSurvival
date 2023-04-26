using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPeacefulNPC 
{
    public void OnClick(QuestBase quest)
    {
        quest.InitDialogueWindow();
        QuestManager.instance.AddQuest(quest);
    }
    public void DeactiveQuest(QuestBase quest)
    {

    }
}

public interface IMovableQuestObj
{
    public int GetIdObj();
}
