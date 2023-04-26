using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System;

public enum TypeAttack
{
    none, normal, sideAttack, attackFromAbove
}
public interface IEquipWeaponType : IPickUpObj, IEquipType
{
    public float DistAttack { get; }
    public float DamageWeapon { get; }
    int GetTimeAnimation();
}

public interface IEquipBodyType
{

}

public interface IEquipPantsType
{

}

public interface IEquipType
{
    public Material[] materials { get; }
    public Vector3 angles { get; }
    public Vector3 localPos { get; }
    public Mesh mesh { get; }
}


