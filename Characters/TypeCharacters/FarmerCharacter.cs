using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerCharacter : BaseCitizenCharacter
{
    [SerializeField] private Vector3[] directionTargets;

    protected override void InitBehaviours()
    {
        movable = new PatrolMoveBehaviourCharacter(transform, directionTargets);
        speakable = new DialogueBehaviour();
    }

    private void Update()
    {
        
    }
}
