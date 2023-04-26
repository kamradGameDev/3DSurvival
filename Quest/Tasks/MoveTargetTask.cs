using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using System.Threading.Tasks;

[CreateAssetMenu(menuName = "Data/Quests/Tasks/NewMoveTask", fileName = "New move tasks", order = 52)]
public class MoveTargetTask : QuestBaseTasks
{
    private Transform nextTarget;

    [SerializeField] private int[] idTargets;
    private int indexTarget;
    public override bool CheckStatus()
    {
        //CheckDistanceToTarget();

        if (indexTarget < idTargets.Length)
            return false;

        return true;
    }

    public override void Init()
    {
        indexTarget = 0;

        ITargetQuestObj targetQuest = DataQuestObjects.instance.FindTargetObj(idTargets[indexTarget]);

        nextTarget = targetQuest.GetTransform();

        nextTarget.GetComponent<MeshRenderer>().material.color = Color.black;
    }

    public override void CheckStatusUI()
    {
        
    }

    private void CheckDistanceToTarget()
    {
        float distToTarget = Vector3.Distance(nextTarget.localPosition, GameManager.instance.Player.transform.localPosition);

        //Debug.Log("dist to target: " + distToTarget);

        if(distToTarget < 3f)
        {
            if (indexTarget < idTargets.Length)
                indexTarget++;
        }
    }
}
