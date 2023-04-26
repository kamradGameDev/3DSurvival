using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class CharacterEvents 
{
    public static event Func<CharacterBase, IEquipWeaponType> EventCharacterAttack;
}
