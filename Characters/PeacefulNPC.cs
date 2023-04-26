using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AYellowpaper;

public class PeacefulNPC : CharacterBase, IPeacefulNPC, IMovableQuestObj, IInteractObj
{
    [RequireInterface(typeof(IAnotherQuest))]
    [SerializeField] private QuestBase[] quests;
    private IPeacefulNPC peacefulNPC;
    private void Start()
    {
        peacefulNPC = this;
    }

    public int GetIdObj()
    {
        return idObj;
    }

    public void Interact()
    {
        peacefulNPC.OnClick(quests[0]);
    }

    public string GetNameAndStatus()
    {
        return ToString();
    }

    public IHealth GetHealth()
    {
        return null;
    }
}
