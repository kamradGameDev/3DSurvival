using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolMoveBehaviourCharacter : IMovable
{
    private Transform transform;
    private Vector3[] endPoints;

    public PatrolMoveBehaviourCharacter(Transform transform, Vector3[] endPoints)
    {
        this.transform = transform;
        this.endPoints = endPoints;
    }

    public void Move()
    {
        //Get random and move
    }
}
