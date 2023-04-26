using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class MainEventBus
{
    public static event Action<AbilityBase, int> EventActionWithSkill;

    public static event Action<GameObject, int> EventCollisionPartPlayerItem;

    public static event Action<EquipItemBase> PickUpItemEvent;

    public static event Action<TypeRaycast, float> EventUseRaycast;

    public static event Action<TypeAttack> EventUseAttack;

    public static void ActionWithSkill(AbilityBase ability, int newExp) =>
        EventActionWithSkill?.Invoke(ability, newExp);

    public static void CollisionPartPlayerItem(GameObject obj, int damage) =>
        EventCollisionPartPlayerItem?.Invoke(obj, damage);

    public static void EquipItemPlayerItem(EquipItemBase useItem) =>
        PickUpItemEvent?.Invoke(useItem);

    public static void UseRaycast(TypeRaycast typeRaycast, float dist) =>
        EventUseRaycast?.Invoke(typeRaycast, dist);

    public static void UseAttack(TypeAttack typeAttack) =>
        EventUseAttack?.Invoke(typeAttack);

}
