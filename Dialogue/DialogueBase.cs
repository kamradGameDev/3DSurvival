using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "Data/Dialogues/New Dialogue", fileName = "New Dialogue", order = 57)]
public class DialogueBase : ScriptableObject
{
    [Serializable] public struct DialogueTree
    {
        [Serializable] public class Message
        {
            public string[] text;

            public int indexReward;
            public int indexFine = 99999;

            public RewardBase reward;
            public FineBase fine;
        }
        public Message message;

    }
    [SerializeField] private DialogueTree[] dialogueTree;

    public string GetText(string name, int index)
    {
        return name + ": " + dialogueTree[index].message.text[index];
    }

}
