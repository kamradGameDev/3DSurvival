using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "Data/Quests/Tasks/NewKillTask", fileName = "New kill task", order = 52)]
public class KillTask : QuestBaseTasks
{
    [Serializable]
    private struct TargetsKill
    {
        public int targetCountKill;
        public int countKill;
        public TypeEnemy typeTarget;
    }
    [SerializeField] private TargetsKill[] targetsKills;

    public override bool CheckStatus()
    {
        foreach(var item in targetsKills)
        {
            if (item.countKill < item.targetCountKill)
                return false;
        }

        return true;
    }

    public override void CheckStatusUI()
    {
        
    }

    public override void Init()
    {
        
    }
}
