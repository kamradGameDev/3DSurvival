using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterBase : MonoBehaviour
{
    [SerializeField] private GameObject objSelection;
    public GameObject ObjSelection => objSelection;

    [SerializeField] protected int idObj;

    [SerializeField] private float speedMove = 3f;
    public float SpeedMove => speedMove;
}
