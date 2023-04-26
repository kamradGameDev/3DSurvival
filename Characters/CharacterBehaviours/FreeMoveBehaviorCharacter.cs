using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeMoveBehaviorCharacter : IMovable
{
    private Transform transform;
    private Vector3[] pointVariants;

    public FreeMoveBehaviorCharacter(Transform transform, Vector3[] pointVariants)
    {
        this.transform = transform;
        this.pointVariants = pointVariants;
    }

    public void Move()
    {
        //Get random and move
    }
}
