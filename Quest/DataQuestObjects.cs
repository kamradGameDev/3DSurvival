using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AYellowpaper;

public class DataQuestObjects : MonoBehaviour
{
    public static DataQuestObjects instance { get; private set; }
    public List<ITargetQuestObj> targets { get; set; }

    private void Awake()
    {
        if (!instance) instance = this;

        targets = new List<ITargetQuestObj>();
    }

    

    public ITargetQuestObj FindTargetObj(int findId)
    {
        ITargetQuestObj findObj = null;

        foreach(var item in targets)
        {
            if (item.GetIdObj() == findId)
            {
                findObj = item;
                Debug.Log("find quest target: " + findObj.GetTransform().name);
                break;
            }
        }

        return findObj;
    }
}
